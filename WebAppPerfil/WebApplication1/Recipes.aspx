<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recipes.aspx.cs" Inherits="WebApplication1.Formulario_web13" %>
<script runat="server">

</script>


<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <p> <p><asp:Image ID="Image2" runat="server" 
            ImageUrl="~/Content/ImagesFondo/Recipes.png" /></p></p>
    <br /><br /><br />
    <p>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      Here are the best food recipes!
    </p>

    <br />
    <div style="margin-left: 40px">
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Right" 
        style="text-align: center">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="textboxSearch" Height="30px" Width="250px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:DropDownList ID="DropDownList1" runat="server" Width="250px" Height="30px" AutoPostBack="false">
            <asp:ListItem>Name</asp:ListItem>
            <asp:ListItem>Author</asp:ListItem>
            <asp:ListItem>Difficulty: Easy</asp:ListItem>
            <asp:ListItem>Difficulty: Medium</asp:ListItem>
            <asp:ListItem>Difficulty: Hard</asp:ListItem>
            <asp:ListItem>Difficulty: Impossible</asp:ListItem>
            </asp:DropDownList> &nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" onclick="do_search" />
            <br />
            <br />
        </asp:Panel>
    </div>
    
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CssClass="table2" DataSourceID="SqlDataSource1" 
        PageSize="5">
        <Columns>
            <asp:ImageField DataImageUrlField="Image" HeaderText="Image">
                <ControlStyle Height="150px" Width="150px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:ImageField>
            <asp:HyperLinkField DataTextField="Name" HeaderText="Name" 
                NavigateUrl="~/RecetaVer.aspx" />
            <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
            <asp:BoundField DataField="Difficulty" HeaderText="Difficulty" 
                SortExpression="Difficulty" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="View Recipe" />
        </Columns>
        <EmptyDataTemplate>
            &nbsp;
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|Database1.mdf;User Instance=true"
        SelectCommand="SELECT [Image], [Name], [Time], [Difficulty] FROM [Recipe] ORDER BY [ID]">
    </asp:SqlDataSource>
    <br />
    <br />

    </asp:Content>


