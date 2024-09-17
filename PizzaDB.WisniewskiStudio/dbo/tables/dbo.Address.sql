/****** Object: Table [dbo].[Address] Script Date: 2024-09-15 16:22:24 ******/

CREATE TABLE [dbo].[Address] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [Line1]      NVARCHAR (MAX) NULL,
    [Line2]      NVARCHAR (MAX) NULL,
    [City]       NVARCHAR (MAX) NULL,
    [Region]     NVARCHAR (MAX) NULL,
    [PostalCode] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([Id] ASC)
);


