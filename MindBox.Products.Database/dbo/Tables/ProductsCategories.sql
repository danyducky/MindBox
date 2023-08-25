CREATE TABLE [dbo].[ProductsCategories]
(
	[ProductId] INT NOT NULL, 
    [CategoryId] INT NOT NULL,
    FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id]),
)
