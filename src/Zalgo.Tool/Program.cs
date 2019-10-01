using System;
using System.Text;

namespace Zalgo.Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var text = args[0];

            var res = new ZalgoString(text, FuckUpMode.Normal, FuckUpPosition.All);
            TextCopy.Clipboard.SetText(res);
            Console.WriteLine("Text copied to buffer");
        }
    }
}
