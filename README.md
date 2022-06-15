**Задача:**
<br>Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

**Примеры:**

["lello", "2", "world", ":-)"] -> ["2", ":-)"]
<br>["1234", "1567", "-2", "computer sceince"] -> ["-2" ]
<br>["Russia", "Denmark", "Kazan"] -> []

**Описание решения:**
<br> Пользователь вводит с клавиатуры значение проверяемых элементов, затем вводит каждый элемент. Программа проверяет длину каждого введенного элемента и, если элемент имеет длину 3 или меньше символов, то в итоговый массив resultArray присваивается значение, если элемент имеет длину больше 3, то данный элемент пропускается. После итоговый массив выводится на экран. 

**Блок-схема решения задачи:**
