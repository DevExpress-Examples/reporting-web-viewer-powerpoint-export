using DevExpress.Office.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DVCustomExportOption {
    public partial class Default : System.Web.UI.Page {
        XtraReport1 report;
        protected void Page_Load(object sender, EventArgs e) {
            report = new XtraReport1();
            webDocumentViewer.OpenReport(report);
        }

        public void ExportToPowerPoint() {
            // To the desktop (for demo purposes)
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            // image export options
            ImageExportOptions exportOptions = new ImageExportOptions {
                ExportMode = ImageExportMode.SingleFilePageByPage,
                Format = ImageFormat.Png,
                PageBorderColor = Color.White,
                Resolution = 600
            };
            // PowerPoint Presentation
            Size size = CalculateSize();
            Presentation p = new Presentation(size);
            // go through each page
            for(int i = 0; i < report.Pages.Count; i++) {
                // export image
                var file = string.Format(@"{0}\{1}.png", desktop, i);
                exportOptions.PageRange = (i + 1).ToString();
                report.ExportToImage(file, exportOptions);
                // add the image to the presentation
                p.AddPage(file);
                // clean up!
                File.Delete(file);
            }
            // save presentation to desktop
            p.SaveAs(string.Format(@"{0}\Product.ppt", desktop));
            string strRequest = string.Format(@"{0}\Product.ppt", desktop);
            if(!string.IsNullOrEmpty(strRequest)) {
                System.IO.FileInfo file = new System.IO.FileInfo(strRequest);
                if(file.Exists) {
                    Response.Clear();
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    Response.ContentType = "application/octet-stream";
                    Response.WriteFile(file.FullName);
                    Response.End();
                } else {
                    Response.Write("This file does not exist.");
                }
            } else {
                Response.Write("Please provide a file to download.");
            }
        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            ExportToPowerPoint();
        }

        Size CalculateSize() {
            Size size;
            if(report.ReportUnit == ReportUnit.HundredthsOfAnInch)
                size = new Size((int)Units.InchesToPointsF(report.PageSize.Width / 100), (int)Units.InchesToPointsF(report.PageSize.Height / 100));
            else if(report.ReportUnit == ReportUnit.TenthsOfAMillimeter)
                size = new Size((int)Units.MillimetersToPoints(report.PageSize.Width / 10), (int)Units.MillimetersToPoints(report.PageSize.Height / 10));
            else
                size = new Size((int)Units.PixelsToPoints(report.PageSize.Width, 96), (int)Units.PixelsToPoints(report.PageSize.Height, 96));
            return size;
        }
    }
}