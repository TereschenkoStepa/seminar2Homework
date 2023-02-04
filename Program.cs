/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/*int SecondNumber(int InCenter)
{
    int result = ((InCenter / 10) % 10);
    return result;
}
int num = new Random().Next(100, 1000);

int newNum = SecondNumber(num);
Console.WriteLine($"new version of {num} is {newNum}");*/

//--------------------------------------------------------------
/*Задача 13. Напишите программу, которая выводит третью цифру заданного числа.

645 -> 5

32679 -> 6

21 -> -1 */

/*int ThirdNumber(int number)
{
    int result = 0;
    if (number < 100)
    {
        Console.WriteLine("-1");
    }
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}

int num = new Random().Next();

int newNum = ThirdNumber(num);
Console.WriteLine($"new version of {num} is {newNum}"); */

//-----------------------------------------------------------

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет */


/*int num = new Random().Next(1, 8);


{
    int result = num;
    if (num > 5)
    {
        Console.WriteLine($"{num}-> Да");
    }
    else
    {
        Console.WriteLine($"{num}->нет");
    }
}
*/



