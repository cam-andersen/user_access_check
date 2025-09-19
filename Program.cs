//Activity 13

//I want to start by by writing the four sentences as Boolean expressions, but as they contain variables that are
//not declared, it will cause problems when running the codes. First, I then uses the inputs given in the activity to
//declare. I do this by adding values to the strings and uint:
string username = "s235660";
string password = "secret";
uint userId = 235660; 

//First sentence: The user is an administrator if the user id is larger than 65536
bool userIsAdmin = userId > 65536;

//Second sentence: the username has at least three characters.
bool usernameValid = username.Length >= 3;

//Third sentence: password must contain at least one of the characters $, | and @.
bool passwordHasSpecial = password.Contains('$') || password.Contains('|') || password.Contains('@');

//Fourth sentence: password must be at least 20 characters long for an admin and 16 characters long for a non-admin
bool passwordLengthValid = userIsAdmin ? password.Length >= 20 : password.Length >= 16;


//I now have to make sure that the outputs are shown as given in the activity. I will do this by adding 
//Console.WriteLine as it will write the output in the console. 
Console.WriteLine($"User is admin: {userIsAdmin}");
Console.WriteLine($"Username is valid: {usernameValid}");
Console.WriteLine($"Password has special character: {passwordHasSpecial}");
Console.WriteLine($"Password length is valid: {passwordLengthValid}");

//When running the code with my given values, I will receive the following outputs:
//User is admin: true - because my userId is greater than 65536
//Username is valid: true - because my username is more than three characters
//Password has special character: false - because my password does not contain $, | or @
//Password length is valid: false - becayse my lenght is not 20 characters