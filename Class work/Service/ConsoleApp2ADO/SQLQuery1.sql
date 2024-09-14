CREATE PROCEDURE SP_PRODUCT
@ProductName nvarchar(50)
AS
BEGIN
SELECT * FROM Product where name like @ProductName +'%'
END