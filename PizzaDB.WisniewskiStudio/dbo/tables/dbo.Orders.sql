/****** Object: Table [dbo].[Orders] Script Date: 2024-09-15 16:22:16 ******/


CREATE TABLE [dbo].[Orders] (
    [OrderId]           INT IDENTITY (1, 1) NOT NULL,
    [UserId]            NVARCHAR (MAX) NULL,
    [CreatedTime]       DATETIME2 (7)  NOT NULL,
    [DeliveryAddressId] INT            NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Orders_Address_DeliveryAddressId] FOREIGN KEY ([DeliveryAddressId]) REFERENCES [dbo].[Address] ([Id])
);

GO
CREATE NONCLUSTERED INDEX [IX_Orders_DeliveryAddressId]
    ON [dbo].[Orders]([DeliveryAddressId] ASC);
