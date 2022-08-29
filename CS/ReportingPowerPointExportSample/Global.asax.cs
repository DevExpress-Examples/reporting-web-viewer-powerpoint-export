using System;
using System.IO;
using System.Web;
using DevExpress.XtraReports.Web;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace ReportingPowerPointExportSample {
    public class Global_asax : System.Web.HttpApplication {
        void Application_Start(object sender, EventArgs e) {
            System.Web.Routing.RouteTable.Routes.MapPageRoute("defaultRoute", "", "~/Default.aspx");
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DefaultWebDocumentViewerContainer.RegisterSingleton<WebDocumentViewerOperationLogger, CustomOperationLogger>();


            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
            ASPxWebDocumentViewer.StaticInitialize();

            DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize((ex, message) => System.Diagnostics.Debug.WriteLine("[{0}]: Exception occurred. Message: '{1}'. Exception Details:\r\n{2}", DateTime.Now, message, ex));

            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(Application_Error);
        }

        void Application_End(object sender, EventArgs e) {
            // Code that runs on application shutdown
        }
    
        void Application_Error(object sender, EventArgs e) {
            // Code that runs when an unhandled error occurs
        }
    
        void Session_Start(object sender, EventArgs e) {
            // Code that runs when a new session is started
        }
    
        void Session_End(object sender, EventArgs e) {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
        }
    }
}
