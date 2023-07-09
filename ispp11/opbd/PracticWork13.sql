-- Задание 1
SELECT        Title
FROM            Book
WHERE        (Genre = N'проза') AND (Price >= 500) AND (Price <= 1000)

-- Задание 2
SELECT        Surname, Name, Phone
FROM            Customer
WHERE        (Phone IS NOT NULL)

-- Задание 3
SELECT        Book.*
FROM            Book
WHERE        (Title LIKE N'%Война%') 

-- Задание 4
SELECT        Title
FROM            Book
WHERE        (Title LIKE N'С%')

-- Задание 5
SELECT        Country, COUNT(*) AS AuthorCount
FROM            Author
GROUP BY Country
HAVING        (COUNT(*) > 1)

-- Задание 6
SELECT        IdOrder, SUM(Quantity) AS QuantityBook
FROM            Composition
GROUP BY IdOrder
HAVING        (SUM(Quantity) > 5)

-- Задание 7
SELECT        IdAuthor, Title, COUNT(Title) AS BookCount
FROM            Book
GROUP BY IdAuthor, Title
HAVING        (COUNT(Title) > 1)