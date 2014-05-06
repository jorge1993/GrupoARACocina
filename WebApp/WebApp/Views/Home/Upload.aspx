<%@ Page Title="Upload" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Upload
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>Upload a new recipe</h2>
    

    
    <table style="width:95%;" border="0">
        <tr>
            <td style="width: 60%">
                <p>Tell us:</p>
    <br />
        <table style="width:90%;">
            <tr>
                <td style="width: 281px">
                    Name: *<br />
                    <input id="Text1" type="text" style="width: 95%" /></td>
                <td style="width: 287px">
                    Photo:<br />
                    <asp:FileUpload ID="FileUpload1" runat="server" style="width: 95%"/>
                </td>
            </tr>
            <tr>
                <td style="width: 281px; height: 49px;">
                    Subtitle:
                    <br />
                    <input id="Text3" type="text" style="width: 95%"/></td>
                <td style="width: 287px; height: 49px;">
                    Video:<br />
                    <input id="Text4" type="text" style="width: 95%"/></td>
            </tr>
            <tr>
                <td style="width: 50%">
                    Preparation time: *<br />
                    <input id="Text2" type="text" style="width: 50%"/>&nbsp;&nbsp; hh:mm</td>
                <td style="width: 50%">
                    Origin:<br />
                    <input id="Text5" type="text" style="width: 95%"/></td>
            </tr>
        </table>
    <br />
    &nbsp;Description: *<br />
    &nbsp;<asp:TextBox ID="TextBox1" runat="server" BorderStyle="Inset" Height="140px" 
        TextMode="MultiLine" style="width: 95%" CssClass="display-field" ></asp:TextBox>

                <br />
                <br />
                Difficulty:*&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="125px" CssClass="tri-state">
                    <asp:ListItem>Easy</asp:ListItem>
                    <asp:ListItem>Medium</asp:ListItem>
                    <asp:ListItem>Hard</asp:ListItem>
                    <asp:ListItem>Impossible</asp:ListItem>
                </asp:DropDownList>
&nbsp;<br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Upload" 
                    Width="80px" CssClass="button" />
                <br />
    </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    </form>

</asp:Content>
