using Pizza.WisniewskiStudio.Model;

namespace Pizza.WisniewskiStudio.Dane;

public class SeedData
{
    public static async Task SeedAsync(PizzaStoreContext context)
    {
        if (!context.Specials.Any())
        {
            var specials = new PizzaSpecial[]
            {
                new PizzaSpecial()
                {
                    Name = "Pizza Serowa",
                    BasePrice = 39.99m,
                    Description = "Serowa i jednocześnie pyszna. Dlaczego miałbyś jej nie chcieć zjeść?",
                    ImageUrl = "img/pizzas/cheese.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Bekonowa",
                    BasePrice = 41.99m,
                    Description = "Zawiera KAŻDY rodzaj bekonu",
                    ImageUrl = "img/pizzas/bacon.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Klasyczna Pepperoni",
                    BasePrice = 40.50m,
                    Description = "To jest pizza z którą dorastałeś, PIEKIELNIE gorąca!",
                    ImageUrl = "img/pizzas/pepperoni.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Kurczak z Bawołem",
                    BasePrice = 42.75m,
                    Description = "Pikantny kurczak, ostry sos i bleu ser, gwarantowana rozgrzewka podniebienia",
                    ImageUrl = "img/pizzas/meaty.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Miłośnik grzybów",
                    BasePrice = 41.00m,
                    Description = "Zawiera grzyby. Czy to nie oczywiste?",
                    ImageUrl = "img/pizzas/mushroom.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Warzywna Rozkosz",
                    BasePrice = 41.50m,
                    Description = "Jest jak sałka, ale na pizzy",
                    ImageUrl = "img/pizzas/salad.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Margherita",
                    BasePrice = 39.99m,
                    Description = "Tradycyjna pizza Italiańska z pomidorami i bazylią.",
                    ImageUrl = "img/pizzas/margherita.jpg",
                },
            };

            //if (context.ChangeTracker.HasChanges())
            //{
            //    await context.SaveChangesAsync();
            //}
            context.Specials.AddRange(specials);
            context.SaveChanges();
        }
    }
}