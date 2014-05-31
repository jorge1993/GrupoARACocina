<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Formulario_web11" %>


<script runat="server">
</script>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
    <p><asp:Image ID="Image2" runat="server" 
            ImageUrl="~/Content/ImagesFondo/Home.png" /></p>

    <p style="font-size: x-large; text-align: center">
        Welcome to <span style="color: #CC0000">
        <strong style="color: #AEA8BB">ARA Kitchen</strong></span>
    </p>
    <p style="text-align: center">

            <asp:AdRotator ID="AdRotator1" runat="server"  Height = "264px" Width="721px" 
                AdvertisementFile="~/Content/Banner.xml"/> 
       
        
    </p> <br /><br />

    <p align="left" style="margin-left: 80px">
        ARA Kitchen is a cooking blog where you can see all kinds of recipes and 
        interact with other users either sharing your own recipes or commenting and 
        rating recipes from other users.<br />
        Recipes are visible to everyone, but to upload your own recipe you need to be 
        registered. You only have to click on &quot;Log In&quot; and then in the &quot;Registrer&quot; field, and 
        after completing a few simple steps you will have your own account on our blog.<br />
        <br />
        In the &quot;Books&quot; tab we offer you the opportunity to buy the official books of the 
        blog with all the recipes. The payment can be by credit card or through Paypal.<br />
        In addition, if you have a doubt, you want to make a suggestion or anything 
        else, you can contact us through the &quot;Contact&quot; tab, where our team will respond 
        to your requests as soon as possible.<br />
        <br />
        Finally, you can read about who we are in the &quot;About us&quot; tab. We hope you find 
        what you need in this cooking blog. Greetings from all the team of ARA Kitchen.<br />
        <br />
    </p>

        <p style="font-size: x-large; text-align: center">
            <asp:Image ID="Image3" runat="server" 
            ImageUrl="~/Content/ImagesFondo/recipe2.png" /></p>
    <p style="text-align: center">
          <script language=javascript type="text/javascript">

              mydate = new Date();
              myday = mydate.getDay();
              mymonth = mydate.getMonth();
              myweekday = mydate.getDate();
              weekday = myweekday;

              if (myday == 0)
                  day = " Sunday, "

              else if (myday == 1)
                  day = " Monday, "

              else if (myday == 2)
                  day = " Tuesday, "

              else if (myday == 3)
                  day = " Wednesday, "

              else if (myday == 4)
                  day = " Thursday, "

              else if (myday == 5)
                  day = " Friday, "

              else if (myday == 6)
                  day = " Saturday, "

              if (mymonth == 0)
                  month = "January "

              else if (mymonth == 1)
                  month = "February "

              else if (mymonth == 2)
                  month = "March "

              else if (mymonth == 3)
                  month = "April "

              else if (mymonth == 4)
                  month = "May "

              else if (mymonth == 5)
                  month = "Juny "

              else if (mymonth == 6)
                  month = "July "

              else if (mymonth == 7)
                  month = "August "

              else if (mymonth == 8)
                  month = "September "

              else if (mymonth == 9)
                  month = "October "

              else if (mymonth == 10)
                  month = "November "

              else if (mymonth == 11)
                  month = "December "

              document.write("<font face=tahoma, size=2>" + day);
              document.write(myweekday + " " + month + " 2014" + "<\/font>");
</script>
         &nbsp;
         
     </p>
     <div style="text-align: center; font-size: large">
         <span style="color: #CC0000">B</span>K<span style="color: #003300">R</span> (<span 
             style="color: #CC0000">Bacon</span>, Kale, 
         <span style="color: #003300">Ricotta</span>) Sandwich
    </div>
       

           <p style="margin-left: 80px">

               <em><strong>Ingredients</strong></em><br /> <br />

        2 sandwiches&nbsp; <br style="margin-left: 40px" />
    
        2 tablespoon olive oil <br style="margin-left: 40px" />
        2 garlic cloves, sliced <br style="margin-left: 40px" />
        1 bunch kale, rinsed and cut in 1-inch ribbons <br style="margin-left: 40px" />
        pinch chile flakes <br style="margin-left: 40px" />
        1 tablespoon capers, drained <br style="margin-left: 40px" />
        salt <br style="margin-left: 40px" />
        lemon <br style="margin-left: 40px" />
        1/3 cup ricotta <br style="margin-left: 40px" />
        4 strips bacon, cooked until very crisp <br style="margin-left: 40px" />
        4 slices bread, toasted (with butter in a hot skillet is how I like to to it)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /> <br />

               <em><strong>Steps</strong></em><br /> <br />

        Add the oil to a hot skillet. When the oil is shimmering add the garlic and 
        saute until fragrant, about 30 second over medium-high heat. Add all of the kale 
        along with a pinch of salt and chile flakes (or sliced fresh chile if you have 
        it). Saute until wilted and soft, about 3 minutes. <br /> <br />

        Transfer the kale to a bowl then stir in the capers. Taste and add more salt if 
        needed and a squeeze of fresh lemon juice if you happen to have it on hand.
        At this point I toast the bread in the still-hot skillet with a bit of butter. 
        Try rubbing the bread with a garlic clove for another boost of flavor. <br /> <br />

        Divide the ricotta between the four slices of bread. Add the kale to two halves, 
        then two strips of bacon on each sandwich and finally, top the with the other 
        pieces of bread with ricotta. <br /> <br />

        Slice in half then enjoy.

       </p>
    <p style="margin-left: 80px">

        <asp:Image ID="Image1" runat="server" 
            ImageUrl="~/Content/ImagesFondo/Sandwich.jpeg" />

       </p>

       <p>
           &nbsp;</p>

</asp:Content>
