/**
 * 08. Cinema Ticket
 */

//Monday Tuesday	Wednesday	Thursday	Friday	Saturday	Sunday
//  12	   12	       14	       14	      12	   16	      16

string dayOfTheWeek = Console.ReadLine();

int ticketPrice = dayOfTheWeek switch
{
    "Monday" or "Tuesday" or "Friday" => 12,
    "Wednesday" or "Thursday" => 14,
    "Saturday" or "Sunday" => 16,
    _ => 0
};

//вход     изход    вход	изход	вход	изход
//Monday   12		Friday	12		Sunday	16

Console.WriteLine(ticketPrice);