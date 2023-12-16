// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A ".ToLower().Trim());
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");


// string value1 = " a";
// string value2 = "A ";

// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


// Console.WriteLine("a" != "a");
// Console.WriteLine("A" != "a");
// Console.WriteLine(1 != 2);

// string myValue = "a";

// Console.WriteLine(myValue != "a");


// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("cow"));

// int a = 7;
// int b = 6;

// Console.WriteLine( a != b);

// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2);


//  Conditional Operator Basic Syntax ****

// int discount = saleAmount > 1000 ? 100: 50;

// int saleAmount = 1001;

// // int discount = saleAmount > 1000 ? 100:50;



// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100: 50)}");


// Random rnd = new Random();

// int value = rnd.Next(1,3);


// string headsTails = value % 2 == 0 ? "heads": "tails";

// Console.WriteLine(headsTails);

string permission = "Admin|Manager";
int level = 500;


if(permission.Contains("Admin"))
{
    if(level > 55)
    {
        Console.WriteLine("Welcome, Super Admin User:");
    } else if (level <= 55)
    {
        Console.WriteLine("Welcome, Admin User.");
    }
} else if (permission.Contains("Manager"))
{
    if(level > 20)
    {
        Console.WriteLine("Contact Admin For Access");
    } else if (level < 20)
    {
        Console.WriteLine("You Do Not Have Sufficient Privligies! Contact Admin For Help");
    }
} else{
    Console.WriteLine("You Do Not Have Privliges");
}



















