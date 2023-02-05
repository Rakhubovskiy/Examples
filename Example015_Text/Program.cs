// Работа с текстом
// Дан тескт. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к", заменить на большие "К"
// а большие буквы "С", заменить на маленькие"с"
// Ясна ли задача?

string text = "- Я думаю, - скзал князь, улыбаясь, - что, "
            + "ежели бы вас послали  вместо нашего милого  Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 1; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
