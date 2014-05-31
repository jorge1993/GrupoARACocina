<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterOK.aspx.cs" Inherits="WebApplication1.RegisterOK" %>
<script runat="server">

</script>
<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
   Register
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Register </h2>
    <br />

    <% if (Session["login"] != null)
       {
            %>

    <div>
        <p>
        You have registered and logged in as 
            <asp:Label ID="Label1" runat="server" Font-Underline="True" ForeColor="Red" 
                Text="Label"></asp:Label>.
            

        </p>
        <br />

    </div>

    <% }
       else
       { 
        Response.Redirect("Register.aspx");

         } %>

    </asp:Content>
