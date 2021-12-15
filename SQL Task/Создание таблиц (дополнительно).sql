create table Products (
 id int primary key identity(1, 1),
 product_name nvarchar(100),
 price decimal(10, 2)
 );

 create table Categories (
 id int primary key identity(1, 1),
 category_name nvarchar(100),
)

create table ProductCategotiesM2M(
 id int primary key identity(1, 1),
 product_id int,
 category_id int,
 constraint fk_m2m_products foreign key(product_id) references Products(id) on delete cascade,
 constraint fk_m2m_categories foreign key(category_id) references Categories(id) on delete cascade,
 )


 insert into Products values
 ('IPhone 12', 75000),
('PS4', 25000),
('Фен', 10000), --Будет в двух категориях
('Молоко', 100),
('Кресло', 9000),
('Кровать', 20000),
('Стол', 15000),
('Корм для кошек', 500); -- Не будет категории

insert into Categories values
('Электроника'),
('Уход за собой'),
('Продукты питания'),
('Мебель');

insert into ProductCategotiesM2M values
(1, 1),
(2, 1),
(3, 1),
(3, 2),
(4, 3),
(5, 4),
(6, 4),
(7, 4)