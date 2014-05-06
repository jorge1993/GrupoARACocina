<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<script runat="server">

protected void  ImageButton1_Click(object sender, ImageClickEventArgs e)
{      
    Response.Redirect("../../Views/Home/Recipe.aspx");
}

protected void ImageButton2_Click(object sender, EventArgs e)
{
    Response.Redirect("Recipe.aspx");
}

protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
{
    Response.Redirect("Recipe.aspx");
}
    
    
    
    
    
</script>
<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
   Recipes
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <h2>Recipes </h2>
    <p>
      Here are the best food recipes!
    </p>
    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Right">
    <asp:TextBox ID="TextBox1" runat="server" CssClass="textboxSearch" 
            Font-Size="Medium" Height="31px"></asp:TextBox>
    <select id="Select1" name="Select1" class="select" 
            style="width: 240px; height: 31px; font-size: medium; font-family: 'Comic Sans MS';" >
        <option>Search by...</option>
        <option>Name</option>
        <option>Auth</option>
        <option>Difficulty -- Easy</option>
        <option>Difficulty -- Medium</option>
        <option>Difficulty -- Hard</option>
        <option>Difficulty -- Impossible</option>
    </select><asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" />
    </asp:Panel>
    
    <br />
    <table class="table">
        <tr>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl ="../../Content/ImagesRecipes/1.jpg" 
                    onclick="ImageButton1_Click" />
                    <br /><%= Html.ActionLink("Raspberry Cake", "Recipe", "Home")%>
                </td>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl ="../../Content/ImagesRecipes/2.jpg"/><br />
                <%= Html.ActionLink("Strawberry Cake", "Recipe", "Home")%>
                </td>
            <td>
                 <asp:ImageButton ID="ImageButton3" runat="server" 
                 ImageUrl ="../../Content/ImagesRecipes/3.jpg" onclick="ImageButton3_Click"/><br />
                 <%= Html.ActionLink("Strawverry Cake with Milk", "Recipe", "Home")%>
                </td>
        </tr>
    </table>
    
    <br />
    <p  style="text-align: center">&lt;&lt; &lt;1 
    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True">2</asp:HyperLink> 3 4 &gt; &gt;&gt;<br />
    </p>
    </form>
</asp:Content>