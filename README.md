# Final-Project
ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Алгоритм выполнения задания:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)



Пояснение кода.
Задаеться массив из строк. Создается метод для вывода этого массива в консоль. Создается метод для определения размера второго массива. Для этого создается переменная(счетчик), пробегаемся по первому массиву с помощь цикла for, и проверяем условие "Если размер текущего элемента массива меньше или равно 3(символам), тогда созданная переменная увеличивается на 1, и так пока не пройдемся по всему массиву. В конце выполнения цикла выводим созданную переменную. Это будет размер нашего второго массива.
Затем создаем новый метод для создания нового текстового массива относительно первого массива. Создаются новые переменные pos( позиция элемента второго массива), chr(количество символов по заданию). Создается новый текстовый массив(пустой) с размером, который мы нашли в прошлом методе. Пробегаемся по первому массиву с помощью цикла for и в нем проверяем условие "Если размер элемента первого массива на позиции i меньше или равно переменной chr(количество символов по заданию), тогда элемент второго массива на позиции pos равен элементу первого массива на позиции i" и увеличиваем счетчик pos на 1. Если условие не выполняется, то возвращаемся к началу цикла и повторяем действия, пока не пройдем весь первый массив. Метод в итоге должен нам вернуть итоговый второй массив.
Вызываем метод печати массива, задаем параметры для печати первого массива.(для вывода в консоли первого заданного массива)
Вызываем метод нахождения размера второго массива.
Вызываем метод Создания второго массива, в условиях которого будет первый массив и найденый размер второго массива.
Вызываем метод печати массива,в условиях будет уже второй массив.
