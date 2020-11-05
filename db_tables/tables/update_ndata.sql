use Rest;

INSERT INTO Employee(`idEmployee`, `Name`, `Dateofbirth`, `Salary`, `Hoursofwork`, `login`, `password`, `Cellphone`) VALUES
(1, 'Ivan', '1994-05-20', 100000, 10, 'waiter', '20051994Ivan', '8(977)645-35-66'),
(2, 'Vladimir', '1983-05-17', 110000, 12, 'cooker', '17051983Vladimir', '8(988)777-37-64'), 
(3, 'Anna', '1999-09-13', 60000, 8, 'waiter', '13091999Anna', '8(903)199-85-26'), 
(4, 'Anatoliy', '1989-03-18', 70000, 9, 'waiter', '18031989Anatoliy', '8(938)145-57-55'), 
(5, 'Eliza', '1997-08-16', 65000, 10, 'cooker', '16081997Eliza', '8(952)075-27-60'),
(6, 'Alex', '1992-03-09', 85000, 11, 'cooker', '16081997Eliza', '8(928)038-28-90');
-- INSERT INTO `Rest`.`Warehouse` (`name`, `idposition`, `quantity`, `cost`, `info`) VALUES
-- 	('Баранина', 1789, 12, 7200, ' '),
--     ('Помидоры', 1235, 50, 4000, ' ');

INSERT INTO rest.order (`idOrder`, `date`, `time_order`, `idwaiter`) VALUES
(11155, DATE(NOW()), TIME(NOW()), 1),
(77789, DATE(NOW()), TIME(NOW()), 2);

INSERT INTO Position ( `idposition`, `Name`, `Price`) VALUES
(11155, 'Цезарь', 600),
(77789, 'Тартар', 1100);

INSERT INTO Item (`idposition`, `quant`, `total_rice`, `id_order`) VALUES
(11155, 1,  1, 11155),
(77789, 2,  2, 77789);