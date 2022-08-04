using Day19_UserRegistration;

Patterns patterns = new Patterns();
Console.WriteLine("\nEnter minimum 8 characters");
string rule1 = Console.ReadLine();

//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
    
if (patterns.validateString(rule1))
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");