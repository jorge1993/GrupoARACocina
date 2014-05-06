<%@ Page Title="User" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Usuario
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Usuario - Norverto Machine</h2>
    <hr />
    <table class=table2>
        <tr>
            <td>Recipe's name
            </td>
            <td>Difficulty
            </td>
            <td>Time
            </td>
        </tr>
        <tr>
            <td><%= Html.ActionLink("Raspberry Cake", "Recipe", "Home")%>
            </td>
            <td>
                Hard
            </td>
            <td>
                1:30
            </td>
        </tr>
        <tr>
            <td><%= Html.ActionLink("Strawberry Cake", "Recipe", "Home")%>
            </td>
            <td>
                Hard
            </td>
            <td>
                2:15
            </td>
        </tr>
    </table>
    <br />
    <p  style="text-align: center">&lt;&lt; &lt;1 
    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True">2</asp:HyperLink> 3 4 &gt; &gt;&gt;<br />
    </p>

</asp:Content>
