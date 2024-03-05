using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIICraftDemoPages
{
    public class Game
    {
        public Person Player = new Person()
        {
            Inventory = new List<Item>
        {
            new Item() {ItemName="Chocolate", ItemAmount = 3, ItemValue = 9.99, ItemAmountType = "pound(s)"},
            new Item() {ItemName="Water", ItemAmount = 10, ItemValue = .10, ItemAmountType = "cup(s)"}
             }
        };
        public Person Vendor = new Person()
        {
            Inventory = new List<Item>
        {
            new Item() {ItemName="Chocolate", ItemAmount = 1, ItemAmountType = "pound(s)", ItemValue = 9.99}

             }
        };


        public List<Recipe> Recipes = new List<Recipe>();

        public Game() 
        {
            Recipes.Add(
                   new Recipe()
                   {
                       RecipeName = "Powdered Sugar Icing",
                       RecipeDescription = "Tasty icing that can be used with many recipes.",
                       RecipeValue = 2.57,
                       RecipeAmount = 2,
                       RecipeAmountType = "pound(s)",
        RecipeRequirements = new List<Item>()
                       {
                        new Item(){ItemName = "Powdered Sugar", ItemAmount = 1, ItemAmountType="cup", ItemValue = 1.95 },
                        new Item(){ItemName = "Vanilla Extract", ItemAmount = 1.5, ItemAmountType = "tsp", ItemValue = 2.67 },
                        new Item(){ItemName = "Milk", ItemAmount = 2, ItemAmountType="tbsp", ItemValue = 4.25 }
                       },
                   }
                   );
        }

        public string GetRecipeList()
        {
            int number = 1;
            string output = "Recipes:\n\n";
            foreach (Recipe recipe in Recipes)
            {
                output += $"  {number}. {recipe.GetRecipeDescription()}";
                number++;
            }
            return output;
        }
    }
}
