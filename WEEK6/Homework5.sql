--Soru 1
select title,length from film where title like '%n'
order by 2 desc
limit 5
--Soru 2
select title,length from film
where title like '%n'
order by 2
offset 5
limit 5
--Soru 3
select last_name from customer where store_id =1
order by 1 desc
limit 4