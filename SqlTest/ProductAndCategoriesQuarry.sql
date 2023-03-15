-- Между таблицами Product и Category связь многие ко многим, 
-- следовательно её нужно раскрыть через промежуточную таблицу ProductWithCategory, 
-- в которой будут находится пары ID'шников от продукта и от категории
-- Исходя из этих размышлений я составил следующий запрос:

select P.`name`, C.`categoryName` 
from `Product` as P
left join `ProductWithCategory` as PC
on P.`prodId` = PC.`prodId`
left join `Category` as C
on PC.`categId` = C.`categId`;