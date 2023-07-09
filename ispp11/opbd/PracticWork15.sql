-- Задание 1
UPDATE Book 
SET Price = ROUND(Price, -1);

-- Задание 2
SELECT COUNT(*) AS CountOrder,  MONTH(OrderDate), YEAR(OrderDate) AS OrderDate
FROM [Order]
GROUP BY MONTH(OrderDate), YEAR(OrderDate)
ORDER BY OrderDate DESC;

-- Задание 3
UPDATE Book
SET Price *= 0.9
FROM Book JOIN Composition ON Composition.IdBook = Book.IdBook
		  JOIN [Order] ON Composition.IdOrder = [Order].IdOrder
WHERE YEAR(GetDate()) = YEAR(OrderDate);

-- Задание 4
SELECT IdCustomer, CONCAT_WS(' ', UPPER(surname), LEFT(name, 1)+'.')
FROM Customer;

-- Задание 5
UPDATE Customer
SET Login = REPLACE(TRIM(Login),' ', '_');

-- Задание 6
SELECT        IdCustomer, Login, Surname, Name, NULLIF(address, ''), ISNULL(phone, '-')
FROM            Customer;

-- Задание 7
SELECT idAuthor,
STRING_AGG(title, '; ') 
WITHIN GROUP(ORDER BY title)
FROM Book
GROUP BY idAuthor

-- Задание 8
SELECT 
STRING_AGG(CONCAT_WS(' ', surname, name, title), ';') 
WITHIN GROUP(ORDER BY title)
FROM Book JOIN Author ON Book.IdAuthor = Author.IdAuthor
		  JOIN Composition ON Composition.IdBook = Book.IdBook
		  JOIN [Order] ON Composition.IdOrder = [Order].IdOrder
GROUP BY [Order].idOrder;

-- Задание 9
SELECT ROW_NUMBER() OVER(order by title) N, title
FROM Book;

-- Задание 10
SELECT ROW_NUMBER() OVER(partition by genre order by title) N, title, genre
FROM Book;