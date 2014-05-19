<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recipes.aspx.cs" Inherits="WebApplication1.Formulario_web13" %>
<script runat="server">

</script>
<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
   Recipes
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Recipes </h2>
    <p>
      Here are the best food recipes!
    </p>
    <div style="margin-left: 40px">
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Right" 
        style="text-align: center">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="textboxSearch" Height="38px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <select id="Select1" name="Select1" class="select" 
                style="font-family: Tahoma; font-size: small;" >
                <option>Name</option>
                <option>Author</option>
                <option>Difficulty: Easy</option>
                <option>Difficulty: Medium</option>
                <option>Difficulty: Hard</option>
                <option>Difficulty: Impossible</option>
            </select>&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" />
            <br />
            <br />
        </asp:Panel>
    </div>
    
    <br />
    <table class="table" style="border-style: none" align=center>
        <tr>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl ="../../Content/ImagesRecipes/1.jpg" PostBackUrl="~/Recipe1.aspx" /><br />
                </td>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl ="../../Content/ImagesRecipes/2.jpg" PostBackUrl="~/Recipe2.aspx" /><br />
                </td>
            <td>
                 <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl ="../../Content/ImagesRecipes/3.jpg" PostBackUrl="~/Recipe3.aspx" /><br />
                </td>
        </tr>
    </table>
    
    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Recipe1.aspx">Raspberry cake</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Recipe2.aspx">Cheese cake</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Recipe3.aspx">Strawberry cake</asp:HyperLink>
    <br />
    <br />
    <br />
    <br />
  
</asp:Content>
