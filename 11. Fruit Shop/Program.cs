/**
 * 11. Fruit Shop
 */

// Напишете програма, която чете от конзолата плод 
// (banana / apple / orange / grapefruit / kiwi / pineapple / grapes), 
// ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) 
// и количество (реално число) , въведени от потребителя, и пресмята цената според цените 
// от таблиците по-горе. 

string fruitType = Console.ReadLine();
string dayOfTheWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

//Магазин за плодове през работните дни работи на следните цени:
//плод banana	apple	orange	grapefruit	kiwi	pineapple	grapes
//цена	2.50	1.20	0.85	1.45	    2.70	  5.50	     3.85

//Събота и неделя магазинът работи на по-високи цени:
//плод banana	apple	orange	grapefruit	kiwi	pineapple	grapes
//цена	2.70	1.25	0.90	1.60	    3.00	  5.60	     4.20

double price = dayOfTheWeek switch
{
    "Monday" or "Tuesday" or "Wednesday" or "Thursday" or "Friday" => 
    fruitType switch
    {
        "banana" => 2.5,
        "apple" => 1.2,
        "orange" => 0.85,
        "grapefruit" => 1.45,
        "kiwi" => 2.7,
        "pineapple" => 5.5,
        "grapes" => 3.85,
        _ => 0
    },
    "Saturday" or "Sunday" => 
    fruitType switch
    {
        "banana" => 2.7,
        "apple" => 1.25,
        "orange" => 0.9,
        "grapefruit" => 1.6,
        "kiwi" => 3,
        "pineapple" => 5.6,
        "grapes" => 4.2,
        _ => 0
    },
    _ => 0,
};

//Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.
// При невалиден ден от седмицата или невалидно име на плод да се отпечата "error".

if (price == 0)
{
    Console.WriteLine("error");
    Environment.Exit(0);
}

Console.WriteLine($"{quantity * price:F2}");