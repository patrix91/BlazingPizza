/****** Object: Table [dbo].[Pizzas] Script Date: 2024-09-15 16:18:33 ******/

CREATE TABLE [dbo].[Pizzas] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [OrderId]   INT NOT NULL,
    [SpecialId] INT NOT NULL,
    [Size]      INT NOT NULL, 
    CONSTRAINT [PK_Pizzas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pizzas_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders]([OrderId]) On delete cascade, 
    CONSTRAINT [FK_Pizzas_Specials_SpecialId] FOREIGN KEY ([SpecialId]) REFERENCES [Specials]([Id]) on delete cascade

);
GO
CREATE NONCLUSTERED INDEX [IX_Pizzas_OrderId] ON [dbo].[Pizzas] ([OrderId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Pizzas_SpecialId]
    ON [dbo].[Pizzas]([SpecialId] ASC);
