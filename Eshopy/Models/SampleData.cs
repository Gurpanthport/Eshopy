using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Eshopy.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
         protected override void Seed(RestaurantContext context)
        {
            var types = new List<FoodTypeModels>
            {
                new FoodTypeModels { Name = "Appetizer", Description="Something to get your Appetite up", imageUrl="/Content/appetizer.jpg"},
                new FoodTypeModels { Name = "Main Course", Description="The main Course", imageUrl="/Content/mainCourse.jpg"},
                new FoodTypeModels { Name = "Desserts", Description="Something sweet that you have at the end.", imageUrl="/Content/Dessert.jpg" }
            };

            new List<FoodItemModels>
            {
                new FoodItemModels {Name = "Bruschetta with Tomato and Basil",description="Home made Bruschetta with a special house made Tomato and Basil Sauce, and spices from the east", Price=8.99M, FoodType = types.Single(g => g.Name == "Appetizer"), FoodArtUrl = "/Content/Images/BrushettaWithTomatoAndBasil.png" },
                new FoodItemModels {Name = "Spanish Tortilla", description="Thinly fried sliced of potatoes  mixed with vegetables, onion and multiple spices soaked in a stirred egg and cut into small cubes", Price=10.25M, FoodType = types.Single(g => g.Name == "Appetizer"), FoodArtUrl = "/Content/Images/small-bites-spanish-tortilla.jpg" },
                new FoodItemModels {Name = "Fried Pork Dumplings", description = "Pork, Bacon, cabbage and multiple spices wrapped up in a Dumpling form, served with ponzu dipping sauce", Price=10.99M, FoodType= types.Single(g => g.Name == "Appetizer"), FoodArtUrl = "/Content/Images/Fried-Pork-Dumplings.jpg" },
                new FoodItemModels {Name = "Skillet Chicken and Ravioli", description ="Seasoned chicken  mixed with classic ravioli, mushrooms, tomatoes, and Parmesan all stir fried in a skillet with in house seasoning", Price=23.55M, FoodType= types.Single(g => g.Name == "Main Course"), FoodArtUrl="/Content/Images/Skillet-Ravioli.jpg" },
                new FoodItemModels {Name = "Tuscan Lemon Chicken", description="A Full Chicken house marinated fire grilled served with grilled lemons and your choice of any house made sides. excluding some of the exclusives marked exl.", Price=27.24M, FoodType= types.Single(g => g.Name == "Main Course"), FoodArtUrl="/Content/Images/Tuscan-Lemon-Chicken.png" },
                new FoodItemModels {Name = "Chicken Parmesan", description="A Full Chicken breast marinated with a house made tomato Parmesan sauce topped with a classic mozzarella cheese or your choice of cheese and your choice of any house made sides. excluding some of the exclusives marked exl.", Price=24.21M, FoodType= types.Single(g => g.Name == "Main Course"), FoodArtUrl="/Content/Images/chicken_parmesan.jpg" },

                new FoodItemModels {Name = "Ice cream", description="Various flavours of ice cream", Price=3.99M, FoodType = types.Single(g => g.Name == "Desserts"), FoodArtUrl = "/Content/Images/small-bites-spanish-tortilla.jpg" }

            }.ForEach(a => context.FoodItems.Add(a));
    }
    }
}
//DropCreateDatabaseIfModelChanges, change it back to this when we are done adding sample data
//DropCreateDatabaseAlways use this if we add more sample data