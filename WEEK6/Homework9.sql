--Soru 1
select city,country from city C 
inner join country CO
on C.country_id = CO.country_id
order by 1
--Soru 2
select P.payment_id, C.first_name, C.last_name from customer C
inner join payment P
on C.customer_id = P.customer_id
order by 1 

--Soru 3
select R.rental_id, C.first_name, C.last_name from rental R
inner join customer C
on R.customer_id = C.customer_id
