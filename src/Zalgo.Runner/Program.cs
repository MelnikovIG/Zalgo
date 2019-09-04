namespace Zalgo.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new ZalgoString("brown fox jumping over lazy dog", FuckUpMode.Normal, FuckUpPosition.All);
        }
    }
}
