<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Viewer.aspx.cs" Inherits="PowerPointExport.Viewer" %>
<%@ Register Assembly="DevExpress.XtraReports.v24.2.Web.WebForms, Version=24.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function CustomizeMenuActions(s, e) {
            const actionExportTo = e.GetById(DevExpress.Reporting.Viewer.ActionId.ExportTo);
            const newFormat = { format: 'powerPoint', text: 'Power Point' };
            if (actionExportTo) {
                actionExportTo.events.on('propertyChanged', (args) => {
                    const formats = actionExportTo.items[0].items;
                    if (args.propertyName === 'items' && formats.indexOf(newFormat) === -1) {
                        formats.push(newFormat);
                    }
                });
            }
        }
    </script>

    <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server">
        <ClientSideEvents CustomizeMenuActions="CustomizeMenuActions" />
    </dx:ASPxWebDocumentViewer>
</asp:Content>