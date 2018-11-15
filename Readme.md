<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/DVCustomExportOption/Default.aspx) (VB: [Default.aspx.vb](./VB/DVCustomExportOption/Default.aspx.vb))
* [Default.aspx.cs](./CS/DVCustomExportOption/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/DVCustomExportOption/Default.aspx.vb))
* [Global.asax](./CS/DVCustomExportOption/Global.asax) (VB: [Global.asax.vb](./VB/DVCustomExportOption/Global.asax.vb))
* [Global.asax.cs](./CS/DVCustomExportOption/Global.asax.cs) (VB: [Global.asax.vb](./VB/DVCustomExportOption/Global.asax.vb))
* [Presentation.cs](./CS/DVCustomExportOption/Presentation.cs) (VB: [Presentation.vb](./VB/DVCustomExportOption/Presentation.vb))
* [XtraReport1.cs](./CS/DVCustomExportOption/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/DVCustomExportOption/XtraReport1.vb))
<!-- default file list end -->
# ASPxWebDocumentViewer - How to add PowerPoint export format to the toolbar


<p>This example demonstrates two techniques. The first technique demonstrates how to add a custom item to the "Export to" drop-down list of the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">HTML5 Document Viewer</a> control. A custom item is added in the client-side <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebScriptsASPxClientWebDocumentViewer_CustomizeMenuActionstopic">ASPxClientWebDocumentViewer.CustomizeMenuActions</a> event handler. The second technique demonstrates how to export a report to the PowerPoint (PPT) file format. Please review the <a href="https://community.devexpress.com/blogs/seth/archive/2011/02/14/exporting-reports-to-powerpoint.aspx">Exporting Reports to PowerPoint</a> article to get more information about this approach.<br></p><p>Note, it is necessary to have MS Office installed on the server machine, since the example has a reference to the <a href="https://blogs.msdn.microsoft.com/tolong/2007/12/02/missing-office-microsoft-office-core-reference/">Microsoft.Office.Core</a> v15 assembly.</p>

<p><b>Important Note:</b> According to the  <a href="https://support.microsoft.com/en-us/help/257757/considerations-for-server-side-automation-of-office">Considerations for server-side Automation of Office</a> article the Power Point export functionality demonstrated in this example may be not completely supported by some web servers.</p>

<br/>


