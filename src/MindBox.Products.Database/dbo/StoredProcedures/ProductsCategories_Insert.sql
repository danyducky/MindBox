CREATE PROCEDURE [dbo].[Categories_Insert]
AS
	INSERT INTO [dbo].[Categories]
        ([Id], [Name])
    VALUES
        (1, 'Household chemicals'),
        (2, 'Cars'),
        (3, 'Alcohol'),
        (4, 'Food')

    INSERT INTO [dbo].[Products]
        ([Id], [Name])
    VALUES
        (1, 'Dishwashing liquid'),
        (2, 'Chevrolet Camaro'),
        (3, 'Conti Serristori'),
        (4, 'Candies'),
        (5, 'iPhone')

    INSERT INTO [dbo].[ProductsCategories]
        ([CategoryId], [ProductId])
    VALUES
        (1, 1),
        (2, 2),
        (3, 3),
        (4, 4)
GO;
