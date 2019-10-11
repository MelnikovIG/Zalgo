using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ZalgoTests")]
namespace Zalgo
{
    internal static class ZalgoChars
    {
        public static char[] ZalgoUp =
         {
                (char) 0x030d, (char) 0x030e, (char) 0x0304, (char) 0x0305,
                (char) 0x033f, (char) 0x0311, (char) 0x0306, (char) 0x0310,
                (char) 0x0352, (char) 0x0357, (char) 0x0351, (char) 0x0307,
                (char) 0x0308, (char) 0x030a, (char) 0x0342, (char) 0x0343,
                (char) 0x0344, (char) 0x034a, (char) 0x034b, (char) 0x034c,
                (char) 0x0303, (char) 0x0302, (char) 0x030c, (char) 0x0350,
                (char) 0x0300, (char) 0x0301, (char) 0x030b, (char) 0x030f,
                (char) 0x0312, (char) 0x0313, (char) 0x0314, (char) 0x033d,
                (char) 0x0309, (char) 0x0363, (char) 0x0364, (char) 0x0365,
                (char) 0x0366, (char) 0x0367, (char) 0x0368, (char) 0x0369,
                (char) 0x036a, (char) 0x036b, (char) 0x036c, (char) 0x036d,
                (char) 0x036e, (char) 0x036f, (char) 0x033e, (char) 0x035b,
            };

        public static char[] ZalgoDown =
        {
                (char) 0x0316, (char) 0x0317, (char) 0x0318, (char) 0x0319,
                (char) 0x031c, (char) 0x031d, (char) 0x031e, (char) 0x031f,
                (char) 0x0320, (char) 0x0324, (char) 0x0325, (char) 0x0326,
                (char) 0x0329, (char) 0x032a, (char) 0x032b, (char) 0x032c,
                (char) 0x032d, (char) 0x032e, (char) 0x032f, (char) 0x0330,
                (char) 0x0331, (char) 0x0332, (char) 0x0333, (char) 0x0339,
                (char) 0x033a, (char) 0x033b, (char) 0x033c, (char) 0x0345,
                (char) 0x0347, (char) 0x0348, (char) 0x0349, (char) 0x034d,
                (char) 0x034e, (char) 0x0353, (char) 0x0354, (char) 0x0355,
                (char) 0x0356, (char) 0x0359, (char) 0x035a, (char) 0x0323
            };

        public static char[] ZalgoMid =
        {
                (char) 0x0315, (char) 0x031b, (char) 0x0340, (char) 0x0341,
                (char) 0x0358, (char) 0x0321, (char) 0x0322, (char) 0x0327,
                (char) 0x0328, (char) 0x0334, (char) 0x0335, (char) 0x0336,
                (char) 0x034f, (char) 0x035c, (char) 0x035d, (char) 0x035e,
                (char) 0x035f, (char) 0x0360, (char) 0x0362, (char) 0x0338,
                (char) 0x0337, (char) 0x0361, (char) 0x0489
            };
    }
}