# CrystalReportsProblem_minimal_example

See https://answers.sap.com/questions/13080298/crystal-reports-problem-using-net-dll-as-connectio.html

I have trouble using a .NET dll as a connection (i.e. "ADO.NET (XML)").

I'm using Visual Studio 2017, .NET Framework 4.7.2 and Crystal Reports 13.0.21.2533.

I prepared a small example solution to illustrate the problem.

There are 3 projects involved:

    "PresentationLayer" is a windows forms app containing a report and a viewer.
    "BusinessLayer" is a .NET class library that is part of the solution
    "BusinessLayerExternal" is a .NET class library that isn't part of the solution (compile once and remove)

I open the PresentationLayer.PL_CR report in Visual Studio Designer, switch to Field Explorer, right click on Database Fields and select Set Datasource Location; Create New Connection - ADO.NET (XML) - Make New Connection; select the BusinessLayer.dll and choose in the drop down my dummy data class.

I repeat last steps for BusinessLayerExternal.dll.

After that, connections tree looks like following.

For some reason, the class from BusinessLayerExternal.dll isn't available, despite the fact I did select it in the Connection Information window.

So I use the BusinessLayer.Class1 on my report.

When I start the program and assign the report as DataSource of a ReportViewer, I'm prompted with a Database Login window for the BusinessLayer.Class1-server.

What am I doing wrong and how do I do it right?

The most frustrating part about this is, the same setup does work with Visual Studio 2008 and Crystal Reports 10.5.0.1943.
