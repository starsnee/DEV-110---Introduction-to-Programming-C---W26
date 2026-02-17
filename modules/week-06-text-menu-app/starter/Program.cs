/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Rin Peralez
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=',48);
        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);


        int choice = 0;
        string menuDivider = "+------------------------------------------------+";
        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        {
            while (choice != 6) {
                Console.WriteLine(menuDivider);
                Console.WriteLine("| 1) Greeting Card                               |");
                Console.WriteLine("| 2) Name Tag Formatter               |");
                Console.WriteLine("| 3) Phrase Analyzer                      |");
                Console.WriteLine("| 4) Fancy Receipt Line                      |");
                Console.WriteLine("| 5) Menu Banner Builder                      |");
                Console.WriteLine("| 6) Exit                              |");
                Console.WriteLine(menuDivider);

            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);
            switch (choice) {
                case 1:
                    Console.WriteLine("You chose Greeting Card!");
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a short message: ");
                    string message = Console.ReadLine();
                    Console.WriteLine(menuDivider);
                    Console.WriteLine("Greeting Card");
                    string trimmedName = name.Trim();
                    string uppercaseName = trimmedName.ToUpper();
                    string greeting = $"Hello, {uppercaseName}!";
                    Console.WriteLine(greeting);
                    Console.WriteLine($"Nice to meet you, {uppercaseName}.");
                    Console.WriteLine($"Message: {message}");
                    Console.WriteLine(menuDivider);
                    break;
                case 2:
                    Console.WriteLine("You chose Name Tag Formatter!");
                    Console.WriteLine("Enter first name: ");
                    string firstName =Console.ReadLine();
                    Console.WriteLine("Enter last name: ");
                    string lastName = Console.ReadLine();
                    string fullName = $"{firstName} {lastName}";
                    string initials = $"{firstName[0]}{lastName[0]}";
                    string lowercaseName = fullName.ToLower();
                    Console.WriteLine(menuDivider);
                    Console.WriteLine("Name Tag Formatter");
                    Console.WriteLine($"Name Tag: [{fullName}]");
                    Console.WriteLine($"Initials: {initials}");
                    Console.WriteLine($"Lowercase: {lowercaseName}");
                    break;
                case 3:
                    Console.WriteLine("You chose Phrase Analyzer!");
                    Console.WriteLine("Enter a phrase: ");
                    string phrase = Console.ReadLine();
                    string trimmedPhrase = phrase.Trim();
                    int length = trimmedPhrase.Length;
                    bool containsA = trimmedPhrase.ToLower().Contains("a");
                    string dashedPhrase = trimmedPhrase.Replace(" ", "-");
                    string[] words = trimmedPhrase.Split(' ');
                    string commaSeparatedWords = string.Join(", ", words);
                    Console.WriteLine(menuDivider);
                    Console.WriteLine("Phrase Analyzer");
                    Console.WriteLine($"Length: {length}");
                    Console.WriteLine($"Contains 'a': {containsA}");
                    Console.WriteLine($"Dashed: {dashedPhrase}");
                    Console.WriteLine($"Words: {commaSeparatedWords}");
                    Console.WriteLine(menuDivider);
                    break;
                case 4:
                    Console.WriteLine("Fancy Receipt Line");
                    Console.WriteLine("Enter item name: ");
                    string itemName = Console.ReadLine();
                    Console.WriteLine("Enter price: ");
                    double price = double.Parse(Console.ReadLine());
                    int quantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);
                    double total = price * quantity;
                    Console.WriteLine(menuDivider);
                    Console.WriteLine("Fancy Receipt Line");
                    Console.WriteLine("Item: {0, -20} | Quantity: {1, 4} | Total: {2, 9:C2}", "ITEM", "QTY", "TOTAL");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("{0, -20} {1, 4} {2, 9:C2}", itemName, quantity, total);
                    Console.WriteLine(menuDivider);
                    break;
                case 5:
                    Console.WriteLine("You chose Menu Banner Builder!");
                    Console.WriteLine("Enter a title: ");
                    string bannerTitle = Console.ReadLine();
                    Console.WriteLine("Enter a subtitle: ");
                    string bannerSubtitle = Console.ReadLine();
                    Console.WriteLine("Enter width (30-60): ");
                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);
                    Console.WriteLine(menuDivider);
                    Console.WriteLine("Menu Banner Builder");
                    string border = new string('=', width);
                    string centeredTitle = bannerTitle.PadLeft((width + bannerTitle.Length) / 2);
                    string centeredSubtitle = bannerSubtitle.PadLeft((width + bannerSubtitle.Length) / 2);
                    Console.WriteLine(border);
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine(centeredSubtitle);
                    Console.WriteLine(border);
                    break;
                case 6:
                    Console.WriteLine("Exit with String Analysis");
                    Console.Write("Enter a closing word: ");
                    string closingWord = Console.ReadLine();
                    bool isGoodbye = closingWord.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                    Console.WriteLine($"Is the word 'goodbye'? {isGoodbye}");
                    string firstThree = "";
                    if (closingWord.Length >= 3)
                    {
                        firstThree = closingWord.Substring(0, 3);
                        Console.WriteLine($"First 3 characters: {firstThree}");
                    }
                    else
                    {
                        Console.WriteLine("First 3 characters: (Word is too short)");
                    }
                    bool endsWithExcl = closingWord.EndsWith("!");
                    Console.WriteLine($"Ends with '!'? {endsWithExcl}");
                    int spaceIndex = closingWord.IndexOf(" ");
                    Console.WriteLine($"Position of first space: {spaceIndex}");
                    Console.WriteLine("Goodbye!");
                break;
                default:
                    Console.Write("Invalid choice");
                break;
                        }
            }

        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;
        do {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out value);
        } while (!isValid || value < min || value > max);
        return value;
    }

    private static double ReadDouble(string prompt)
    {
        double value;
        bool isValid;
        do {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = double.TryParse(input, out value);
        } while (!isValid);
        return value;
    }
}
