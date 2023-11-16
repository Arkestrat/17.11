//zadanie4
//Console.WriteLine("Введите x не равный 0");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите y не равный 0");
//double y = Convert.ToDouble(Console.ReadLine());
//if (x == 0 ^ y == 0)
//else if (x > 0 && y > 0)
//{
//    Console.WriteLine("первая четверть");
//}
//else if (x > 0 && y < 0)
//{
//    Console.WriteLine("четвертая четверть");
//}
//else if (x < 0 && y > 0)
//{
//    Console.WriteLine("вторая четверть");
//}
//else
//{
//    Console.WriteLine("третья четверть");
//}
//zadanie5
//Console.WriteLine("Введите x не равный 0");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите y не равный 0");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите z не равный 0");
//double z = Convert.ToDouble(Console.ReadLine());
//if (x == 0 ^ y == 0 ^ z == 0)
//else if (x > 0 && y > 0 && z > 0)
//{
//    Console.WriteLine("первая");
//}
//else if (x < 0 && y > 0 && z > 0)
//{
//    Console.WriteLine("вторая");
//}
//else if (x < 0 && y < 0 && z > 0)
//{
//    Console.WriteLine("третья");
//}
//else if (x > 0 && y < 0 && z > 0)
//{
//    Console.WriteLine("четвертое");
//}
//else if (x > 0 && y > 0 && z < 0)
//{
//    Console.WriteLine("пятое");
//}
//else if (x < 0 && y > 0 && z < 0)
//{
//    Console.WriteLine("шестое");
//}
//else if (x < 0 && y < 0 && z < 0)
//{
//    Console.WriteLine("седьмое");
//}
//else
//{
//    Console.WriteLine("восьмое");
//}
//zadanie4.22str
//Console.WriteLine("Введите a");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите y");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите e");
//double e = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите u");
//double u = Convert.ToDouble(Console.ReadLine());
//if (Math.Abs(a - e) == 2 && Math.Abs(y - u) == 1 || Math.Abs(a - e) == 1 && Math.Abs(y - u) == 2)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}
//zadanie3
//Console.Write("Введите первое целое число");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите второе целое число");
//int y = int.Parse(Console.ReadLine());
//Console.Write("Введите третье целое число");
//int e = int.Parse(Console.ReadLine());
//if (a > b)
//{
//    int temp = a;
//    a = y;
//    y = temp;
//}
//if (y > e)
//{
//    int temp = y;
//    y = e;
//    e = temp;
//}
//if (a > y)
//{
//    int temp = a;
//    a = y;
//    y = temp;
//}
//Console.WriteLine($"Числа в порядке неубывания = {a}{b}{c}");