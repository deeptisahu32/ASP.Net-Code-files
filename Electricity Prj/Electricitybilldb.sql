create database ElectricityBillDB;

create table electricityBill
(
consumer_number varchar(20),
consumer_name varchar(50),
units_consumed int,
bill_amount float
);

select * from electricityBill;




ALTER TABLE ElectricityBill
ADD id INT IDENTITY(1,1);

ALTER TABLE ElectricityBill
ADD CONSTRAINT PK_ElectricityBill_id PRIMARY KEY (id);
