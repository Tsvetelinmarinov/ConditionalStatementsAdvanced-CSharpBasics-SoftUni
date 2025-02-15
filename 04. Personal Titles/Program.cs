/**
 * 04. Personal Titles
 */

// Да се напише конзолна програма, която прочита възраст (реално число) и пол ('m' или 'f'),
// въведени от потребителя, и отпечатва обръщение измежду следните:
//•	"Mr." – мъж(пол 'm') на 16 или повече години
//•	"Master" – момче (пол 'm') под 16 години
//•	"Ms." – жена (пол 'f') на 16 или повече години
//•	"Miss" – момиче (пол 'f') под 16 години

double age = double.Parse(Console.ReadLine());
char sex = char.Parse(Console.ReadLine().ToLower());

string title = "";

switch (sex)
{
    case 'm':
        if (age < 16)
        {
            title = "Master";
        }
        else
        {
            title = "Mr.";
            break;
        }
        break;
    case 'f':
        if (age < 16)
        {
            title = "Miss";
        }
        else
        {
            title = "Ms.";
        }
        break;
    default:
        title = "";
    break;
}

Console.WriteLine(title);