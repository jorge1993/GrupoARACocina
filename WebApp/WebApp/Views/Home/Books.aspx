<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
   Books
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Books</h2>
    <p>
       We have the following books on sale:
        <a href="http://mygrandmaskitchen.com/">The Grandma's kitchen</a>
        <br /> <br />
        </p>
        <table class="table">
            <tr>
                <td style = "width:33%">
                    <img alt="Book" src="../../Content/ImagesBooks/4.jpg" /></td>
                <td style = "width:33%">
                    <img alt="Book" src="../../Content/ImagesBooks/2.jpg" /></td>
                <td style = "width:33%">
                    <img alt="Book" src="../../Content/ImagesBooks/3.jpg" /></td>
            </tr>
        </table>
        
    
</asp:Content>