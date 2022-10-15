
select orderid, sum(Unitprice * quantity) as TotalOrderPrice
from [Order Details]
where OrderID in (
					select OrderID
					from Orders
					where ShipCountry = 'Mexico'
					)
group by OrderID