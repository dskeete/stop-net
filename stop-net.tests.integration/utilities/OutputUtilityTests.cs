using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using stop_net.utilities;

namespace stop_net.tests.integration.utilities
{
    [TestClass]
    public class OutputUtilityTests
    {
        [TestMethod]
        public void WriteLineReturnsCorrectOutput()
        {
            OutputUtility.Instance.WriteLine().Should().Be("Stop!");
        }
    }
}
