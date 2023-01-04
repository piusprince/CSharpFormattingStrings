// See https://aka.ms/new-console-template for more information

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
    );

Console.WriteLine(formatted);

Console.WriteLine();    

// Formatting and Making tables
string nameField = "Names";
int nameCount = 20;
string accountsCreated = "Accounts";
int accounts = 50;

Console.WriteLine(
    format: "{0, -10}{1,6}",
    arg0: "Name",
    arg1: "Count"
    );

Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: nameField,
    arg1: nameCount);

Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: accountsCreated,
    arg1: accounts);