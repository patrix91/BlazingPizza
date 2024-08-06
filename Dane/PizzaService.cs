namespace BlazingPizza.Dane;

public class PizzaService
{

    public Task<Pizza[]> GetPizzasAsync()
    {
        Pizza[] pizzas;
        
        pizzas = (new Pizza[]
        {
            new Pizza { Name = "Marharita", Vegetarian = false, Vegan = false, Price =  11.99M, Description = ""},
            new Pizza { Name = "Hawaiian", Vegetarian = false, Vegan = false, Price =  12.75M, Description = ""},
            new Pizza { Name = "Fiorentina", Vegetarian = false, Vegan = false, Price =  11.5M, Description = ""},
            new Pizza { Name = "Italiano", Vegetarian = false, Vegan = false, Price =  9.99M, Description = ""},
            new Pizza { Name = "Pepperoni", Vegetarian = false, Vegan = false, Price =  11.99M, Description = ""}
        });

        return Task.FromResult(pizzas);
    }
}