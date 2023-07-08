--������� 1
SELECT        Book.IdBook, Book.Title, Author.Surname, Author.Name, Book.Price
FROM            Author INNER JOIN
                         Book ON Author.IdAuthor = Book.IdAuthor

--������� 2
SELECT        Composition.IdOrder, Book.IdBook, Book.Title, Author.Surname, Author.Name
	, Book.Price, Composition.Quantity, Book.Price*Composition.Quantity AS �ost
FROM            Author INNER JOIN
                         Book ON Author.IdAuthor = Book.IdAuthor INNER JOIN
                         Composition ON Book.IdBook = Composition.IdBook
						 
-- ������� 3
SELECT        [Order].IdOrder, [Order].OrderDate, SUM(DISTINCT Book.Price * Composition.Quantity) AS Cost
FROM            [Order] INNER JOIN
                         Composition ON [Order].IdOrder = Composition.IdOrder INNER JOIN
                         Book ON Composition.IdBook = Book.IdBook
GROUP BY [Order].IdOrder, [Order].OrderDate
ORDER BY OrderDate DESC

-- ������� 4
SELECT        Customer.IdCustomer, Customer.Login, COUNT([Order].IdOrder) AS OrderCount
FROM            Customer LEFT JOIN
                         [Order] ON Customer.IdCustomer = [Order].IdCustomer
GROUP BY Customer.IdCustomer, Customer.Login

-- ������� 5
SELECT        [Order].IdOrder, [Order].IdCustomer, [Order].OrderDate
FROM            [Order] 
WHERE         [Order].IdOrder NOT IN
                             (SELECT DISTINCT IdOrder
                               FROM            Composition )

-- ������� 6
SELECT *
FROM Customer
WHERE IdCustomer IN (SELECT DISTINCT IdCustomer 
					FROM [Order])

-- ������� 7
SELECT surname, name, '�����' AS correction
FROM Author 
UNION 
SELECT surname, name, '��������'
FROM Customer
ORDER BY surname, name

