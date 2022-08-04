using Day19_UserRegistration;

Patterns patterns = new Patterns();
Console.WriteLine("\nEnter Email");
string email = Console.ReadLine();

//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
    
if (patterns.validateString(email))
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");