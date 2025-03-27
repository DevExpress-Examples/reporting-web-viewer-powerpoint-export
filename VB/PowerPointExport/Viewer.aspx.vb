Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace PowerPointExport

    Public Partial Class Viewer
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxWebDocumentViewer1.OpenReport(New TestReport())
        End Sub
    End Class
End Namespace
