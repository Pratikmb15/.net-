-----------DDL Triggers-----------------------------

USE Triggers_DB
GO
create Trigger TriggerPreventCreateTable
on database 
for CREATE_TABLE
AS
BEGIN
PRINT 'YOU CANNOT CREATE TABLE IN THIS DATABASE '
ROLLBACK TRANSACTION
END
GO
create Trigger TriggerPreventDDLTABLE
on database 
for DDL_TABLE_EVENTS
AS
BEGIN
PRINT 'YOU CANNOT CREATE/ALTER/DROP TABLE IN THIS DATABASE '
ROLLBACK TRANSACTION
END

--Dropping Trigger-----------
DROP TRIGGER TriggerPreventCreateTable ON DATABASE ;

---------------Trigger Audits DDl changes in database----------------
GO
create Trigger TrgAuditChangesInDatabase
on DATABASE
for DDL_TABLE_EVENTS
AS
BEGIN
DECLARE @EventData XML
SELECT @EventData=EVENTDATA()
    INSERT INTO TableAudit (DatabaseName, TableName, EventType, LoginName, SqlCommand, AuditDateTime)
    VALUES (
        @EventData.query('data(/EVENT_INSTANCE/DatabaseName)').value('.', 'VARCHAR(250)'),
        @EventData.query('data(/EVENT_INSTANCE/ObjectName)').value('.', 'VARCHAR(250)'),
        @EventData.query('data(/EVENT_INSTANCE/EventType)').value('.', 'VARCHAR(250)'),
        @EventData.query('data(/EVENT_INSTANCE/LoginName)').value('.', 'VARCHAR(250)'),
        @EventData.query('data(/EVENT_INSTANCE/TSQLCommand)').value('.', 'VARCHAR(2500)'),
        GETDATE()
    );
       
END

create table test3(
Id int,
name varchar(50),
Dept varchar(30)
)
Alter table test3
add  Department varchar(50) default 'IT';

Drop table test3;

select * from TableAudit;
