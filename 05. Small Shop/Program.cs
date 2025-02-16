/**
 * 05. Small Shop
 */

//Напишете програма, която чете продукт (низ), град (низ) и количество (десетично число),
//въведени от потребителя, и пресмята и отпечатва колко струва съответното количество от 
//избрания продукт в посочения град. 

string productType = Console.ReadLine();
string town = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

//град/продукт       coffee  water	 beer  sweets	peanuts
//Sofia 	          0.50	  0.80	 1.20	1.45	 1.60
//Plovdiv	          0.40	  0.70	 1.15	1.30	 1.50
//Varna	              0.45	  0.70 	 1.10	1.35	 1.55

double productPrice = 0.0;

switch (productType)
{
    case "coffee":
        productPrice = town switch
        {
            "Sofia" => 0.5,
            "Plovdiv" => 0.4,
            "Varna" => 0.45,
            _ => 0.0
        };
        break;
    case "water":
        productPrice = town switch
        {
            "Sofia" => 0.8,
            "Plovdiv" or "Varna" => 0.7,
            _ => 0.0
        };
        break;
    case "beer":
        productPrice = town switch
        {
            "Sofia" => 1.2,
            "Plovdiv" => 1.15,
            "Varna" => 1.1,
            _ => 0.0
        };
        break;
    case "sweets":
        productPrice = town switch
        {
           "Sofia" => 1.45,
           "Plovdiv" => 1.3,
           "Varna" => 1.35,
           _ => 0.0
        };
        break;
    case "peanuts":
        productPrice = town switch
        {
            "Sofia" => 1.6,
            "Plovdiv" => 1.5,
            "Varna" => 1.55,
            _ => 0.0
        };
    break; 
}

double total = quantity * productPrice;

Console.WriteLine(total);