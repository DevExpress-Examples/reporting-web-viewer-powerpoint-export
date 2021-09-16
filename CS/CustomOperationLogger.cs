using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DVCustomExportOption {
    public class CustomOperationLogger : WebDocumentViewerOperationLogger {
        public override ExportedDocument ExportDocumentStarting(string documentId, string asyncExportOperationId, string format, ExportOptions options, PrintingSystemBase printingSystem, Func<ExportedDocument> doExportSynchronously) {
            if(format == "powerPoint") {
                return new ExportedDocument(ExportToPowerPoint(printingSystem, documentId), @"application/vnd.ms-powerpoint", printingSystem.Document.Name + ".ppt");
            }
            return base.ExportDocumentStarting(documentId, asyncExportOperationId, format, options, printingSystem, doExportSynchronously);
        }
        byte[] ExportToPowerPoint(PrintingSystemBase printingSystem, string documentId) {
            // To the temp folder (for demo purposes)  
            var tempFolder = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/PowerPoint/");
            if(!Directory.Exists(tempFolder)) {
                Directory.CreateDirectory(tempFolder);
            }
            // image export options  
            ImageExportOptions exportOptions = new ImageExportOptions {
                ExportMode = ImageExportMode.SingleFilePageByPage,
                Format = ImageFormat.Png,
                PageBorderColor = Color.White,
                Resolution = 600
            };
            // PowerPoint Presentation  
            Size size = CalculateSize(printingSystem);
            Presentation p = new Presentation(size);
            // go through each page  
            for(int i = 0; i < printingSystem.Pages.Count; i++) {
                // export image  
                var file = string.Format(@"{0}\{1}_{2}.png", tempFolder, documentId, i);
                exportOptions.PageRange = (i + 1).ToString();
                printingSystem.ExportToImage(file, exportOptions);
                // add the image to the presentation  
                p.AddPage(file);
                // clean up!  
                File.Delete(file);
            }
            // save presentation  
            string resultFile = string.Format(@"{0}\{1}.ppt", tempFolder, documentId);
            p.SaveAs(resultFile);
            byte[] document = File.ReadAllBytes(resultFile);
            File.Delete(resultFile);
            return document;
        }
        Size CalculateSize(PrintingSystemBase printingSystem) {
            SizeF size = printingSystem.Pages[0].PageSize.ToSize();
            return GraphicsUnitConverter.Convert(size, GraphicsUnit.Document.ToDpi(), GraphicsUnit.Point.ToDpi()).ToSize();
        }
    }
}
