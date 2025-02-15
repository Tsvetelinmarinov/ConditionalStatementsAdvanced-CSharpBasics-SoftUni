/**
 * 02. Weekend or Working Day
 */

//Напишете програма която, чете ден от седмицата (текст), на английски език - въведен от потребителя.
//Ако денят е работен отпечатва на конзолата - "Working day", ако е почивен - "Weekend".
//Ако се въведе текст различен от ден от седмицата да се отпечата - "Error".

string dayOfTheWeek = Console.ReadLine();

string dayType = "";

switch (dayOfTheWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        dayType = "Working day";
        break;
    case "Saturday":
    case "Sunday":
        dayType = "Weekend";
        break;
    default:
        dayType = "Error";
    break;
}

Console.WriteLine(dayType);