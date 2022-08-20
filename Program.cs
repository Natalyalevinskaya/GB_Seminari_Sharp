// Задача 1.
// Написать программу, которая на вход принимает число и выдаёт его квадрат.

// Просим пользователя ввести число.
// Console.Write("Введите число: ");

// Создаём переменную number, 
// тип данных который мы будем хранить в этой переменной int(целый тип чисел) 
// и сохраняем значение, которое введёт пользователь при помощи :
// Сonsole.ReadLine - сохраняем значение, которое введёт пользователь.
// sqrt - переменная, в которую мы сохраняем возведение в квадрат
// название может быть и другое. 
 

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sqrt = number * number;
Console.WriteLine("Число в квадрате:" + sqrt);

//Вариант 2

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number *= number;
Console.WriteLine("Число в квадрате:" + number);

// number *= number возведение в квадрат.

// Вариант 3

// Maht.Pow возводит переменную в ту степень, которую мы укажем.
// Math.Pow(number, 3 ) возведёт в третью степень (4 в четвертую) и т.д.

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sqrt1 = Convert.ToInt32(Math.Pow(number,2));

Console.WriteLine("Число в квадрате:" + sqrt1);

// Задача 2.
// Написать программу, которая двойку возводит в степень в диапазоне от 0 до 32.
// метод Pow для вычисления значения, 

int value = 2;
for (int power = 0; power <= 32; power++)
   Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");
// Вывод в консоль: 2*2 = 4
//                  2*3 = 6 и т.д



// Задача 3.
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

// Задача 3.
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

// Задача 3.
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
   
/ // Задача 4.
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго

Console.Write("Input 1 number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2 number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.Write("1 number is a square of 2 number");
}
else
{
    Console.Write("1 number is not a square of 2 number");
}

// Задача 5.
// Напишите программу, которая будет выдавать название дня недели по заданному номеру

 Console.Write("Input number of the day: ");

 int day = Convert.ToInt32(Console.ReadLine());

 if (day < 1 || day > 7)
 {
     Console.Write("Incorrect number");
 }
 else
 {
     if (day == 1)
     {
         Console.Write("Monday");
     }
     if (day == 2)
     {
         Console.Write("Tuesday");
     }
 }


// Задача 6 
// Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

 Console.Write("Введите число: ");
 int N = Convert.ToInt32(Console.ReadLine());
 int B = -N;
 while (B <= N)
 {
     Console.Write(B + " ");
     B++; // B = B + 1 аналогично B += 1 
 }
 // Например вводим число 5, на выходе получаем:
 // -5,-4,-3,-2,-1,0,1,2,3,4,5


// Задача 7
// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int y = num % 10;

Console.WriteLine(y);


//Задача 7 Вариант 2
  // Написать программму, которая на вход принимант трёхзначное число,
  // а на выходе показывает последнюю цифру этого числа. 

Console.Write("Введите трёхзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <= 999)
{
    Console.Write("Последняя цифра :" + Math.Abs (num) % 10);
}
else
{
    Console.Write("Введённое число не трёхзначное");
}
  




//Задача 8
   //Check even or odd number (Проверить четное или нечетное число) 
    
  
    // Number which is divisible by 2 is known as Even number   
    // Number which is not divisible by 2 is known as Odd number 
    //Число, которое делится на 2, называется четным числом   
    // Число, которое не делится на 2, называется нечетным числом  

    Console.Write("Enter the number: ");  
    int number = Convert.ToInt32(Console.ReadLine());  
    if (number % 2 == 0) // check number after division is zero 
     // проверочное число после деления равно нулю
    {                             // четное число
        Console.Write(number + " is Even Number"); // If divisible by number 
         // Если делится на число
    }  
    else  
    {                            //нечётное число
        Console.Write(number + " is Odd number"); // if not divisble by number  
        // Если не делиться на число
    }  



// Задача 9
 // Prime numbers are numbers divisible by 1 and itself. 
  // Простые числа — это числа, которые делятся на 1 и на себя. 
 {
    Console.Write("Enter the number: ");  
    int number = Convert.ToInt32(Console.ReadLine());  
    int i, m = 0, count = 0;  
    m =  number / 2;                         //число / 2;       
    for (i = 2; i <= m; i++)            // check number is divisible by any another number  
                                         // контрольное число делится на любое другое число
    {  
        if (number % i == 0)                  // If number is divisible by another number  
                                             // Если число делится на другое число
        {  
            count = 1;                       // reassign the count to 1  
            break;                              // break the for loop  
                                                // переназначить счетчик на 1  
                                                 // прерываем цикл for  

        }  
    }  
    if (number > 1 && count == 0)                   // number should be greater than 1.  
                                                 // число должно быть больше 1.
    {  
        Console.Write(number + " is prime number");  // Простое число 
    }  
    else  
    {  
        Console.Write(number + " is non prime number");  //Не простое число
    }  
}    

// Задача 2 Семинар 1
  // Написать программу, которая на вход принимает два числа 
  // и выдаёт какое число больше, а какое меньше.

  Console.Write("Enter numberA :");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter numberB:");
  int numberB = Convert.ToInt32(Console.ReadLine());

  if (numberA > numberB)
  {
     Console.WriteLine("A more B");
  }  
  else if (numberA < numberB)   // сочетание: else if является продолжением проверки if.
  {
    Console.WriteLine("B more A");
  }
else
{
    Console.WriteLine(" A equals B");
}


    