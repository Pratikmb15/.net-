-----------DML TRIGGERS------------------------------------------------------------------------------
----INSERT TRIGGER-------------
CREATE TRIGGER TriggerAfterInsert on Employee
AFTER INSERT 
AS
DECLARE @Emp_DOB VARCHAR(20);
DECLARE @Emp_Age INT;
DECLARE @Emp_Experience INT;

SELECT @Emp_DOB = i.Emp_DOB FROM INSERTED i;
SELECT @Emp_Experience = i.Emp_Experience FROM INSERTED i;

SET @Emp_Age= YEAR(GETDATE())-YEAR(@Emp_DOB);

IF @Emp_Age>25
BEGIN
PRINT 'NOT ELIGIBLE : AGE IS GREATER THAN 25'
ROLLBACK
END

ELSE IF @Emp_Experience<5
BEGIN
PRINT 'NOT ELIGIBLE : EXPERIENCE IS LESS THAN 5 YEARS '
ROLLBACK
END

ELSE
BEGIN
PRINT 'EMPLOYEE DETAILS INSERTED SUCCESSFULLY'
END

GO
----------UPDATE TRIGGER------------------
CREATE TRIGGER TriggerAfterUpdate ON Employee
AFTER UPDATE
as
DECLARE @Emp_id int ;
DECLARE @Emp_name Varchar(50)  ;
DECLARE @Old_Emp_name Varchar(50)  ;
DECLARE @Emp_salary Decimal(10,2)  ;
DECLARE @Old_Emp_salary Decimal(10,2)  ;

SELECT @Emp_id = i.Emp_id FROM INSERTED i;
SELECT @Emp_name = i.Emp_name FROM INSERTED i;
SELECT @Old_Emp_name = i.Emp_name FROM DELETED i;
SELECT @Emp_salary = i.Emp_salary FROM INSERTED i;
SELECT @Old_Emp_salary = i.Emp_salary FROM DELETED i;

IF UPDATE(Emp_name)
BEGIN
INSERT INTO Employee_History(Emp_id,Field_name,old_value,new_value,record_Time) values(@Emp_id,'Emp_name',@Old_Emp_name,@Emp_name,GETDATE());
END

IF UPDATE(Emp_salary)
BEGIN
INSERT INTO Employee_History(Emp_id,Field_name,old_value,new_value,record_Time) values(@Emp_id,'Emp_salary',@Old_Emp_salary,@Emp_salary,GETDATE());
END
------------DELETE TRIGGER -----------------------------
go
CREATE TRIGGER TRIGGERAfterDelete on Employee
AFTER DELETE 
AS 
DECLARE @Emp_id int ;
DECLARE @Emp_name  Varchar(50);
DECLARE @Emp_salary Decimal(10,2) ;
DECLARE @EMp_DOB Datetime;
DECLARE @Emp_Experience int ;
DECLARE @Record_time Datetime;

SELECT @Emp_id= i.Emp_id FROM DELETED i;
SELECT @Emp_name= i.Emp_name FROM DELETED i;
SELECT @Emp_salary=i.Emp_salary FROM DELETED i ;
SELECT @EMp_DOB=i.EMp_DOB FROM DELETED i;
SELECT @Emp_Experience=i.Emp_Experience FROM DELETED i;
SELECT @Record_time =i.Record_time FROM DELETED i;

INSERT INTO Employee_Backup(Emp_id,Emp_name,Emp_salary,EMp_DOB,Emp_Experience,Record_time)values(@Emp_id,@Emp_name,@Emp_salary,@EMp_DOB,@Emp_Experience,getdate());

--------------------------------------------------------------------------------------------------------






