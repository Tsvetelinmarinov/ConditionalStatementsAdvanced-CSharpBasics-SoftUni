/**
 * 03. Animal Type
 */

//1.dog->mammal
//2.crocodile, tortoise, snake -> reptile
//3.	others -> unknown

//Вход  Изход
//dog	mammal
//snake	reptile
//cat	unknown

string animalType = Console.ReadLine();

string output = "";

switch (animalType)
{
    case "dog":
        output = "mammal";
        break;
    case "crocodile":
    case "tortoise":
    case "snake":
        output = "reptile";
        break;
    default:
        output = "unknown";
    break;
}

Console.WriteLine(output);