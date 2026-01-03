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



-- Either a unique constraint:
ALTER TABLE dbo.ElectricityBill
ADD CONSTRAINT UQ_ElectricityBill_ConsumerNumber
UNIQUE (consumer_number);


-- created_at for time-based ordering
ALTER TABLE ElectricityBill
ADD created_at DATETIME NOT NULL DEFAULT(GETDATE());


USE ElectricityBillDB;
GO
ALTER TABLE dbo.ElectricityBill DROP CONSTRAINT UQ_ElectricityBill_ConsumerNumber;



CREATE TABLE dbo.Consumers
    (
        consumer_id     INT IDENTITY(1,1) PRIMARY KEY,
        consumer_number VARCHAR(20) NOT NULL UNIQUE,
        consumer_name   VARCHAR(50) NOT NULL
    );



INSERT INTO dbo.Consumers (consumer_number, consumer_name)
SELECT DISTINCT consumer_number, consumer_name
FROM dbo.ElectricityBill
WHERE consumer_number IS NOT NULL AND consumer_name IS NOT NULL;
GO

delete from consumers;




-- 3) Make consumer_id NOT NULL
ALTER TABLE dbo.ElectricityBill
ALTER COLUMN consumer_id INT NOT NULL;
GO



-- 2) Backfill mapping 
UPDATE EB
SET EB.consumer_id = C.consumer_id
FROM dbo.ElectricityBill AS EB
JOIN dbo.Consumers      AS C
  ON C.consumer_number = EB.consumer_number;
GO


-- 4) Add foreign key
ALTER TABLE dbo.ElectricityBill
ADD CONSTRAINT FK_ElectricityBill_Consumers
    FOREIGN KEY (consumer_id) REFERENCES dbo.Consumers(consumer_id);
GO
