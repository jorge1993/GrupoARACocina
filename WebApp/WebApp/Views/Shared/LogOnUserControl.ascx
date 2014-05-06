<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome <b><%= Page.User.Identity.Name %></b> !
        [ <%= Html.ActionLink("Log off", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        [ <%= Html.ActionLink("Log in", "LogOn", "Account") %> ]
<%
    }
%>
