// Написать программу, которая на вход принимает число и выдаёт его квадрат.

// Просим пользователя ввести число.
// Console.Write("Введите число: ");

// Создаём переменную number, 
// тип данных который мы будем хранить в этой переменной int(целый тип чисел) 
// и сохраняем значение, которое введёт пользователь при помощи :
//Convert.Toint

Console.Write("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());

// Дополнительные два способа возведения числа в квадрат

// int sqrt = number * number;
//Console.WriteLine("Число в квадрате:" + number);

// number *= number;

// Maht.Pow возводит переменную в ту степень, которую мы укажем.
// Math.Pow(number, 3 ) возведёт в третью степень (4 в четвертую) и т.д.
int sqrt1 = Convert.ToInt32(Math.Pow(number,2));

Console.WriteLine("Число в квадрате:" + sqrt1);


// метод Pow для вычисления значения, 
// которое 2 возводит в степень в диапазоне от 0 до 32.
int value = 2;
for (int power = 0; power <= 32; power++)
   Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");
//2*2 = 4
//2*3 = 6 и т.д



// Найти максимум из 9 чисел (вариант 1 )

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 35;

// Определим переменную максимум, в которую положим значение первого аргумента. 
int max = a1;
// Поиск максимума из первой тройки.
if(b1 > max) max = b1;
if(c1 > max) max = c1;

// Поиск максимума из второй тройки.
if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

// Поиск максимума из третьей тройки.
if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max); 

// Найти максимум мз 9 чисел с помощью функций (вариант 2)

// Возьмём функцию Мах и в качестве возвращаемого типа возьмём (int)
// учитывая, что мы работаем с целыми числами. 
// Далее наша функция продает следующую работу : она возьмёт три числа
// и найдёт максимальное значение из этих трёх чисел.
// Метод return будет возвращать результат.

int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if(arg2 > result) result = arg2;
   if(arg3 > result) result = arg3;
   return result;
} 
   int a1 = 15;
   int b1 = 21;
   int c1 = 39;
   int a2 = 12;
   int b2 = 23;
   int c2 = 33;
   int a3 = 13;
   int b3 = 23;
   int c3 = 35;

   int max1 = Max(a1,b1,c1);

   int max2 = Max(a2,b2,c2);

   int max3 = Max(a3,b3,c3);

// Сравнение максимального числа из каждой тройки чисел 
// и выбор максимального числа.
   int max = Max(max1,max2,max3);

   Console.WriteLine(max);
 // В этой задаче строки с 20-й по 26-ю можно записать более коротко.
   // int Max = Max (
   //     Max = (a1,b1,c1),
   //     Max = (a2,b2,c2),
   //     Max = (a3,b3,c3));

// Найти максимум мз 9 чисел с помощью массива (вариант 3)

int Max (int arg1, int arg2, int arg3)
{
   int result = arg1;

   if(arg2 > result) result = arg2;
   if(arg3 > result) result = arg3;
   return result;
} 
// Определим массив[int], дадим наименование (array)
//          index   0  1  2  3  4  5  6  7  8
   int [] array = {11,21,31,41,15,61,17,18,19};
//  В фигурных скобках {} перечисляем значение, которое хотим использовать.  

array [0] = 11; 
// Обращаемся к конкретному элементу. Пишем его имя и индекс

Console.WriteLine(array[0]);

// переменная max пишется с маленькой буквы
// функция Max пишется с большой буквы 
   int max = Max(      
              Max (array[0], array[1], array[2]),
              Max (array[3], array[4], array[5]),
              Max (array[6], array[7], array[8])

   );
   Console.WriteLine(max);
   
