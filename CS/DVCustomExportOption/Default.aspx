<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DVCustomExportOption.Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v16.1.Web, Version=16.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraReports.v16.1.Web, Version=16.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web.WebDocumentViewer" TagPrefix="cc1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script type="text/javascript">
    function CustomizeMenuActions(s, e) {
        var actionExportTo = e.GetById(DevExpress.Report.Preview.ActionId.ExportTo);
        actionExportTo.items()[0].items.push({
            format: "powerPoint",
            text: "Power Point",
        });
        var actionExportToClick = actionExportTo.clickAction;
        actionExportTo.clickAction = function (arg) {
            if (arg.itemData.format === "powerPoint") {
                aspxButton1.DoClick();
            }
            else
                actionExportToClick(arg);
        }
    }
</script>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer">
                <ClientSideEvents CustomizeMenuActions="CustomizeMenuActions" />
            </dx:ASPxWebDocumentViewer>

        </div>
        <dx:ASPxButton ID="ASPxButton1" runat="server" ClientVisible="False" OnClick="ASPxButton1_Click" Text="ASPxButton" ClientInstanceName="aspxButton1">
        </dx:ASPxButton>
    </form>
</body>
</html>
