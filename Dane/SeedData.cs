using BlazingPizza.Model;

namespace BlazingPizza.Dane;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                Name = "Pizza Serowa",
                Description = "Serowa i jednocześnie pyszna. Dlaczego miałbyś jej nie chcieć zjeść?",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                Id = 2,
                Name = "Bekonowa",
                Description = "Zawiera KAŻDY rodzaj bekonu",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                Id = 3,
                Name = "Klasyczna Pepperoni",
                Description = "To jest pizza z którą dorastałeś, PIEKIELNIE gorąca!",
                BasePrice = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                Id = 4,
                Name = "Kurczk z Bawołem",
                Description = "Pikantny kurczak, ostry sos i bleu ser, gwarantowana rozgrzewka podniebienia",
                BasePrice = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                Id = 5,
                Name = "Miłośnik grzybów",
                Description = "Zawiera grzyby. Czy to nie oczywiste?",
                BasePrice = 11.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                Id = 7,
                Name = "Warzywna Rozkosz",
                Description = "Jest jak sałka, ale na pizzy",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Tradycyjna pizza Italiańska z pomidorami i bazylią.",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
            },
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}