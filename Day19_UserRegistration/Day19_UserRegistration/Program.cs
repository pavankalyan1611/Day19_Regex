using Day19_UserRegistration;

Patterns patterns = new Patterns();
Console.WriteLine("Enter First Name");
string firstName = Console.ReadLine();
//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
if (patterns.validateString(firstName))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");