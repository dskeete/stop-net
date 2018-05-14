using System;

namespace stop_net.utilities
{
    public class OutputUtility
    {
        public static OutputUtility Instance { get { return Implementation; } }
        public static OutputUtility Implementation = new OutputUtility();

        private OutputUtility() { }

        public string WriteLine() => "Stop!";
    }
}
