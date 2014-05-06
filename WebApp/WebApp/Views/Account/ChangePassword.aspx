<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<WebApp.Models.ChangePasswordModel>" %>

<asp:Content ID="changePasswordTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Change the password
</asp:Content>

<asp:Content ID="changePasswordContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2> Change the password</h2>
    <p>
       Please fill the form to change the password 
    </p>
    <p>
        The new password must have a minimum length of <%= ViewData["PasswordLength"] %> characters.
    </p>

    <% using (Html.BeginForm()) { %>
        <%= Html.ValidationSummary(true, "The password change cannot be done, please correct the errors and try it again.") %>
        <div>
            <fieldset>
                <legend>Account info</legend>
                
                <div class="editor-label">
                    <%= Html.LabelFor(m => m.OldPassword) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(m => m.OldPassword) %>
                    <%= Html.ValidationMessageFor(m => m.OldPassword) %>
                </div>
                
                <div class="editor-label">
                    <%= Html.LabelFor(m => m.NewPassword) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(m => m.NewPassword) %>
                    <%= Html.ValidationMessageFor(m => m.NewPassword) %>
                </div>
                
                <div class="editor-label">
                    <%= Html.LabelFor(m => m.ConfirmPassword) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(m => m.ConfirmPassword) %>
                    <%= Html.ValidationMessageFor(m => m.ConfirmPassword) %>
                </div>
                
                <p>
                    <input type="submit" value="Change password" class="button" 
                        style="width: 140px" />
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>
