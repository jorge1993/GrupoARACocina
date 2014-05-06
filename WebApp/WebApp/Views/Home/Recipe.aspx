<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<script runat="server">
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Recipe
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>Recipe</h2>
    <hr />
    
        <h3>Raspberry Cake</h3>
    <p><table class="table2">
            <tr>
                <td>
        <img alt="" src="../../Content/ImagesRecipes/1.jpg" class="table2" /></td>
                <td class="textIngredients">
                    Ingredients:<br />
                    1 cheese terrine (Philadelphia)
                    <br />
                    1 can of condensed milk
                    <br />
                    1 liter of cream (to ride)
                    <br />
                    2 packets of gelatin powder
                    <br />
                    1 jar of jam (strawberry or raspberry)
                    <br />
                    10 crackers maria 150 gr of butter</td>
            </tr>
        </table>
    </p>
    <p>
        Auth: 
        <asp:HyperLink ID="HyperLink1" runat="server">Juanito Valdemoros</asp:HyperLink>
        <br />
        Category: <asp:HyperLink ID="HyperLink2" runat="server">Dessert</asp:HyperLink>
        <br />
        Preparation time: 1:30 hours
    </p>
    <p>
        
        Preparation:
        
    </p>
    <p>
        
        Step 1: In a bowl mix the high liter of cream terrine with cheese and condensed 
        milk . The amount of cheese and the milk will get to our taste ( if you want 
        more sweetness add more condensed milk and add more cheese if you want more than 
        this ) . Grind all with mixer until well blended
        
    </p>
    <p>
        
        Step 2: Furthermore prepare gelatin as put in the instructions ( the gelatin has 
        to be neutral . I use royal brand ) . When we booked and let cool .
        
    </p>
    <p>
        
        Step 3: Now prepare the coulis . This is made by putting a whole jar of 
        marmalade to fire in a saucepan with half a glass of water. When starting to 
        boil, retired and snuck to remove the pips ( the coulis is seedless jam ) .
        
    </p>
    <p>
        
        Step 4: Now prepare the base. Crush the cookies into a powder and mix with the 
        melted butter in the microwave. We will obtain a paste which cover the base of 
        the mold where we are going to make the cake . I like a touch of oven ( broil ) 
        for cookie crisp. A mixture of the cheese milk with added gelatin tibia . Mix 
        well and pour ( we pour the mixture slowly , over a spoon so you do not break 
        the base) before the mixture prepared .
        
    </p>
    <p>
        
        Step 5: Let cool in the fridge for about 4 hours and desamoldamos . Just then we 
        add the coulis before we made</p>
    <p>
        
        Difficulty: Hard</p>
    <p>
        
        Origin:<br />
        <img alt="" src="../../Content/fake1.jpg" /></p>
        <hr />
    <p><h3>Comments</h3></p>
    <table class="table2">
        <tr><td>

            Write your own comment:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="text-box multi-line" 
                TextMode="MultiLine" Width="458px"></asp:TextBox>

        </td></tr>
    </table>

    <br />
    <table class="table2">
        <tr>
            <td><%= Html.ActionLink("Antonia Machine", "Users", "Account")%><br />
            Really a good recipe. It was wonderfull and really tasty. Thanks for the upload wey.
            </td></tr>
        <tr><td><%= Html.ActionLink("Norverto Machine", "Users", "Account")%><br />
            Omg. You have copied it from another page.
        </td></tr>
    </table>

    </form>

</asp:Content>
