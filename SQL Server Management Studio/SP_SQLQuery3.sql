CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerName NVARCHAR(100),
    TotalAmount DECIMAL(10, 2) NOT NULL
);

CREATE TABLE DiscountCodes (
    Code NVARCHAR(50) PRIMARY KEY,
    DiscountAmount DECIMAL(10, 2) NOT NULL,
    ExpiryDate DATE NOT NULL
);

INSERT INTO Orders (OrderID, CustomerName, TotalAmount) VALUES
(1, 'Alice Johnson', 500.00),
(2, 'Bob Smith', 300.00);

INSERT INTO DiscountCodes (Code, DiscountAmount, ExpiryDate) VALUES
('FLAT50OFF', 50.00, '2025-12-31'),
('FLAT100OFF', 100.00, '2025-05-15');

select * from Orders;
select * from DiscountCodes;

GO
CREATE PROC APPLYDISCOUNT
@OrderID INT,
@DiscountCode NVARCHAR(50)

AS
BEGIN
BEGIN TRY

IF NOT EXISTS(SELECT 1 FROM Orders WHERE OrderID=@OrderID)
THROW 50009 ,'Order does not exists ',1;


IF NOT EXISTS(SELECT 1 FROM DiscountCodes WHERE Code=@DiscountCode AND ExpiryDate>GETDATE())
THROW 50010 ,'INVALID DISCOUNT CODE ',1;

DECLARE @OrderTotal DECIMAL(10, 2),@DiscountValue DECIMAL(10, 2)

SELECT @OrderTotal = TotalAmount FROM Orders WHERE OrderID=@OrderID;

SELECT @DiscountValue= DiscountAmount FROM DiscountCodes WHERE Code=@DiscountCode;

IF @DiscountValue>@OrderTotal
THROW 50011 ,'Discount Value is Greater than Order Total Amount',1;

UPDATE Orders
SET TotalAmount =@OrderTotal-@DiscountValue
where OrderID=@OrderID;

SELECT @OrderTotal = TotalAmount FROM Orders WHERE OrderID=@OrderID;

PRINT 'Discount Code Applied Successfully . Total Order Cost is ' + cast(@OrderTotal as NVARCHAR(40));
END TRY
BEGIN CATCH
SELECT ERROR_LINE(),ERROR_MESSAGE() AS MESSAGE
END CATCH
END

EXEC APPLYDISCOUNT 2,'FLAT50OFF';

GO








