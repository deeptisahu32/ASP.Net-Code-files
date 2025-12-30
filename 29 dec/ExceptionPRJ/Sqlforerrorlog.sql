create table tblExceptionLog
(
LogId bigint identity(1,1) not null,
Exceptionmsg nvarchar(100),
Exceptiontype varchar(100),
Exceptionsource nvarchar(max),
ExceptionURL varchar(100),
LogDate datetime
);

-- let's create stored procedure to log any exceptions happening

create or alter procedure ExceptionLoggingToDB
(@excmsg nvarchar(100),@excetype varchar(100),@excsrc nvarchar(max),@excurl varchar(100))
as
begin
insert into tblExceptionLog select @excmsg,@excetype,@excsrc,@excurl,GETDATE()
end;

select * from tblExceptionLog;