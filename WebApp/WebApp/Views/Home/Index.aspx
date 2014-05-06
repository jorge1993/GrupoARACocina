<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<script runat="server">
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Main page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <h2><%= ViewData["Message"] %></h2>
    <p>
        Welcome to ARA Kitchen
    </p>
    <p style="text-align: center">

            <asp:AdRotator ID="AdRotator1" runat="server"  Height = "300" Width="600" AdvertisementFile="~/Content/Banner.xml"/> 
        
        
    </p>
    </form>
</asp:Content>