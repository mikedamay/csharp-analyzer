using Xunit;

namespace Exercism.Analyzers.CSharp.IntegrationTests
{
    public partial class ExerciseAnalyzerTests
    {
        [Fact]
        public void Single()
        {
            var testSolution = new TestSolution("gigasecond", "Gigasecond", "Solutions/Gigasecond/Add/Block");
            SolutionShouldBeCorrectlyAnalyzed(testSolution);
        }
    }
}