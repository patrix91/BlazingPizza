﻿namespace Pizza.WisniewskiStudio.Model;

/// <summary>
/// Topy które mozna dodać do pizzy
/// </summary>
public class PizzaTopping
{
    public Topping Topping { get; set; }

    public int ToppingId { get; set; }
    
    public int PizzaId { get; set; }
}
