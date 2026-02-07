List<Expense> myExpenses = new List<Expense>();

Console.WriteLine("--- My Portfolio Expense Tracker ---");

while (true)
{
    Console.WriteLine("\nOptions: [1] Add Expense [2] View All [3] Exit");
    string choice = Console.ReadLine();

    if (choice == "3") break; // Exit the loop

    if (choice == "1")
    {
        Console.Write("What did you buy? ");
        string desc = Console.ReadLine();

        decimal price;
        while (true)
        {
            Console.Write("How much did it cost? ");
            string input = Console.ReadLine();

            // TryParse checks if 'input' is a number. 
            // If yes, it saves it in 'price' and returns true.
            if (decimal.TryParse(input, out price))
            {
                break; // Exit the "price loop" because the input is valid
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number (e.g., 12.50).");
            }
        }
        // --- CRASH PROTECTION END ---

        Console.Write("Category: ");
        string cat = Console.ReadLine();

        myExpenses.Add(new Expense { Description = desc, Amount = price, Category = cat });
        Console.WriteLine("Expense Added!");
    }
    else if (choice == "2")
    {
        Console.WriteLine("\n--- Your Expenses ---");
        foreach (var item in myExpenses)
        {
            Console.WriteLine($"- {item.Description}: ${item.Amount} ({item.Category})");
        }
    }
}

public class Expense
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
}