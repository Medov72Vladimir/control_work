# Control_work
*Данный проект является контрольной работой проверки моих знаний и навыков по итогу прохождения первого блока обучения по программе разработчик на платформе обучения GeekBrains.*

**Требования:**

1. Создание репозитория на GitHub.
2. Составление блок-схемы алгоритма.
3. Оформление текстового описания решения.
4. Написание программы.
5. Использование контроля версий, а именно: этапы 2,3,4 должны быть расположены в разных коммитах.

**Задача:**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**

1. ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
2. ["1234", "1567", "-2", "computer science"] -> ["-2"]
3. ["Russia", "Denmark", "Kazan"] -> [ ]

**Описание решения**

Объявляем переменную *N* типа *int* (целое число) и присваиваем ей значение *4* - это длина исходного массива.

Объявляем два массива с элементами массива типа *string* (строка): *array* и *secondarray*. Строка - это последовательность символов, состоящая из букв, цифр, знаков препинания.

Объявляем переменную *number* типа *int*  и присваиваем ей значение *0* - этой переменной будет присваиваться количество символов элемента массива.

Объявляем переменную *j* типа *int*  и присваиваем ей значение *0* - это переменная-счетчик цикла.

С помощью инструкции *for* реализуем ввод элементов (строк) исходного массива с клавиатуры, при этом проверяя введенную строку, используя инструкцию *if*, выполняется ли заданное условие <= 3. При истиности условия добавляем строку в искомый массив *secondarray*.

Используя далее ещё одну инструкцию *for* выводим искомый массив на консоль.

