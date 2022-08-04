using Day19_UserRegistration;

Patterns patterns = new Patterns();
Console.WriteLine("\nEnter Password");
string sampleEmails = Console.ReadLine();

//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
    
if (patterns.validateString(sampleEmails))
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");