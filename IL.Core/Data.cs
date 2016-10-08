using System.Threading;

namespace IL.Core {
    public static class Data {

        static Data() {
            Description = "Intersectional Life";
        }

        public static string Description { get; set; }
    }
}