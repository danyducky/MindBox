CREATE PROCEDURE [dbo].[ProductsCategories_Group]
AS

    SELECT p.[Name] as ProductName, c.[Name] as CategoryName FROM [dbo].[Products] p
    LEFT JOIN [dbo].ProductsCategories pd ON p.Id = pd.ProductId
    LEFT JOIN [dbo].Categories c ON c.Id = pd.CategoryId

GO;
