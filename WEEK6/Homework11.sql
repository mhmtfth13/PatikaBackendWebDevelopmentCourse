--Soru 1
(select first_name from actor)
UNION
(select first_name from customer)
--Soru 2
(select first_name from actor)
intersect
(select first_name from customer)
--Soru 3 
(select first_name from actor)
except
(select first_name from customer)
-- Soru 4
(SELECT first_name FROM actor)
UNION ALL 
(SELECT first_name FROM customer)

(SELECT first_name FROM actor)
INTERSECT ALL
(SELECT first_name FROM customer)

(SELECT first_name FROM actor)
EXCEPT ALL
(SELECT first_name FROM customer)


-- UNION (647): İki tablodaki benzersiz tüm isimler
-- INTERSECT (72): Her iki tabloda da olan isimler
-- EXCEPT (56): Sadece actor tablosunda olan isimler
-- Geri kalan (519): Sadece customer tablosunda olan isimler
-- Toplam: 56 (sadece actor) + 72 (ortak) + 519 (sadece customer) = 647 (toplam benzersiz)