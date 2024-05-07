using System.Globalization;

Console.WriteLine("Введите текст:");
string[] textMass;
string text = Console.ReadLine();
textMass = text.Split(' ');
Console.WriteLine("Количество слов:");
Console.WriteLine(textMass.Length);
Console.WriteLine("Слова с заглавной буквы");
for (int i = 0;i< textMass.Length; i++)
{
    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
    textMass[i] = textInfo.ToTitleCase(textMass[i]);
    Console.WriteLine(textMass[i]);   
}
