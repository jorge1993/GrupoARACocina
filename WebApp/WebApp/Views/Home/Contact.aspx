<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
   Contact
    
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Contact</h2>
    <br />
    <p>
        If you have any doubt or you want to give any advice please contact us in our 
        questionnaire:</p>
    <br />
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Name: * &nbsp;&nbsp;&nbsp; &nbsp;
        <input id="Text1" type="text" /></p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Email: * &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <input id="Text2" type="text" /></p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Observation: * &nbsp;&nbsp; </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       &nbsp;<textarea id="TextArea1" name="S1" 
            style="height: 146px; width: 236px; margin-right: 0px;"></textarea></p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <input id="Sender" type="button" runat="server" value="Send" onclick="Button1_onclick()" class="button" /></p>   
         <script language="javascript" type="text/javascript">
             function Button1_onclick() {
                 alert("Thank you for writing!");
             }
        </script>
        
    <p>
   
</asp:Content>
