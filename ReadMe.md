## Итоговая проверочная задача ##  

Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

## Краткое описание решения ## 

1. Создаём int i , j , result. 
2. Присваиваем 0 значение.
3. Создаём string[] array из 6 элементов.
4. Циклом while заполняем массив, после введённого слова счётчик увелич на 1.
5. Далее счётчик -> 0.
6. Циклом while устанавливаем количество знаков слов в массиве <= 3. Присваиваем значение int result
7. Создаём нов массив длиной с result.
8. i==0, j==0.
9. Циклом while определяем количество символов слов в изначальном массиве, если слово соответствует требованию <= 3 символам, -> в новый массив, или пропускаем.
10. Вывод результата циклом while.