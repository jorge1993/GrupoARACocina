<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<WebApp.Models.ChangePasswordModel>" %>

<asp:Content ID="changePasswordTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Change the password
</asp:Content>

<asp:Content ID="changePasswordContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <h2> Change the password</h2>
    <p>
       Please fill the form to change the password 
    </p>
    <p>
        The new password must have a minimum length of <%= ViewData["PasswordLength"] %> characters.
    </p><br />
        <table style="width:100%;">
            <tr>
                <td style="width: 125px">New Password</td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Password must have alphanumeric values with more than 8 characteres" 
                        ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$ "></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 125px">Repeat Password</td>
                <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ErrorMessage="Password not equal" ></asp:CompareValidator>
                </td>
            </tr>
        </table>
        <br />
    <asp:Button ID="Button1" runat="server" Text="Change Password" 
        CssClass="button" Height="50px" Width="141px" />
    </form>

    
</asp:Content>
