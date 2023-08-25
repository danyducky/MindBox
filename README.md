# MindBox

`MindBox.Geometry.Console` => Simple console app to make a smoke tests during developing.

`src/MindBox.Geometry.Domain` => Class library that contains all geometry entities.

`tests/MindBox.Geometry.Tests` => Contains domain class library unit tests.

`src/MindBox.Products.Database` => Contains database tables & stored procedures.

Run an application with predefined connection string in debug settings.

Call `EXEC [dbo].[ProductsCategories_Insert]` stored procedure to fill tables data.

Call `EXEC [dbo].[ProductsCategories_Group]` to watch an output. 

Procedure [dbo].[ProductsCategories_Group] contains SQL query which meets the requirements of the task.
