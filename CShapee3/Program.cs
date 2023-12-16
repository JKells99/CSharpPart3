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

// string permission = "Admin|Manager";
// int level = 500;


// if(permission.Contains("Admin"))
// {
//     if(level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin User:");
//     } else if (level <= 55)
//     {
//         Console.WriteLine("Welcome, Admin User.");
//     }
// } else if (permission.Contains("Manager"))
// {
//     if(level > 20)
//     {
//         Console.WriteLine("Contact Admin For Access");
//     } else if (level < 20)
//     {
//         Console.WriteLine("You Do Not Have Sufficient Privligies! Contact Admin For Help");
//     }
// } else{
//     Console.WriteLine("You Do Not Have Privliges");
// }


// Exercise - Code blocks and variable scope


// bool flag = true;
// int value = 0;
// if(flag){
//     value = 10;
//     Console.WriteLine($"Inside of code block value: {value}");
// }
// Console.WriteLine($"Outside Of Code Block: {value}");


// int number1 = 5;

// if(number1 > 0)
// {
//     int number2 = 6;
//     number1 = number1 + number2;
// }

// Console.WriteLine(number1);


// Exercise - Remove code blocks from if statements


// bool flag = true;
// if (flag) Console.WriteLine(flag);

// string name = "steve";

// if(name == "bob") 

//     Console.WriteLine("Found Bob!");

// else if(name == "steve") 

//     Console.WriteLine("Found Steve");
// else 
//     Console.WriteLine("Found Chuck!");



// ****** CHALLANGE ***********

// int[] numbers = {4,8,15,16,23,42};

// int total = 0;

// bool found = false;

// foreach (int number in numbers)
// {

//     total += number;

//     if(number == 42)
//     {
//         found = true;

//     }

    
// }


// if(found)
// {
//     Console.WriteLine("42 Is In The Set");
// }

// Console.WriteLine($"Total: {total}");
























