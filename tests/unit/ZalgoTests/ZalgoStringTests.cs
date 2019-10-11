using System;
using System.Linq;
using Xunit;
using Zalgo;

namespace ZalgoTests
{
    public class ZalgoStringTests
    {
        private readonly string _text;

        public ZalgoStringTests()
        {
            _text = Guid.NewGuid().ToString();
        }

        [Fact]
        public void ZalgoString_ShouldContain_AtLeastOneUpChar_When_FuckUpPosition_Is_Up()
        {
            //Act
            string result = new ZalgoString(_text, position: FuckUpPosition.Up);

            //Assert
            Assert.Contains(result, ZalgoChars.ZalgoUp.Contains);
        }

        [Fact]
        public void ZalgoString_ShouldContain_AtLeastOneMiddleChar_When_FuckUpPosition_Is_Middle()
        {
            //Act
            string result = new ZalgoString(_text, position: FuckUpPosition.Middle);

            //Assert
            Assert.Contains(result, ZalgoChars.ZalgoMid.Contains);
        }

        [Fact]
        public void ZalgoString_ShouldContain_AtLeastOneBottomChar_When_FuckUpPosition_Is_Bot()
        {
            //Act
            string result = new ZalgoString(_text, position: FuckUpPosition.Bot);

            //Assert
            Assert.Contains(result, ZalgoChars.ZalgoDown.Contains);
        }
    }
}
