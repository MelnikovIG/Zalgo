namespace Zalgo.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "brown fox jumping over lazy dog";

            var res = new ZalgoString(text, FuckUpMode.Normal, FuckUpPosition.All);
            ZalgoString zalgoString = text;
            string res2 = zalgoString;
        }
    }
}
