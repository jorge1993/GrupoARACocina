<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recipe3.aspx.cs" Inherits="WebApplication1.Recipe3" %>

<script runat="server">
</script>
<asp:Content ID="Content3" ContentPlaceHolderID="TitleContent" runat="server">
	Recipe
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

    

    <h2>Recipe</h2>
    <hr />
    
        <h3>Strawberry cake</h3>
   <p><table class="table2">
            <tr>
                <td>
        <img alt="" src="../../Content/ImagesRecipes/3.jpg" class="table2" /></td>
                <td class="textIngredients">
                    Ingredients:<br />
                    200g biscuits
                    <br />
                    100g melted margarine
                    <br />
                    500g tub ricotta cheese
                    <br />
                    grated zest of 2 large lemons and 3 tbsp juice
                    <br />
                    50g fruit sugar
                    <br />
                    3 large egg yolks
                    <br />
                    2 tbsp semolina
                    <br />
                    225g strawberries
                    <br />
                    3 tbsp reduced-sugar strawberry jam
                    </td>
            </tr>
        </table>
    </p>
    <p>
    <a href="Content/Pdf/StrawberryCake.pdf" target="_blank" download="Strawberry" title="Strawberry">
    <img border="0" src="Content/Pdf/Pdf.jpg" alt="Pdf"></a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
   
    <input type=button value=Imprimir onclick="print()" />
    <br /><br />
        Auth: 
        <asp:HyperLink ID="HyperLink1" runat="server">Edgar Colston</asp:HyperLink>
        <br />
        Category: <asp:HyperLink ID="HyperLink2" runat="server">Dessert</asp:HyperLink>
        <br />
        Preparation time: 1 hour-1 hour 20 minutes
    </p>
    <p>
        
        Preparation:
        
    </p>
    <p>
        
        Step 1: Preheat the oven to 180C/gas 4/fan 160C. Blitz the biscuits in a food processor until finely crushed. 
        Add the melted margarine and whiz for a minute. Base line a 20cm spring form tin with non-stick baking parchment 
        and press the mixture into the base.
        
    </p>
    <p>
        
        Step 2: Wipe the processor bowl and blades, then add the ricotta, lemon zest and juice, fruit sugar, egg yolks and semolina 
        and whizz for 1-2 minutes or until thoroughly mixed.
        
    </p>
    <p>
        
        Step 3: Pour the mixture into the prepared tin and bake for 35- 45 minutes until firm to the touch and the sides 
        are just shrinking from the tin. Turn the oven off and allow the cheesecake to cool in the oven with the door open for 1 hour.
    </p>
    <p>
        
        Step 4: While the cake cools, hull and halve the strawberries, quartering any larger ones. Melt the jam with 3 tbsp water
         over a medium heat, stirring until bubbling and runny. Sieve the jam into a bowl and toss the strawberries in the jam.
        
    </p>
    <p>
        
        Step 5: To serve, loosen the sides of the cheesecake with a knife, remove from the tin and slide on to a serving plate. 
        (The cheesecake may now be frozen.) Top with strawberries.</p>
    <p>
        
        Difficulty: Hard</p>
    <p>
        
        Origin:</p>
    <p>
        
        <br />
          <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6463011.037117101!2d-97.83667945848693!3d37.72514409507355!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x87a31771717c016b%3A0x68c2b4a94b3e095f!2sKansas!5e0!3m2!1ses!2sus!4v1400264777275" width="600" height="450" frameborder="0" style="border:0"></iframe></p>
    <p><h3>Comments</h3></p>
    <table class="table2">
        <tr>
            <td><br />
            Very tasty!
            </td></tr>
        
    </table>

   

</asp:Content>
