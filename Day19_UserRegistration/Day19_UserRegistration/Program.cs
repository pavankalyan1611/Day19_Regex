using Day19_UserRegistration;

Patterns patterns = new Patterns();
Console.WriteLine("\nEnter ");
string rule = Console.ReadLine();

//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
    
if (patterns.validateString(rule))
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");