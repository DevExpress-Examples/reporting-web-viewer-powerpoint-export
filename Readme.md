<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597920/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T457196)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for ASP.NET Web Forms - Web Document Viewer - Add PowerPoint Export Format

In this example a **Power Point** item is added to the list of availailable export formats in the Web Document Viewer, and the custom **ExportToPowerPoint** method is implemented.

The [CustomizeMenuActions](https://docs.devexpress.com/XtraReports/js-ASPxClientWebDocumentViewer#js_aspxclientwebdocumentviewer_customizemenuactions) event is handled to add a custom menu item. 

The application registers a **CustomOperationLogger** class as the [WebDocumentViewerOperationLogger](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogge) service. The **CustomOperationLogger** class overrides the [ExportDocumentStarting](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogger.N----F-y-----8-p) method to call the **ExportToPowerPoint** method when the user initializes export to PowerPoint.


![Web Document Viewer Export to Microsoft PowerPoint](Images/screenshot.png)

You have to install the [Office Developer Tools](https://visualstudio.microsoft.com/vs/features/office-tools/) for Visual Studio to build the project, and have a local Microsoft Office (PowerPoint) installation to run the project.

## Files to Review

- [CustomOperationLogger.cs](CS/ReportingPowerPointExportSample/Services/CustomOperationLogger.cs) ([CustomOperationLogger.vb](VB/ReportingPowerPointExportSample/Services/CustomOperationLogger.vb))
- [Presentation.cs](CS/ReportingPowerPointExportSample/Services/CustomOperationLogger.cs) ([CustomOperationLogger.vb](VB/ReportingPowerPointExportSample/Services/Presentation.vb))
- [Global.asax.cs](CS/ReportingPowerPointExportSample/Global.asax.cs) ([Global.asax.vb](VB/ReportingPowerPointExportSample/Global.asax.vb))
- [Viewer.aspx](CS/ReportingPowerPointExportSample/Viewer.aspx) ([Viewer.aspx](VB/ReportingPowerPointExportSample/Viewer.aspx))

## Documentation

- [Blog: Exporting Reports to PowerPoint](https://community.devexpress.com/blogs/seth/archive/2011/02/14/exporting-reports-to-powerpoint.aspx)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-viewer-powerpoint-export&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-viewer-powerpoint-export&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
