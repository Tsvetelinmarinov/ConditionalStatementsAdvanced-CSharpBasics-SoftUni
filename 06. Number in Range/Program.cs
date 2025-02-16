/**
 * 06. Number in Range
 */

//Да се напише програма, която проверява дали въведеното от потребителя число е
//в интервала [-100, 100] и е различно от 0 и извежда "Yes", ако отговаря на условията,
//или "No" ако е извън тях.

int inputStream = int.Parse(Console.ReadLine());

bool InRange = inputStream >= -100 && inputStream <= 100 && inputStream != 0;

if (InRange)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}