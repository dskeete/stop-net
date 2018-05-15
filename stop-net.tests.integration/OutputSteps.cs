using FluentAssertions;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace stop_net.tests.integration
{
    [Binding]
    public class OutputSteps
    {
        public Process _proc { get; private set; }

        [Given(@"an output process")]
        public void GivenAnOutputProcess()
        {
            _proc = new Process();
            _proc.StartInfo.FileName = @"dotnet";
            _proc.StartInfo.Arguments = @"..\..\..\..\stop-net\bin\Debug\netcoreapp2.0\stop-net.dll";
            _proc.StartInfo.UseShellExecute = false;
            _proc.StartInfo.RedirectStandardOutput = true;
        }

        [When(@"the output process is executed")]
        public void WhenTheOutputProcessIsExecuted()
        {
            _proc.Start();
        }

        [Then(@"the output is valid")]
        public void ThenTheOutputIsValid()
        {
            string outPut = _proc.StandardOutput.ReadToEnd();

            _proc.WaitForExit();
            var exitCode = _proc.ExitCode;
            _proc.Close();

            outPut.Should().Be("Stop!" + "\r\n");
        }
    }
}
