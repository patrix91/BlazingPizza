﻿using Pizza.WisniewskiStudio.Model;

namespace Pizza.WisniewskiStudio.Usługi;


    public class OrderState
    {
        public bool ShowingConfigureDialog { get; private set; }
        public Model.Pizza ConfiguringPizza { get; private set; }
        public Order Order { get; private set; } = new Order();

        public void ShowConfigurePizzaDialog(PizzaSpecial special)
        {
            ConfiguringPizza = new Model.Pizza()
            {
                Special = special,
                SpecialId = special.Id,
                Size = Model.Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>(),
            };

            ShowingConfigureDialog = true;
        }

        public void CancelConfigurePizzaDialog()
        {
            ConfiguringPizza = null;

            ShowingConfigureDialog = false;
        }

        public void ConfirmConfigurePizzaDialog()
        {
            Order.Pizzas.Add(ConfiguringPizza);
            ConfiguringPizza = null;

            ShowingConfigureDialog = false;
        }

        /// <summary>
        /// Usuń konfigurowalną pizze z zamówienia.
        /// </summary>
        /// <param name="pizza"></param>
        public void RemoveConfiguredPizza(Model.Pizza pizza)
        {
            Order.Pizzas.Remove(pizza);
        }
        public void ResetOrder()
        {
            Order = new Order();
        }
    }

