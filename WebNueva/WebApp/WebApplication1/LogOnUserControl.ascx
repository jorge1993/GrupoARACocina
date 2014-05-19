<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LogOnUserControl.ascx.cs" Inherits="WebApplication1.LogOnUserControl1" %>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome <b><%= Page.User.Identity.Name %></b> !
        [ <%= Html.ActionLink("Log off", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        [ <%= Html.ActionLink("Log in | Register", "LogOn", "Account") %> ]
<%
    }
%>