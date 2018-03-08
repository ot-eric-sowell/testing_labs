using System;
using Xunit;

namespace dotnetcore
{
    public class BlackjackCalcTest
    {
        [Fact]
        public void Test1()
        {
            var calculator = new BlackjackCalc();
            var value = calculator.Calc(new string[] {"5", "3"});
            Assert.Equal(8, value);
        }
    }
}
