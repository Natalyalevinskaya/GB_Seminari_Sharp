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


///////
int value = 2;
for (int power = 0; power <= 32; power++)
   Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");



