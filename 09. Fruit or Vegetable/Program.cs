/**
 * 09. Fruit or Vegetable
 */

//Да се напише програма, която чете име на продукт, въведено от потребителя, и проверява дали е плод 
//или зеленчук.

//•	Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
//•	Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
//•	Всички останали са "unknown"

//Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт.

string productType = Console.ReadLine();

string output = productType switch
{
    "banana" or "apple" or "kiwi" or "cherry" or "lemon" or "grapes" => "fruit",
    "tomato" or "cucumber" or "pepper" or "carrot" => "vegetable",
    _ => "unknown"
};

//banana fruit		apple	fruit		tomato	vegetable		water	unknown

Console.WriteLine(output);