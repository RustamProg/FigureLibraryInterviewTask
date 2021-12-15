select p.product_name, c.category_name 
from Products p 
left join ProductCategotiesM2M m2m on p.Id = m2m.product_id
left join Categories c on m2m.category_id = c.id
order by p.product_name