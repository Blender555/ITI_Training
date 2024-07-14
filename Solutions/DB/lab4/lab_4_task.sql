restore database Shop
from disk='D:\Study\ITI_Training\Labs\Problems\Shop_Database.bak'

use Shop
go
create table Products(
ProductId int identity(1,1) primary key,
ProductName varchar(35)
)
---------1-----------

select * from  Products
order by ProductName asc;


---------2-----------

alter table Orders
add OrderDate date;

select * from Orders
order by OrderDate desc;

---------3-----------

alter table Products
add UnitPrice smallmoney;

select top 5 * from Products
order by UnitPrice desc;

---------4-----------

select top 3 * from Orders
order by OrderDate desc;

---------5-----------

select ProductName as Product, UnitPrice as Price from Products;

---------6-----------

select * from Orders
where OrderDate between '2023-01-01' and '2023-12-31';

---------7-----------

select count(*) from Products;

---------8-----------

create table OrderDetails (
Quantity int 
);

select sum(Quantity) from OrderDetails;

---------9-----------

select avg(UnitPrice) from Products;

---------10-----------

select min(OrderDate), max(OrderDate) from Orders;

---------11-----------

select CustomerID, count(*) from Orders
group by CustomerID;

---------12-----------

select CustomerID, Amount from Orders 
group by CustomerID 
having Amount > 10;

---------13-----------

select * from Customers 
where Name like 'A%';

---------14-----------

select * from Products 
where ProductName like '%Tea%';

---------15-----------

alter table Customers
add Phone decimal(10,0);

select * from Customers 
where Phone like '%5';

---------16-----------

select Orders.OrderID, Orders.OrderDate, Customers.CustomerName 
from Orders 
join Customers on Orders.CustomerID = Customers.CustomerID;

---------17-----------

select Customers.CustomerID, Customers.CustomerName, Orders.OrderID, Orders.OrderDate 
from Customers 
left join Orders on Customers.CustomerID = Orders.CustomerID;

---------18-----------

select o.OrderID, o.OrderDate, c.CustomerID, c.CustomerName 
from Orders as o
left join Customers as c on o.CustomerID = c.CustomerID;

---------19-----------

select o.OrderID, o.OrderDate, c.CustomerName 
from Orders as o
full outer join Customers as c on o.CustomerID = c.CustomerID;

---------20-----------

go
create view CustomerOrders
as 
select c.CustomerID, c.CustomerName, o.OrderID, o.OrderDate 
from Customers as c
join Orders as o on c.CustomerID = o.CustomerID;

---------21-----------
go
select distinct CustomerID from Orders;

---------22-----------

alter table Products
add Availability bit;

select * from Products 
union 
select * from Products
where not Availability;

---------23-----------

select ProductName, UnitPrice, 
       case 
           when UnitPrice > 20 then 'Expensive' 
           when UnitPrice between 10 and 20 then 'Moderate' 
           else 'Cheap' 
       end as PriceCategory 
from Products;

---------24-----------

alter table Customers 
add primary key (CustomerID);

---------25-----------

alter table OrderDetails 
add constraint FK_OrderDetails_Orders 
foreign key (OrderID) 
references Orders(OrderID);

---------26-----------

alter table Products 
alter column ProductName varchar(25) not null;

---------27-----------

alter table Orders 
add constraint DF_OrderDate 
default getdate() for OrderDate;

---------28-----------

alter table Products 
add constraint CHK_UnitPrice 
check (UnitPrice > 0);

---------29-----------

alter table Customers 
add constraint UQ_Email 
unique (Email);

