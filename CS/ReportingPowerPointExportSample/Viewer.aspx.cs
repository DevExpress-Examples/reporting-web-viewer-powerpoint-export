using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportingPowerPointExportSample {    public partial class Viewer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxWebDocumentViewer1.OpenReport(new TestReport());
        }
    }
}
