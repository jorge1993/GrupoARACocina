<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="WebApplication1.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Upload

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% if (Session["login"] != null)
       { 
     %>

    <asp:Image ID="Image2" runat="server" 
            ImageUrl="~/Content/ImagesFondo/Upload.png" ImageAlign="AbsMiddle" 
            style="text-align: left" />
    
    <table style="width:95%; margin-left: 40px;" border="0">
        <tr>
            <td style="width: 60%">
    <br />
        <table style="width:90%;">
            <tr>
                <asp:Label ID="MensajeOK" runat="server" Text="" ForeColor="Red">
                </asp:Label>


                <td style="width: 281px">
                    Name: *<br />
                    
                    <asp:TextBox ID="Nombre" runat="server">
                    </asp:TextBox></td>
                     
                <td style="width: 287px">
                
                    Photo:<br />
                    <asp:TextBox ID="Foto" runat="server">
                    </asp:TextBox></td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ControlToValidate="Foto" ForeColor="Red"
                ValidationExpression="^http.*?[.]((jpg)|(png)|(bmp)|(jpeg)|(gif))$" ValidationGroup="25"
                ErrorMessage="The url is not correct!">
                </asp:RegularExpressionValidator>

                
                    
                </td>
            </tr>
            
            <tr>
            <br />
                <td style="width: 281px; height: 49px;">
                <asp:RequiredFieldValidator ID="nameRequirement" runat="server"
                    ControlToValidate="Nombre" ForeColor="Red"
                    ErrorMessage="Please introduce the recipe name." ValidationGroup="25">
                    </asp:RequiredFieldValidator>
                    <br />
                    <br />
                    Subtitle:
                    <br />
                    <asp:TextBox ID="Subtitulo" runat="server">
                    </asp:TextBox></td>
                     
                <td style="width: 287px; height: 49px;">
                    Video:<br />
                    <asp:TextBox ID="Video" runat="server">
                    </asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td style="width: 50%">
                    <br />
                    Preparation time: *<br />
                    <asp:TextBox ID="Tiempo" runat="server">
                    </asp:TextBox>
                     &nbsp;<br /><br />
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="Tiempo" ForeColor="Red"
                    ErrorMessage="Please introduce the preparation time." ValidationGroup="25">
                    </asp:RequiredFieldValidator>
                   


                    </td><br /><br />
                   


                <td style="width: 50%">
                    Origin:<br />
                    <asp:TextBox ID="Origen" runat="server">
                    </asp:TextBox></td>

                   

                     
                    
            </tr>
        </table>
                   


                    <asp:RegularExpressionValidator ID="expresionNumero" runat="server"
                    ControlToValidate="Tiempo" ForeColor="Red"
                    ErrorMessage="The time is a number!"
                    ValidationExpression="\d+" ValidationGroup="25">
                    </asp:RegularExpressionValidator>
                <br />
    <br />
    &nbsp;Description: *<br />
    &nbsp;<asp:TextBox ID="Descripcion" runat="server" BorderStyle="Inset" Height="140px" 
        TextMode="MultiLine" style="width: 95%" CssClass="display-field" ></asp:TextBox>
                <br />
                <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
        ControlToValidate="Descripcion" ForeColor="Red"
        ErrorMessage="Please introduce a description of the recipe." ValidationGroup="25">
        </asp:RequiredFieldValidator>
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
                    
                    Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="22px" Width="125px" CssClass="tri-state">
                    <asp:ListItem>Starter</asp:ListItem>
                    <asp:ListItem>First Plate</asp:ListItem>
                    <asp:ListItem>Second Plate</asp:ListItem>
                    <asp:ListItem>Dessert</asp:ListItem>
                </asp:DropDownList>

                <br />
                <br />

                <br />
                <asp:Button ID="Button1" runat="server" Text="Upload"  ValidationGroup="25" Width="80px" CssClass="button" OnClick="Upload_recipe" />
                <br />
    </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    <%}

       else
       {
           %>

          <asp:Image ID="Image1" runat="server" 
            ImageUrl="~/Content/ImagesFondo/Upload.png" ImageAlign="AbsMiddle" 
            style="text-align: left" />

           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

           <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <span style="font-size: large">This option is only available to <strong>logged</strong> 
    users!<br />
    <br />
    </span><br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If you have an account, please sign in&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="BotonLogin" runat="server" Text="Log In" onclick="Login"/>
           
               &nbsp;&nbsp;&nbsp;&nbsp;<br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           
           If you don't have an account, please register&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="BotonResgister" runat="server" Text="Register"  onclick="Register" />
                           

     &nbsp;
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image3" runat="server" Height="270px" 
        ImageUrl="~/Content/ImagesSystem/ramsay.jpg" Width="327px" />
    <br />
    <br />
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    

           <%
          
       } %>

       <%if (Session["login"] == null)
         { %>

      
      &nbsp;<% }%>

</asp:Content>
