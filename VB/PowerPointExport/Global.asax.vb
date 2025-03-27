Imports System
Imports System.Web
Imports DevExpress.XtraReports.Web
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace PowerPointExport

    Public Class Global_asax
        Inherits HttpApplication

        Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            Routing.RouteTable.Routes.MapPageRoute("defaultRoute", "", "~/Default.aspx")
            Native.WebDocumentViewerBootstrapper.SessionState = SessionState.SessionStateBehavior.Default
            Call DefaultWebDocumentViewerContainer.RegisterSingleton(Of WebDocumentViewerOperationLogger, CustomOperationLogger)()
            Net.ServicePointManager.SecurityProtocol = Net.ServicePointManager.SecurityProtocol Or Net.SecurityProtocolType.Tls12
            Call ASPxWebDocumentViewer.StaticInitialize()
            DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize(Sub(ex, message) System.Diagnostics.Debug.WriteLine("[{0}]: Exception occurred. Message: '{1}'. Exception Details:" & Microsoft.VisualBasic.Constants.vbCrLf & "{2}", Date.Now, message, ex))
            AddHandler DevExpress.Web.ASPxWebControl.CallbackError, New EventHandler(AddressOf Application_Error)
        End Sub

        Private Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
        End Sub

        Private Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
        End Sub

        Private Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
        End Sub

        Private Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
        End Sub
    End Class
End Namespace
