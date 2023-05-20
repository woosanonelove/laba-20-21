/*Вычислить сумму кодов всех символов, которые в цикле
вводятся с клавиатуры до нажатия на клавишу Esc.*/

List<char> Chars = new List<char>();
ConsoleKeyInfo KeyInfo = new ConsoleKeyInfo(' ', ConsoleKey.Backspace, false, false, false);
int plus = 0; 

while (true)
{
    while (true)
    {
        Console.Write($"{(Chars.Count > 0 ? "\r\n" : string.Empty)}Введите {Chars.Count + 1 } символ: ");
        KeyInfo = Console.ReadKey();
        if (KeyInfo.Key != ConsoleKey.Escape) Chars.Add(KeyInfo.KeyChar);
        break;
    }
    if (KeyInfo.Key == ConsoleKey.Escape) break;
}

foreach (char c in Chars) plus += c; 
Console.WriteLine($"\r\n>>> Сумма всех символов равна: {plus}");