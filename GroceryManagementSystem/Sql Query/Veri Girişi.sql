--INSERT INTO Users
--VALUES ('Hamit','Sýrdar', 'h', 'h',3,'Müþteri','C:\Users\ebatu\Desktop\Yazýlým Indexler\Architecht\VirtualComputer\assets\images\user-128.png',1, 0);

--INSERT INTO Users
--VALUES ('Aslý','Yar', 'a', 'a',3,'Müþteri','C:\Users\ebatu\Desktop\Yazýlým Indexler\Architecht\VirtualComputer\assets\images\user-128.png',1, 0);

--INSERT INTO Users
--VALUES ('Hande','Guler', 'hande@gul.com', '1234567',3,'Müþteri','C:\Users\ebatu\Desktop\Yazýlým Indexler\Architecht\VirtualComputer\assets\images\user.jpg',1, 0);

--UPDATE Users
--SET RoleId = 2
--WHERE Id = 3; 

--create proc adminLogin 
--@Email nvarchar(MAX),
--@Password nvarchar(MAX),
--@RoleId int
--as 
--begin 

--select * from Users where Email=@Email and Password=@Password and RoleId=1;

--end


--UPDATE Products
--SET IsDelete = 0
--Where Id = 4; 


--UPDATE Categories
--SET 
--  Name = 'Fruits and Vegetables', 
--  Description = 'Fresh fruits and vegetables',
--  IsStatus = 1,
--  Image = null,
--  IsDelete = 0
--WHERE Name = 'Electronics';

--UPDATE Categories
--SET 
--  Name = 'Dairy and Eggs', 
--  Description = 'Milk, cheese, and eggs',
--  IsStatus = 1,
--  Image = null,
--  IsDelete = 0
--WHERE Name = 'Clothing';

--UPDATE Categories
--SET 
--  Name = 'Meat and Poultry', 
--  Description = 'Fresh meat and poultry',
--  IsStatus = 1,
--  Image = null,
--  IsDelete = 0
--WHERE Name = 'Books';

--UPDATE Categories
--SET 
--  Name = 'Bakery', 
--  Description = 'Freshly baked bread and pastries',
--  IsStatus = 1,
--  Image = null,
--  IsDelete = 0
--WHERE Name = 'Groceries';

--UPDATE Categories
--SET 
--  Name = 'Canned and Packaged Foods', 
--  Description = 'Canned goods and packaged foods',
--  IsStatus = 1,
--  Image = null,
--  IsDelete = 0
--WHERE Name = 'Home and Garden';


-- Products tablosuna örnek ürünleri eklemek için SQL kodu
INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId, IsStatus, IsDelete)
VALUES
  ('Apple', 'Fresh and juicy apples', 2.99, 100, null, 2, 1, 0)
  --('Milk', 'High-quality fresh milk', 1.99, 50, null, 3, 1, 0),
  --('Chicken Breast', 'Lean and tender chicken breast', 8.99, 30, null, 4, 1, 0)
