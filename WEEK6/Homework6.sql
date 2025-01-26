--Soru 1
select round(avg(rental_rate),2) from film;
--Soru 2
select count(title) as "ADET" from film where title ilike 'C%';
--Soru 3
select max(length) from film where  rental_rate = 0.99;
-- ALTERNATIVE
-- select length from film where rental_rate = 0.99
-- order by 1 desc
-- limit 1;
--Soru 4
select count(distinct replacement_cost) as "Kac Farkli Adet" from film
where length > 150;
