<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="WebApplication1.LogOn" %>
<script runat="server">

</script>


<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Image ID="Image3" runat="server" 
            ImageUrl="~/Content/ImagesFondo/LoginB.png" ImageAlign="AbsMiddle" 
            style="text-align: left" />

    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Control" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />

     <p style="border-style: double; background-color: #F8F8F8; background-image: url('/Content/Log/fondo_gris.jpg');" 
        align="center">
      <br />

         


        <br />
        <br />
        <% if (Session["login"] == null)
       {
            %>


         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email: * &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="userBox" runat="server">
        </asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="username" runat="server"
        ControlToValidate="userBox" ForeColor=Red
        ErrorMessage="Please introduce your email." ValidationGroup="10"></asp:RequiredFieldValidator>
        <br />
         
        <br />
         <br />

         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

         Password: * &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;           
         <asp:TextBox ID="passBox" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="pass" runat="server"
        ControlToValidate="passBox" ForeColor=Red
        ErrorMessage="Please introduce the password." ValidationGroup="10"></asp:RequiredFieldValidator>
        <br />
         
        <br />
         <br />
        <asp:Button ID="sender" runat="server" Text="Enter" ValidationGroup="10" onclick="sender_Click" />

        <% }
       else
       { 
        Response.Redirect("Index.aspx");

         } %>

<br /><br />
    </p>
   

    </asp:Content>

