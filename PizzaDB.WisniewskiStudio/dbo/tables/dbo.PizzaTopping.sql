/****** Object: Table [dbo].[PizzaTopping] Script Date: 2024-09-15 16:22:04 ******/

CREATE TABLE [dbo].[PizzaTopping] (
    [ToppingId] INT NOT NULL,
    [PizzaId]   INT NOT NULL,
    CONSTRAINT [PK_PizzaTopping] PRIMARY KEY CLUSTERED ([PizzaId] ASC, [ToppingId] ASC),
    CONSTRAINT [FK_PizzaTopping_Pizzas_PizzaId] FOREIGN KEY ([PizzaId]) REFERENCES [dbo].[Pizzas] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PizzaTopping_Toppings_ToppingId] FOREIGN KEY ([ToppingId]) REFERENCES [dbo].[Toppings] ([Id]) ON DELETE CASCADE
);

GO
CREATE NONCLUSTERED INDEX [IX_PizzaTopping_ToppingId]
    ON [dbo].[PizzaTopping]([ToppingId] ASC);