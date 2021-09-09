SELECT 'Имя_продукта', 'Имя_категории'
FROM 'продукты' PR
LEFT JOIN 'категории' KT ON PR.ID=KT.ID_продукты