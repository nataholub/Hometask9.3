// Ви отримали рядок, який містить декілька слів, розділених комами. Ваша мета - видалити всі пробіли з цього рядка та вивести результат.

string strOriginal = "apple, pear, banana, peach";

string strWithoutSpaces = strOriginal.Replace(" ", "");

Console.WriteLine(strWithoutSpaces);
