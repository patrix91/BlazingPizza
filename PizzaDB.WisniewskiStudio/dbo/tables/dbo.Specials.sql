/****** Object: Table [dbo].[Specials] Script Date: 2024-09-15 16:19:56 ******/

CREATE TABLE [dbo].[Specials] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX)  NULL,
    [BasePrice]   DECIMAL (18, 2) NOT NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [ImageUrl]    NVARCHAR (MAX)  NULL,

    CONSTRAINT [PK_Specials] PRIMARY KEY CLUSTERED ([Id] ASC),
);