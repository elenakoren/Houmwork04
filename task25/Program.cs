/*Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
3, 5-> 243 (39)
2,4->16
*/

Console.WriteLine("Введите число A");
string numberAStr=Console.ReadLine();

Console.WriteLine("Введите числo B");
string numberBStr=Console.ReadLine();

int numberA = Convert.ToInt32(numberAStr);
int numberB = Convert.ToInt32(numberBStr);

int result=numberA;

for (int i=2; i<=numberB; i++)
{
     result=result*numberA;
}
Console.WriteLine($"{result}");
