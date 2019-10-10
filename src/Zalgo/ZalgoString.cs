using System;
using System.Text;

namespace Zalgo
{
    /// <summary>
    /// Zalgo string container
    /// </summary>
    public class ZalgoString
    {
        private static readonly Random rnd = new Random();
        private readonly string _zalgoString;

        public ZalgoString(string source, FuckUpMode mode = FuckUpMode.Normal, FuckUpPosition position = FuckUpPosition.Middle)
        {
            _zalgoString = Convert(source, mode, position);
        }

        public static implicit operator ZalgoString(string source) => new ZalgoString(source);

        public static implicit operator string(ZalgoString zalgoString) => zalgoString.ToString();

        public override string ToString() => _zalgoString;

        private static string Convert(string source, FuckUpMode mode, FuckUpPosition position)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return source;
            }

            StringBuilder result = new StringBuilder(source.Length);
            int sourceLength = source.Length;

            var addUpCharsCount = 0;
            var addMidCharsCount = 0;
            var addDOwnCharsCount = 0;

            for (int i = 0; i < sourceLength; i++)
            {
                if (IsZalgoChar(source[i]))
                {
                    continue;
                }

                result.Append(source[i]);

                if (source[i] == '\r' || source[i] == '\n')
                {
                    continue;
                }

                switch (mode)
                {
                    case FuckUpMode.Min:
                        addUpCharsCount = RandomNumber(8);
                        addMidCharsCount = RandomNumber(2);
                        addDOwnCharsCount = RandomNumber(8);
                        break;
                    case FuckUpMode.Normal:
                        addUpCharsCount = RandomNumber(10);
                        addMidCharsCount = RandomNumber(4);
                        addDOwnCharsCount = RandomNumber(10);
                        break;
                    case FuckUpMode.Max:
                        addUpCharsCount = RandomNumber(12);
                        addMidCharsCount = RandomNumber(6);
                        addDOwnCharsCount = RandomNumber(12);
                        break;
                }

                var isUpLine = (position & FuckUpPosition.Up) == FuckUpPosition.Up;
                var isMidLine = (position & FuckUpPosition.Middle) == FuckUpPosition.Middle;
                var isBotLine = (position & FuckUpPosition.Bot) == FuckUpPosition.Bot;

                if (isUpLine)
                {
                    for (int j = 0; j < addUpCharsCount; j++)
                    {
                        result.Append(GetZalgoChar(ZalgoChars.ZalgoUp));
                    }
                }

                if (isMidLine)
                {
                    for (int j = 0; j < addMidCharsCount; j++)
                    {
                        result.Append(GetZalgoChar(ZalgoChars.ZalgoMid));
                    }
                }

                if (isBotLine)
                {
                    for (int j = 0; j < addDOwnCharsCount; j++)
                    {
                        result.Append(GetZalgoChar(ZalgoChars.ZalgoDown));
                    }
                }
            }

            return result.ToString();
        }

        private static bool IsZalgoChar(char c)
        {
            foreach (var @char in ZalgoChars.ZalgoUp)
            {
                if (@char == c)
                {
                    return true;
                }
            }

            foreach (var @char in ZalgoChars.ZalgoMid)
            {
                if (@char == c)
                {
                    return true;
                }
            }

            foreach (var @char in ZalgoChars.ZalgoDown)
            {
                if (@char == c)
                {
                    return true;
                }
            }

            return false;
        }

        private static int RandomNumber(int max) => rnd.Next(max);

        private static char GetZalgoChar(char[] arr) => arr[rnd.Next(arr.Length)];
    }
}
