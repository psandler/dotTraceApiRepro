# Repro of dotTrace problem with the API

This reproduces an issue with the dotTrace API.

From Visual Studio, click the Resharper Test Runner icon on the  "TestTheApi" test method.  Choose "Profile".

The profiler dialogue should pop up.  Choose "Tracing", "Thread cycle time", "Enable inlining", "Merge threads with equal names" and "Use profilier API".  Then click "Run".

Error that is thrown:

JetBrains.Profiler.Windows.Api.ProfilingApiException : Invalid call sequence
   at JetBrains.Profiler.Windows.Api.Impl.Helper.CheckHResult(HResults hr)
   at DotTraceReproCase.TestApi.TestTheApi() in TestApi.cs: line 14
