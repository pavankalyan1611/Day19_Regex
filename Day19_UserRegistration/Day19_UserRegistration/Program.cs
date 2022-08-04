using Day19_UserRegistration;

Patterns patterns = new Patterns();
Console.WriteLine("\nEnter Country code follow by space and 10 digit number");
string mobileno = Console.ReadLine();

//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
    
if (patterns.validateString(mobileno))
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");