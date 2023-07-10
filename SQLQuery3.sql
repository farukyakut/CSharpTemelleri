--select
--ANSI
select * from Customers

select ContactName,CompanyName,City from Customers

-- Alias
select ContactName Adi ,CompanyName SirketAdi ,City Sehir from Customer

-- where
select * from Customers where City = 'London'

select * from Products

select * from Products where categoryID = 1

select * from Products where cateGoryID = 1

select * from Products where categoryID = 1 or categoryId = 2

select * from Products where categoryId = 1 and UnitPrice >=10

--order by seçilen değişkenlere göre sıralar ve alfabetik veya küçükten büyüğe dooğru sıralar
-- asc  ascending (default)    
-- des  descending
select * from Products order by ProductName

select * from Products order by ProductName asc 

select * from Products order by ProductName desc

select * from Products where categoryId = 1 order by UnitPrice desc

select * from Products where categoryId = 1 order by UnitPrice asc

-- ürünlerdeki satır sayısnı (ürün) bulduk
select count(*) from products
select count(*) from products where CategoryId = 2

-- group by = "hangi kategoride kaç ürün var" gibi mantıksal işlemlerde kullanılır.

select CategoryId from Products group by categoryId

select CategoryId,count(*) from Products group by CategoryId

select CategoryId, count(*) from Products group by CategoryId having count(*) < 10 

select CategoryId, count(*) from Products where UnitPrice>20 group by CategoryId having count(*) < 10 

-- inner-join (sadece eşleşen dataları getiri)

select * from Products

select * from Products inner join Categories on Products.CategoryID  = Categories.CategoryID

select Products.ProductID,Products.ProductName,Categories.CategoryName,products.UnitPrice from Products inner join 
Categories on Products.CategoryID = Categories.CategoryID

select Products.ProductID,Products.ProductName,Categories.CategoryName,products.UnitPrice from Products inner join 
Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10

-- left join soldaki tabloda bulunan tüm değerler sağdaki tabloyla ortak olsa veya olmasa getirilir
select * from Products

select * from [Order Details]

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID 


--müşterilerde olup siparişlerde olmayan kayıtları getirirken

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
where o.CustomerID is null 