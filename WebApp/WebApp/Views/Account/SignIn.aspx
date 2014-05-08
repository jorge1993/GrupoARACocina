<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<script runat="server">
</script>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <h2>SingUp</h2>
    <hr />
    <p>Complete the form:</p>

    <table class="table2">
    <tr><td style="width: 229px"><strong>Nick:</strong>
    </td>
    <td><asp:TextBox ID = "Nick" runat="server" />*<br />
        </td>
    </tr>
    <tr><td style="height: 27px"><strong>Email: </strong></td>
    <td class="style2" style="height: 27px"><asp:TextBox ID="Email" runat="server" 
        Font-Names="Verdana"></asp:TextBox>*<br />
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator2" runat="server" ControlToValidate="Email" 
            ErrorMessage="Invalid Email" ForeColor="Red" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr><td style="height: 31px"><strong>Email verification: </strong></td>
    <td style="height: 31px" ><asp:TextBox ID="ConfirmEmail" runat="server" 
        Font-Names="Verdana"></asp:TextBox>
        *<br />
       <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ErrorMessage="Email doesn't match"
        ControlToCompare="ConfirmEmail" 
        ControlToValidate="Email"
        ForeColor="Red"></asp:CompareValidator>
                </td>
    </tr>
      <tr>
    <td><strong>Password: </strong></td>
    <td><asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" 
        Font-Names="Verdana"></asp:TextBox>
        *<br />
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator7" runat="server" 
            ErrorMessage="Must have alphanumeric values ​​and minimum length of 8"
            ForeColor="Red" 
            ValidationExpression="^[a-zA-Z0-9]{8,20}$" 
            ControlToValidate="passwordTextBox" ></asp:RegularExpressionValidator>
          </td>
    </tr>
   <tr>
    <td><strong>Confirm Password: </strong></td>
        <td><asp:TextBox ID="confirmpasswordTextBox" runat="server" 
        TextMode="Password" Font-Names="Verdana"></asp:TextBox>
            *&nbsp;
            <br />
            <asp:CompareValidator ID="CompareValidator3" runat="server" 
        ErrorMessage="Passwords doesn't match"
        ControlToCompare="passwordTextBox" 
        ControlToValidate="confirmpasswordTextBox"
        ForeColor="Red"></asp:CompareValidator>
          </td>
    </tr>
    </tr>
    <tr><td style="width: 229px"><strong>Name:</strong>
    </td>
    <td><asp:TextBox ID = "TextBox5" runat="server" />
        <br />
        </td>
    </tr>
    <tr><td style="width: 229px"><strong>Surname: </strong>
    </td>
    <td><asp:TextBox ID = "TextBox6" runat="server" />
        <br />
        </td>
    </tr>
    <tr><td style="width: 229px"><strong>Country:</strong>
    </td>
    <td><asp:TextBox ID = "TextBox7" runat="server" />
        <br />
        </td>
    </tr>
    <tr><td style="width: 229px"><strong>Birth date</strong>
    </td>
    <td>
    <asp:TextBox ID="Date" runat="server"
        Font-Names="Verdana"></asp:TextBox>*<asp:RegularExpressionValidator 
            ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="dd/mm/yyy"
            ForeColor="Red" 
            ValidationExpression="^\d{2}/\d{2}/\d{4}$" 
            ControlToValidate="Date" ></asp:RegularExpressionValidator></td>
    </tr><td class="style2">
        <asp:Button ID="Button1" runat="server" Text="Sign in" 
             CssClass="button" Height="47px" Width="95px"/>
        </td><td>
        <asp:Label ID="Label1" runat="server" ForeColor="Red" ></asp:Label></td>
</tr>

    </table>
    (*) Campos obligatorios


    </form>
</asp:Content>
