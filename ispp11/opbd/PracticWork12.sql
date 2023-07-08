-- Задание 1
SELECT        Book.*
FROM            Book

-- Задание 2
SELECT        Name + ' ' + Surname AS Author
FROM            Author

-- Задание 3
SELECT DISTINCT Country
FROM            Author
ORDER BY Country Desc

-- Задание 4
SELECT        IdBook, Title, Price * 0.95 AS Price
FROM            Book
ORDER BY Price DESC, Title

--Задание 5
SELECT        IdAuthor, Title, COUNT(Title) AS BookCount
FROM            Book
GROUP BY Title, IdAuthor

-- Задание 6
SELECT        COUNT(*) AS BookCount, MIN(Price) AS MinPrice,
              MAX(Price) AS MaxPrice, AVG(Price) AS AvgPrice
FROM            Book

--Задание 7
SELECT        Genre, MAX(Price) AS MaxPrice, MIN(Price) AS MInPrice, COUNT(*) AS BookCount
FROM            Book
GROUP BY Genre