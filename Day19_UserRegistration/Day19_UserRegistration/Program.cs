using Day19_UserRegistration;

Patterns patterns = new Patterns();
Console.WriteLine("\nEnter Last Name");
string lastName = Console.ReadLine();
//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
if (patterns.validateString(lastName))
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");