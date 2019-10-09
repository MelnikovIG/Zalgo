using System;
using System.Text;

namespace Zalgo.Tool
{
    class Program
    {
        /// <summary>
        /// The tool for generationg zalgo text
        /// </summary>
        /// <param name="input">Text for processing</param>
        /// <param name="fuckUpMode">Fuck Up mode</param>
        /// <param name="fuckUpPosition">Fuck Up position</param>
        static void Main(string input, FuckUpMode fuckUpMode = FuckUpMode.Normal,
            FuckUpPosition fuckUpPosition = FuckUpPosition.All)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input must not be null");
                return;
            }

            var res = new ZalgoString(input, fuckUpMode, fuckUpPosition);
            TextCopy.Clipboard.SetText(res);
            Console.WriteLine("Text copied to buffer");
        }
    }
}