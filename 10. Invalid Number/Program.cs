/**
 * 10. Invalid Number
 */

//Дадено число е валидно, ако е в диапазона [100…200] или е 0.
//Да се напише програма, която чете цяло число, въведено от потребителя,
//и печата "invalid" ако въведеното число не е валидно. 

int inputStream = int.Parse(Console.ReadLine());

bool isValid = (inputStream >= 100 && inputStream <= 200) || inputStream == 0;

if (!isValid)
{
    Console.WriteLine("invalid");
}