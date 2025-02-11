create table Products(
ProductID INT PRIMARY KEY,
Product_name varchar(30),
Quantity INT
)
insert into Products(ProductID,Product_name,Quantity) values (102,'Brown Bread',15),(105,'Bisciuts',22),(155,' Cheese Cubes',34),(214,'Potato Chips',24);

select * from Products;

GO
CREATE PROCEDURE UPDATESTOCK
@ProductID INT,@QuantityToBeReduce INT
AS
BEGIN 
     BEGIN TRY
	 IF NOT EXISTS(SELECT 1 FROM Products WHERE ProductID=@ProductID)
	 
	 THROW 50007,'Product Does not Exist',1;
	 
	 DECLARE @CurrentStock int;
	 select @CurrentStock= quantity from Products where ProductID=@ProductID;
	 begin
	 if @CurrentStock<@QuantityToBeReduce
	     
		 THROW 50008,'Insufficient Stock',1;
		 
     
	 update Products 
	 set Quantity=Quantity-@QuantityToBeReduce
	 where ProductID =@ProductID;

	 select @CurrentStock= quantity from Products where ProductID=@ProductID;
	 
	 PRINT 'Stock Updated Successfully . Remaining Stock is :'+ cast(@CurrentStock as NVARCHAR(50));

	 end
	 END TRY
	 BEGIN CATCH
	  SELECT ERROR_LINE(),ERROR_MESSAGE() AS MESSAGE;
	 END CATCH
END

EXEC UPDATESTOCK 105,18;

GO