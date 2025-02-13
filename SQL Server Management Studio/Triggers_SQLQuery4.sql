use Triggers_DB;

create table TableAudit(
DatabaseName varchar(250),
TableName varchar(250),
EventType varchar(250),
LoginName varchar(250),
SqlCommand varchar(2500),
AuditDateTime datetime
)
