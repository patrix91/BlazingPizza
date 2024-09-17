/****** Object: Table [dbo].[Toppings] Script Date: 2024-09-15 16:20:48 ******/

CREATE TABLE [dbo].[Toppings] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (MAX)  NULL,
    [Price] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Toppings] PRIMARY KEY CLUSTERED ([Id] ASC)
);