if (args.Length >= 0)
{
    string colorCode = args[0];
    TrimText(colorCode);
}


void TrimText(string text)
{
    text = text.Replace("-", "");
    string color1 = text.Substring(0, 3);
    text = text.Substring(3);
    string color2 = text.Substring(0, 3);
    text = text.Substring(3);
    string color3 = text.Substring(0, 3);
    text = text.Substring(3);
    string color4 = text;
    int digit = ConvertColorToDigit(color1);
    digit *= 10;
    digit += ConvertColorToDigit(color2);
    double multiplier = GetMultiplierFromColor(color3);
    double tolerance = GetToleranceFromColor(color4);

    double resistor = digit * multiplier;

    Console.WriteLine($"{resistor} Ohm, {tolerance} %");
}

int ConvertColorToDigit(string color)
{
    switch (color)
    {
        case "Bla": return 0;
        case "Bro": return 1;
        case "Red": return 2;
        case "Ora": return 3;
        case "Yel": return 4;
        case "Gre": return 5;
        case "Blu": return 6;
        case "Vio": return 7;
        case "Gra": return 8;
        case "Whi": return 9;
        default: return -1;
    }
}

double GetMultiplierFromColor(string color)
{
    switch (color)
    {
        case "Bla": return 1;
        case "Bro": return 10;
        case "Red": return 100;
        case "Ora": return 1000;
        case "Yel": return 10000;
        case "Gre": return 100000;
        case "Blu": return 1000000;
        case "Vio": return 10000000;
        case "Gra": return 100000000;
        case "Whi": return 1000000000;
        case "Gol": return 0.1;
        case "Sil": return 0.01;
        default: return -1;
    }
}

double GetToleranceFromColor(string color)
{
    switch (color)
    {
        case "Bro": return 1;
        case "Red": return 2;
        case "Gre": return 0.50;
        case "Blu": return 0.25;
        case "Vio": return 0.1;
        case "Gra": return 0.05;
        case "Gol": return 5;
        case "Sil": return 10;
        default: return -1;
    }
}

