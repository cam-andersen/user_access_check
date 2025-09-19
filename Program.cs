//Activity 14. This tasks rely on activity 13 which is created in a seprate cs.file
//The task is about asking and checking the inputs and return a given answer based on the check/valiadation.

//We start by asking the user for inputs. These inputs are given from activity 14. This inputs must be the username:
Console.Write("Enter username: ");
string username = Console.ReadLine();

//Then we ask for input for the password:
Console.Write("Enter password: ");
string password = Console.ReadLine();

//Lastly, the input asked is the userId:
Console.Write("Enter user ID: ");
uint userId = uint.Parse(Console.ReadLine());

//The Boolean expressions created in activity 13 are inserted in this activity. As we have to check if the 
//username and password are valid or not valid, I insert the previous Boolean Expressions that were created in 
//activity 13:
//1:
bool userIsAdmin = userId > 65536;
//2:
bool usernameValid = username.Length >= 3;
//3:
bool passwordHasSpecial = password.Contains('$') || password.Contains('|') || password.Contains('@');
//4:
bool passwordLengthValid = userIsAdmin ? password.Length >= 20 : password.Length >= 16;

//In addition to validating if the username and password are the valid, we must ensure that the password is valid and
//fulfills the Boolean Expressions number 3 and 4 that are rules set for the password. 
bool passwordValid = passwordHasSpecial && passwordLengthValid;

//Now we have to determine whether the username and password are valid. This will be done by an if-else command as 
//the system must return one message if valid and else if not valid

//If the username and password is both valid, then:
if (usernameValid && passwordValid)
{
    //If both are valid, then the message should be "Both username and password are valid"
    Console.WriteLine("\n Both username and password are valid.");
    
    //Checks if the user is admin, because the boolean expression 1 is a rule for the user. If admin, then the message
    //will "role: administrator" is printed otherwise "role: user" is shown.
    if (userIsAdmin)
    {
        Console.WriteLine("Role: Administrator");
    }
    else
    {
        Console.WriteLine("Role: User");
    }
}

//If the username or the password is invalid then print "Invalid input"
else
{
    Console.WriteLine("\n Invalid input:");

    //Checks if the username is valid by its lenght (bool number 2)
    if (!usernameValid)
    {
        Console.WriteLine("- Username must have at least 3 characters.");
    }
    
    //Checks if the password is valid by its characters (bool number 3)
    if (!passwordHasSpecial)
    {
        Console.WriteLine("- Password must contain at least one of $, |, @.");
    }
    
    //Checks if the password is valid by its length (bool number 4). If it is an admin, then the password must be more
    //than 20 characters, otherwise it must be more than 16 characters for user. There will be printed two different
    //messages depending on if the role is user or admin.
    if (!passwordLengthValid)
    {
        if (userIsAdmin)
        {
            Console.WriteLine("- Password must be at least 20 characters long for an admin.");
        }
        else
        {
            Console.WriteLine("- Password must be at least 16 characters long for a non-admin.");
        }
    }
}