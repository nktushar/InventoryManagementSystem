CREATE TABLE [dbo].[SellTbl]
(
	[Sell_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Sell_Date] VARCHAR(50) NOT NULL, 
    [FoodItem] VARCHAR(50) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [SellAmount] VARCHAR(50) NOT NULL
)
