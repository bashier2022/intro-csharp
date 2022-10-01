-- comment

select * from products -- get all procuts

/* mnulti line
 comment
 */


 select avg(Freight)
 from Orders

 select count(freight)
 from Orders
 where Freight > (
					select avg(Freight)
					from Orders
				)

select *
from Orders
where Freight > 500
/*
Create a report that shows the CategoryName and Description from the categories table sorted by CategoryName.
*/
select CategoryName, [Description]
from Categories
order by CategoryName
/*
Create a report that shows the ContactName, CompanyName, ContactTitle and Phone number from the customers table sorted by Phone.
*/
select ContactName, CompanyName, ContactTitle , Phone number
from customers
order by Phone

/*
3- Create a report that shows the top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight from the orders
   table sorted by Freight in descending order.
*/
select top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight
from  orders
order by Freight  desc





/*
Create a report that shows the City, CompanyName, ContactName of customers from cities starting with A or B.
*/
select City, CompanyName, ContactName 
from customers
where city like 'A%' or city like 'B%'
/*
Create a report that shows the CompanyName, ContactName number of all customer that have no fax number.
*/

select CompanyName, ContactName, phone
from Customers
where fax is null

/*
Create a report that shows the LastName, FirstName, City of employees in cities other "Seattle"
*/

select  LastName, FirstName, City
from employees
where city <> 'Seattle'

/*
Create a report that shows the
CustomerID, sum of Freight, from the orders table with sum of freight greater $200, grouped by CustomerID.
HINT: you will need to use a Groupby and a Having statement
*/

select CustomerID, sum(Freight) as TF
from Orders
group by CustomerID
having sum(Freight) > 200

/*

1b )  Create a query to display the name of the customer doing the largest sum of purchases (cost of items + freight)

*/

select ContactName
from customers
where CustomerID = (
					select Top 1 CustomerID
					from Orders
					group by CustomerID
					order by sum(freight) desc
					)


/*
2b ) Create a query to compute the largest order ( total cost of items in order without freight)
*/
select Top 1 OrderID, sum(Unitprice * quantity)
from [Order Details]
group by OrderID
order by sum(Unitprice * quantity) desc

/*
3b ) Create a query to show the total sum of orders purchased by customers from Mexico
*/

select orderid, sum(Unitprice * quantity) as TotalOrderPrice
from [Order Details]
where OrderID in (
					select OrderID
					from Orders
					where ShipCountry = 'Mexico'
					)
group by OrderID



select sum(x.Unitprice * x.quantity) as TotalOrderPrice 
from [Order Details] as x , Orders as y
where x.OrderID = y.OrderID and y.ShipCountry = 'Mexico'

select sum(Unitprice * quantity) as TotalOrderPrice 
from [Order Details] 
where OrderID in ( select OrderID
					from Orders
					where ShipCountry = 'Mexico')



/*

4b ) Create a query to compute the total amount of sales to all customers in France

*/

select count(Orderid)
from Orders
where OrderID in ( select OrderID
					from Orders
					where ShipCountry = 'France') 

/*
5b ) Create a query to display the average cost of order for all orders purchased by customers in France
*/
select avg(Unitprice * quantity) 
from [Order Details] 
where OrderID in ( select OrderID
					from Orders
					where ShipCountry = 'France')
/*
6b ) Create a query to display the total money for all discounts on order from Mexico
*/

select sum(Unitprice * quantity * Discount) as TotalDiscountPrice 
from [Order Details] 
where OrderID in ( select OrderID
					from Orders
					where ShipCountry = 'Mexico')

/*
7b ) Query to display the count of customers from each city

*/

select city, count(customerid) as [the count of customers]
from Customers
group by City
order by count(customerid) desc
