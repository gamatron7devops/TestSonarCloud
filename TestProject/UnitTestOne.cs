using TestSonarCloud;

namespace TestProject
{
    public class UnitTestOne
    {
        [Fact]
        public void TestWeatherForecast()
        {
            WeatherForecast weatherForecast = new WeatherForecast();
            string name = "Foo";
            string strValue = weatherForecast.MethodOne(name);
            Assert.Equal("Hello " + name, strValue);
        }
    }
}