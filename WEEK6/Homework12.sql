-- Soru 1
select count(*) from film where length >
(
	select avg(length) from film
)
--Soru 2
select count(*) from film
where rental_rate =
(
	select max(rental_rate) from film
)
--Soru 3
select rental_rate, replacement_cost
from film
where (rental_rate, replacement_cost) in
(
	Select rental_rate, replacement_cost from film
	where rental_rate = (select MIN(rental_rate) from film)
	and replacement_cost = (select min(replacement_cost) from film)
)
--Soru 4
select customer_id from 
(
select customer_id,count(*) as "ADET" from payment
group by customer_id
order by 2 desc 
)

