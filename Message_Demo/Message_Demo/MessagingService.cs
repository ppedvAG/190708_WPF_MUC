using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Message_Demo
{
    public static class MessagingService
    {
        public static class Messages
        {
            public const string SliderValueChanged = "ABC";
            public const string ButtonClicked = "DEF";
            public const string TextBoxValueChanged = "HIJ";
        }
        private static Dictionary<string, List<Action<object>>> subscribers = new Dictionary<string, List<Action<object>>>();


        public static void Subscribe(string message,Action<object> callback)
        {
            if (!subscribers.ContainsKey(message))
                subscribers.Add(message, new List<Action<object>>());

            if (subscribers[message].Contains(callback))
                return;

            subscribers[message].Add(callback);
        }

        public static void Unsubscribe(string message, Action<object> callback)
        {
            if (!subscribers.ContainsKey(message))
                return;

            if (!subscribers[message].Contains(callback))
                return;

            subscribers[message].Remove(callback);
        }

        public static void Publish(string message, object data)
        {
            var listOfCallbacks = subscribers.FirstOrDefault(x => x.Key == message).Value;
            if (listOfCallbacks == null)
                return;// es gibt keine subscriber

            // Idee: TPL die Aufrufe parallelisieren
            foreach (var callback in listOfCallbacks)
                callback?.Invoke(data);
                //ThreadPool.QueueUserWorkItem(x => callback?.Invoke(data));
        }
    }
}
