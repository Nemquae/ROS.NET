#region USINGZ

using Messages.std_msgs;

#endregion

namespace Messages.rosgraph_msgs
{
    public class Log
    {
        public const byte DEBUG = 1;
        public const byte INFO = 2;
        public const byte WARN = 4;
        public const byte ERROR = 8;
        public const byte FATAL = 16;
        public String file;
        public String function;
        public Header header;
        public byte level;
        public uint line;
        public String msg;
        public String name;
        public String[] topics;
    }
}