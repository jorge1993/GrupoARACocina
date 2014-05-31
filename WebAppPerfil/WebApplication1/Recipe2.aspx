<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recipe2.aspx.cs" Inherits="WebApplication1.Recipe2" %>


<script runat="server">
</script>
<asp:Content ID="Content3" ContentPlaceHolderID="TitleContent" runat="server">
	Recipe
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

    

    <h2>Recipe</h2>
    <hr />
    
        <h3>Cheese Cake</h3>
    <p><table class="table2">
            <tr>
                <td>
        <img alt="" src="../../Content/ImagesRecipes/2.jpg" class="table2" /></td>
                <td class="textIngredients">
                    Ingredients:<br />
                    200g digestive biscuits
                    <br />
                    75g butter, melted
                    <br />
                    600g full-fat soft cheese
                    <br />
                    250g golden caster sugar
                    <br />
                    150g tub natural yogurt
                    <br />
                    3 medium eggs
                    <br />
                    finely grated zest 2 lemons, juice of 1
                    <br />
                    50g plain flour
                    <br />
                    200g raspberries
                    <br />
                    icing sugar, to decorate
                  
                    </td>
            </tr>
        </table>
    </p>
    <p>
        Auth: 
        <asp:HyperLink ID="HyperLink1" runat="server">Barney Desmazery</asp:HyperLink>
        <br />
        Category: <asp:HyperLink ID="HyperLink2" runat="server">Dessert</asp:HyperLink>
        <br />
        Preparation time: 1 hr, 45 mins
    </p>
    <p>
        
        Preparation:
        
    </p>
    <p>
        
        Step 1: Heat oven to 120C/100C fan/gas and line the base of a 20cm round springform tin with greaseproof paper. 
        Crush the biscuits in a food processor or in a food bag using a rolling pin. Tip into a bowl with the melted 
        butter and mix well. Push the biscuits into an even layer into the base of the cake tin and chill until needed.
        
    </p>
    <p>
        
        Step 2: In a separate bowl use an electric whisk to beat the soft cheese with the sugar.
        Next beat in the yoghurt then the eggs one at a time. Finally beat in the lemon zest, lemon juice and flour.
        Fold through two thirds of the raspberries crushing them very slightly so they start to bleed into the mix then
        tip the mix on top of the biscuit base and smooth over the top. Bake for 45 mins then turn off the oven, leave 
        the cake inside for another hour then cool at room temperature. Chill overnight. To serve, remove from tin, scatter 
        with remaining raspberries and dust heavily with icing sugar.
        
    </p>
    
    
    <p>
        
        Difficulty: Easy</p>
    <p>
        
        Origin:</p>
    <p>
        
        <br />
          <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6463011.037117101!2d-97.83667945848693!3d37.72514409507355!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x87a31771717c016b%3A0x68c2b4a94b3e095f!2sKansas!5e0!3m2!1ses!2sus!4v1400264777275" width="600" height="450" frameborder="0" style="border:0"></iframe></p>
    <p><h3>Comments</h3></p>
    <table class="table2">
        <tr>
            <td><br />
            I really like it. My mother used to prepare it to me.
            </td></tr>
        <tr><td><br />
           It is so hard to prepare, but I'll try.
        </td></tr>
    </table>

   

</asp:Content>
