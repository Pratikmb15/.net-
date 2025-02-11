create database SP_DB;
use SP_DB;

CREATE TABLE Emp(
Id int identity(1,1) ,
Name varchar(50),
Age int NOT NULL,
Gender varchar(20) default 'Male',
Salary Money default 20000,
Department varchar(30) default 'IT'
)

INSERT INTO emp (Name,Age,Gender,Salary,Department) values ('Aryan',32,'Male',49000,'Sales'),('Ria',28,'Female',70000,'IT')

INSERT INTO emp (Name,Age,Gender,Salary) values ('Abhishek',25,'Male',55000),('Shreya',21,'Female',45000),('Pratik',22,'Male',52000)

go

create procedure sp_GetEmp
as
begin
select*from Emp;
end

exec sp_GetEmp;

go

create proc sp_updateEmp
@name varchar(50),
@salary money
as 
begin
update Emp set Salary=@salary where Name=@name;
end

exec sp_updateEmp 'Pratik',55000;
go
create procedure sp_DelEmp
@name varchar(50)
as
begin
delete from Emp where name = @name;
end

execute sp_DelEmp 'Abhishek';


create table Accounts(
AccountId int,
Custumer_name varchar(50),
Balance DECIMAL(10, 2)
)
drop table Accounts

insert into Accounts(AccountId,Custumer_name,Balance) values  (1, 'John Doe', 5000.00),(2, 'Steve Smith', 2000.00);

select*from Accounts;
GO
CREATE PROCEDURE Withdraw
    @AccountId INT,
    @Amount DECIMAL(10, 2)
AS
BEGIN
    BEGIN TRY
        DECLARE @Balance DECIMAL(10, 2);

        -- Check if account exists
        IF NOT EXISTS (SELECT 1 FROM Accounts WHERE AccountId = @AccountId)
        BEGIN
            THROW 50005, 'Account Not Found', 1;
        END

        -- Fetch balance
        SELECT @Balance = Balance FROM Accounts WHERE AccountId = @AccountId;

        -- Check for sufficient balance
        IF @Balance < @Amount
        BEGIN
            THROW 50006, 'Insufficient Balance', 1;
        END

        -- Deduct the amount
        UPDATE Accounts
        SET Balance = Balance - @Amount
        WHERE AccountId = @AccountId;

        -- Get the updated balance
        SELECT @Balance = Balance FROM Accounts WHERE AccountId = @AccountId;

        PRINT 'Withdrawal successful. Remaining Balance: ' + CAST(@Balance AS NVARCHAR(50));
    END TRY
    BEGIN CATCH
          SELECT ERROR_LINE() AS Line, ERROR_MESSAGE() AS Message;
    END CATCH3. 
END;

exec Withdraw @AccountId=1,@Amount=1000;
GO





