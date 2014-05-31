<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogOnOK.aspx.cs" Inherits="WebApplication1.LogOnOK" %>
<script runat="server">

</script>
<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
   Log in
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Log in </h2>

    
    <% if (Session["login"] != null)
       {
            %>
     <p>
     You have logged as
            <asp:Label ID="Label1" runat="server" Font-Underline="True" ForeColor="Red" 
                Text="Label"></asp:Label>
<br /><br />
    </p>
    <% }
       else
       { 
        Response.Redirect("LogOn.aspx");

         } %>

    </asp:Content>