<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Viewer.aspx.vb" Inherits="ReportingPowerPointExportSample.Viewer" %>
<%@ Register Assembly="DevExpress.XtraReports.v23.2.Web.WebForms, Version=23.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">

	<script type="text/javascript">
		function CustomizeMenuActions(s, e) {
			var actionExportTo = e.GetById(DevExpress.Reporting.Viewer.ActionId.ExportTo);
			actionExportTo.items()[0].items.push({
				format: "powerPoint",  
				text: "Power Point",
			});
		}
	</script>

	<dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server">
		<ClientSideEvents CustomizeMenuActions="CustomizeMenuActions" />
	</dx:ASPxWebDocumentViewer>
</asp:Content>