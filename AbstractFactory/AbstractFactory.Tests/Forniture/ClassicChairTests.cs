using AbstractFactory.Forniture.Impl.ClassicForniture;
using Xunit;

namespace AbstractFactory.Tests.Forniture
{
    public class ClassicChairTests
    {
        private ClassicChair _chair;
        public ClassicChairTests()
        {
            _chair = new ClassicChair();
        }

        [Fact]
        public void ClassicChair_HasStyle_Classic()
        {
            var actualStyle = _chair.GetStyle();

            var expectedStyle = "Classic";

            Assert.True(actualStyle == expectedStyle , "ClassicChair object style must be 'Classic'");
        }
    }
}