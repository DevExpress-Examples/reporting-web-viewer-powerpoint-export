﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DVCustomExportOption.Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web.WebDocumentViewer" TagPrefix="cc1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script type="text/javascript">
    function CustomizeMenuActions(s, e) {
        var actionExportTo = e.GetById(DevExpress.Report.Preview.ActionId.ExportTo);
        actionExportTo.items()[0].items.push({
            format: "powerPoint", //This value will be passed to "ExportDocumentStarting" method automatically  
            text: "Power Point",
        });
    }  
</script>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer">
                <ClientSideEvents CustomizeMenuActions="CustomizeMenuActions" />
            </dx:ASPxWebDocumentViewer>
        </div>
    </form>
</body>
</html>
