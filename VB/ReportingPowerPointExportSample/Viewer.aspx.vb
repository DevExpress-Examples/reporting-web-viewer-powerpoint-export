Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace ReportingPowerPointExportSample
	Partial Public Class Viewer
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxWebDocumentViewer1.OpenReport(New TestReport())
		End Sub
	End Class
End Namespace
