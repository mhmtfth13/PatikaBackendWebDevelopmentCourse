--Soru 1
select country from country where country ilike 'A%a'
--Soru 2
select country from country where country like '_____%n'
--Soru 3
select title from film where title like '%t%t%t%t%'
--Soru 4
select * from film where title ilike 'C%' and length > 90 and rental_rate = 2.99
order by length,title

