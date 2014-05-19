<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="WebApplication1.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Upload

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <h2>Upload a new recipe</h2>
    
    <table style="width:95%; margin-left: 40px;" border="0">
        <tr>
            <td style="width: 60%">
    <br />
        <table style="width:90%;">
            <tr>
                <td style="width: 281px">
                    Name: *<br />
                    
                    <asp:TextBox ID="Text1" runat="server">
                    </asp:TextBox></td>
                     
                <td style="width: 287px">
                
                    Photo:<br />
                    <asp:FileUpload ID="FileUpload1" runat="server" style="width: 95%"/>
                </td>
            </tr>
            
            <tr>
            <br />
                <td style="width: 281px; height: 49px;">
                <asp:RequiredFieldValidator ID="nameRequirement" runat="server"
                    ControlToValidate="Text1" ForeColor=Red
                    ErrorMessage="Please introduce the recipe name." ValidationGroup="2"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    Subtitle:
                    <br />
                    <asp:TextBox ID="Text2" runat="server">
                    </asp:TextBox></td>
                     
                <td style="width: 287px; height: 49px;">
                    Video:<br />
                    <input id="Text4" type="text" style="width: 95%"/></td>
            </tr>
            <tr>
                <td style="width: 50%">
                    Preparation time: *<br />
                    <asp:TextBox ID="Text3" runat="server">
                    </asp:TextBox>
                     &nbsp;hh:mm<br /><br />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="Text3" ForeColor=Red
                    ErrorMessage="Please introduce the preparation time." ValidationGroup="2"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp; </td><br /><br />
                <td style="width: 50%">
                    Origin:<br />
                    <asp:TextBox ID="Text4" runat="server">
                    </asp:TextBox></td>
                    
            </tr>
        </table>
    <br />
    &nbsp;Description: *<br />
    &nbsp;<asp:TextBox ID="TextBox1" runat="server" BorderStyle="Inset" Height="140px" 
        TextMode="MultiLine" style="width: 95%" CssClass="display-field" ></asp:TextBox>
                <br />
                <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
        ControlToValidate="TextBox1" ForeColor=Red
        ErrorMessage="Please introduce a description of the recipe." ValidationGroup="2"></asp:RequiredFieldValidator>
                <br />
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
                <br />
                <asp:Button ID="Button1" runat="server" Text="Upload"  ValidationGroup="2" 
                    Width="80px" CssClass="button" />
                <br />
    </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>


</asp:Content>
