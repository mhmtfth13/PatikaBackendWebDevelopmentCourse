--use  dvdrental this usage for selecting db for mssql syntax
--Soru 1
select title, description from film
--Soru 2
select * from film where length>60 and length < 75
--Soru 3
select * from film where rental_rate = 0.99 and 
replacement_cost = 12.99 or replacement_cost=28.99
--Soru 4
select last_name from customer where first_name = 'Mary'
--Soru 5
select * from film where length <> 50 and rental_rate not in (2.99,4.99)

