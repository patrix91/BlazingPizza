/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists(SELECT 1 FROM dbo.Specials)
begin
SET IDENTITY_INSERT [dbo].[Specials] ON

    INSERT INTO [dbo].[Specials] ([Id], [Name], [BasePrice], [Description], [ImageUrl]) 
        VALUES (1, 'Pizza Serowa', 39.99, 'Serowa i jednocześnie pyszna. Dlaczego miałbyś jej nie chcieć zjeść?',  'img/pizzas/cheese.jpg')
        ,(2, 'Bekonowa', 41.99,'Zawiera KAŻDY rodzaj bekonu', 'img/pizzas/bacon.jpg')
        ,(3, 'Klasyczna Pepperoni', 40.50, 'To jest pizza z którą dorastałeś, PIEKIELNIE gorąca!', 'img/pizzas/pepperoni.jpg')
        ,(4, 'Kurczak z Bawołem', 42.75, 'Pikantny kurczak, ostry sos i bleu ser, gwarantowana rozgrzewka podniebienia', 'img/pizzas/meaty.jpg')
        ,(5, 'Miłośnik grzybów', 41.00, 'Zawiera grzyby. Czy to nie oczywiste?', 'img/pizzas/mushroom.jpg')
        ,(6, 'Warzywna Rozkosz', 41.50, 'Jest jak sałka, ale na pizzy','img/pizzas/salad.jpg')
        ,(7, 'Margherita', 39.99, 'Tradycyjna pizza Italiańska z pomidorami i bazylią.', 'img/pizzas/margherita.jpg')
        
end