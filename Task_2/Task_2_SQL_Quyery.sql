SELECT * FROM Product_Category - запрос для вывода всех пар: название продукта - название категории



SELECT Name_C FROM Product_Category
WHERE Name_P = 'MyName' - запрос для вывода категорий одного продукта 


SELECT Name_P FROM Product_Category
WHERE Name_C = 'MyNameCategory' -запрос для вывода продуктов одной категории

SELECT Name_C, COUNT(*) FROM Product_Category
GROUP BY Name_C - запрос для вывода количества продуктов в каждой категории

