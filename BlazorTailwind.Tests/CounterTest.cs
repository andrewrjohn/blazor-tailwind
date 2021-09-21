using BlazorTailwind.Pages;
using Bunit;
using Xunit;

namespace BlazorTailwind.Tests
{
    public class CounterTest : TestContext
    {
        
        [Fact]
        public void CounterComponent_ExpectRendersCorrectly()
        {
            // Act
            var cut = RenderComponent<Counter>();

            // Assert
            cut.Find("p").TextContent.MarkupMatches("Current count: 0");
        }
    
        [Fact]
        public void CounterComponent_StartingValueParamPassed_ExpectCorrectStartingValue()
        {
            // Act
            var startingValue = 5;
            var cut = RenderComponent<Counter>(parameters =>
                    parameters.Add(p => p.StartingValue, startingValue)
                    );

            // Assert
            cut.Find("p").TextContent.MarkupMatches($"Current count: {startingValue}");
        }
    }
}