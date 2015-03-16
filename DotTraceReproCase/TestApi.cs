using JetBrains.Profiler.Windows.Api;
using NUnit.Framework;

namespace DotTraceReproCase
{
    [TestFixture]
    public class TestApi
    {
        [Test]
        public void TestTheApi()
        {
            if (PerformanceProfiler.IsActive)
            {
                PerformanceProfiler.Begin(); //THIS THROWS AN EXCEPTION!!!
                PerformanceProfiler.Start();
            }

            if (PerformanceProfiler.IsActive)
            {
                PerformanceProfiler.Stop();
                PerformanceProfiler.EndSave();
            } 
        }
    }
}
