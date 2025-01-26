--Soru 1
select distinct(replacement_cost) from film
order by 1
--Soru 2
select count(distinct(replacement_cost)) as "birbirinden farkli deger sayisi" from film
--Soru 3
select count(*) as "ADET SAYISI" from film where title ilike 'T%' and rating = 'G'
--Soru 4
select count(*) as "ADET SAYISI" from country where country like '_____'
--Soru 5
select count(*) as "ADET SAYISI" from city where city ilike '%r'