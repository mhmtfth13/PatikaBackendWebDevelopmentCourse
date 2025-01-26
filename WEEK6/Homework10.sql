--Soru 1
select city, country from city C
left join country CO
on CO.country_id = C.country_id
order by 1
--Soru 2
select P.payment_id,C.first_name,C.last_name from customer C
right join payment P
on C.customer_id = P.customer_id
--Soru 3
select * from customer C
full join rental R
on C.customer_id = R.customer_id
order by 1