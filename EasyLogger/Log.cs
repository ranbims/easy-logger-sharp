using System.Diagnostics.Tracing;

namespace EasyLogger
{
    public class Log
    {
        private static EasyLoggerEventSource eventSource = new EasyLoggerEventSource();

        public static void V(string message) 
        {
            eventSource.Write(message, constructOptions(EventLevel.Verbose));
        }

        public static void I(string message)
        {
            eventSource.Write(message, constructOptions(EventLevel.Informational));
        }

        public static void W(string message)
        {
            eventSource.Write(message, constructOptions(EventLevel.Warning));
        }

        public static void E(string message)
        {
            eventSource.Write(message, constructOptions(EventLevel.Error));
        }

        public static void C(string message)
        {
            eventSource.Write(message, constructOptions(EventLevel.Critical));
        }

        private static EventSourceOptions constructOptions(EventLevel level)
        {
            return new EventSourceOptions() { Level = level };
        }
    }
}
