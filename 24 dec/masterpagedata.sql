create database infinite;

create table tblproducts
(
ID int identity primary key,
ProductName nvarchar(50),
Description nvarchar(200),
);
insert into tblproducts values
('Laptop','Dell Laptop'),
('Desktop','HP Computers'),
('IPhone','Apple Ltd.'),
('LED TV','Samsung LED');

select * from tblproducts;

create or alter procedure spGetProducts
as
begin
waitfor delay '00:00:05'
select Id,productname,description from tblproducts
end;

execute spGetProducts;

create or alter proc spGetproductbyname
@productname nvarchar(50)
as
begin
if(@productname='All')
begin
select Id,productname,description from tblproducts
end
else
begin
select Id,productname,description from tblproducts where ProductName=@productname
end
end;

execute spGetproductbyname 'Laptop'