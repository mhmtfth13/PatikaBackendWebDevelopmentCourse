--Soru 1
select rating from film
group by rating
order by 1
--Soru 2
select replacement_cost, count(*) as "FILM SAYISI" from film
group by replacement_cost
having count(*)> 50
order by 1 desc
--Soru 3
select store_id, count(*) from customer
group by store_id
order by 1 asc
--Soru 4
select country_id, count(*) as "sehir sayisi" from city
group by country_id
order by 2 desc
limit 1
