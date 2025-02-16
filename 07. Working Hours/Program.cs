/**
 * 07. Working Hours
 */

//Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) - въведени
//от потребителя и проверява дали офисът на фирма е отворен, като работното време на офисът
//е от 10-18 часа, от понеделник до събота включително

int visitionHour = int.Parse(Console.ReadLine());
string visitionDay = Console.ReadLine();

bool isOpen = (
visitionDay == "Monday" 
|| 
visitionDay == "Tuesday" 
||
visitionDay == "Wednesday" 
||
visitionDay == "Thursday" 
|| 
visitionDay == "Friday" 
||
visitionDay == "Saturday"
) && visitionHour >= 10 && visitionHour <= 18;
    
if (isOpen)
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}