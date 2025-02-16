/**
 * 12. Trade Commissions
 */

//Напишете конзолна програма, която чете име на град (стринг) и 
//обем на продажби (реално число) ,въведени от потребителя, 
//и изчислява и извежда размера на търговската комисионна според горната таблица.

string townName = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double commissionPercentage = 0;

// Град    0 ≤ s ≤ 500 |	500 < s ≤ 1 000 | 1 000 < s ≤ 10 000 | s > 10 000
// Sofia	      5%	          7%	              8%	          12%
// Varna	     4.5%            7.5%	              10%	          13%
// Plovdiv	     5.5%	          8%	              12%	         14.5%

switch (townName)
{
    case "Sofia":
        if (sales >= 0 && sales <= 500)
        {
            commissionPercentage = 0.05;
        }
        else if (sales > 500 && sales <= 1000)
        {
            commissionPercentage = 0.07;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            commissionPercentage = 0.08;
        }
        else if (sales > 10000)
        {
            commissionPercentage = 0.12;
        }
        else
        {
            Console.WriteLine("error");
            Environment.Exit(0);
        }
        break;
    case "Plovdiv":
        if (sales >= 0 && sales <= 500)
        {
            commissionPercentage = 0.055;
        }
        else if (sales > 500 && sales <= 1000)
        {
            commissionPercentage = 0.08;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            commissionPercentage = 0.12;
        }
        else if (sales > 10000)
        {
            commissionPercentage = 0.145;
        }
        else
        {
            Console.WriteLine("error");
            Environment.Exit(0);
        }
        break;
    case "Varna":
        if (sales >= 0 && sales <= 500)
        {
            commissionPercentage = 0.045;
        }
        else if (sales > 500 && sales <= 1000)
        {
            commissionPercentage = 0.075;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            commissionPercentage = 0.1;
        }
        else if (sales > 10000)
        {
            commissionPercentage = 0.13;
        }
        else
        {
            Console.WriteLine("error");
            Environment.Exit(0);
        }
        break;
    default:
        Console.WriteLine("error");
        Environment.Exit(0);
    break;
}

//Резултатът да се изведе форматиран до 2 цифри след десетичната точка. 
//При невалиден град или обем на продажбите (отрицателно число) да се отпечата "error". 

Console.WriteLine($"{sales * commissionPercentage:F2}");