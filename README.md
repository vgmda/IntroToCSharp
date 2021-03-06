# Introduction to C# (Basics) using VS
> I wanted to get familiar with C# basics as well as the functionality of Visual Studio. The purpose of learning C# is to be able to build/design .NET applications. It is widely used in web development, mobile app development, windows applications and backend services. I've had past experience with C and C# in the past (used Unity), but I would like to revise the basics. The skills and knowledge gained will be applied to personal projects and the workplace.
### Topics covered:


1. Variables
    - Displaying basic outputs through Console.WriteLine and adding variables (string, int)
2. Data Types
    - Reviewing data types such as: int, double, long, float, string, bool, char.
3. Working With Strings
    - Working with Strings (string methods e.g .Length(), .ToUpper(), .ToLower(), .Contains() etc.)
4. Working With Numbers
    - Working with Numbers (Mathematical calculations using variables)
    - Math() methods, Math.Abs(), Math.Pow(), Math.Sqrt(), Math.Max/Min(), Math.Round()
5. Getting User Input
    - Asking user for input, printing it using Console.ReadLine() & Console.WriteLine() methods
    - Convert string input to int using Convert.ToInt32()
6. Building a Calculator
    - Use the Convert.ToDouble() method (from string to int, double, decimal etc.)
    - Output the sum of two values (Doubles) via Console.WriteLine() method
7. Building a Mad Lib
    - Reading inputs from the user using Console.ReadLine()
    - Mixing the outputs using Console.WriteLine()
8. Arrays
    - Declare arrays
    - Alter the indexes of an array
9. Methods
    - How to declare methods
    - Type of methods (Virtual method, Partial methods, Extension method, Static method, Instance method)
10. Return Statement
    - Return the arguments based on the method type
    - List the arguments in parentheses
    - Call the method inside main()
11. If Statements
    - Test the if statements results based on different bool value (true or false)
    - Comparison operators ('==', '!=', '<', '>', '<=', '>=')
12. If Statements (con't)
    - Include the GetMax method which allows to pick the biggest value out of the numbers provided
    - Within the GetMax method, create If Statements which validates the above functionality
13. Building a Better Calculator
    - Improved calculator functionality
    - Request an input from the user, this input will be the operator 
    - Using if/elif statements, check weather the operators are valid (' + ' , ' - ', ' / ', ' * ')
    - Perfrom the operation and output the results
14. Switch Statements
    - Multiway branch statement
    - Provide a condition based on different cases
    - Include the break; key word if the case is met
    - Include a default condition if none of the cases are met
15. While Loops
    - Execute code if the condition at the beginning of the while loops is true
    - For a Do-While loop, execute the code first and then check if the condition is true
16. Building a Guessing Game
    - Used the while loop to ask the user for the guess word until it matches with the secret word
    - To get rid if infinite looping, I modified the program so that the user only has 3 lives
    - If statements validated the amount of lives left and prints the corresponding message
17. For Loops
    - Implemented a for loop, looked at how to print all indexes of an array using the loop
18. Building an Exponent Method
    - Created an Exponent Method GetPow() this includes the base number and the power number
    - Used for loop to loop through powNum times until de condition is met
    - Within the loop, multiplied the base number by itself
19. 2d Arrays
    - Added a 2d array numberGrid and printed its contents using array index values
20. Comments
    - Reviewed the addition of comments using the // and /* */
21. Exception Handling
    - Acquainted myself with the exception handling methods such as try {}, catch {}, finally {}
    - Looked at different types of exceptions such as DivideByZeroException, FormatException
22. Classes & Objects
    - Each object consists of: State, Behavior and Identity
    - When an object of a class is created, the class is instantiated
    - Declared book objects which are an instance of a class
    - Created book attributes such as (title, author, pages) and assigned a corresponding piece of data
    - Displayed the individual attributes via Console.WriteLine() method
23. Constructors
    - Whenever a class is created, its constructor is called
    - A class may have multiple constructors that take different arguments
    - Constructors enable the user to set default values, limit instantiation
    - Declared a Book() constructor and passed the following attributes (title = aTitle, author = aAuthor, pages = aPages)
24. Object Methods
    - Declared a HasHonors() method which allows to check if a student fits within the validation of that method
    - This method can be called within the main() method, like this student.HasHonors()
25. Getters & Setters aka C# Properties (Get & Set)
    - Getters and setters are methods used to declare or obtain the values of variables, usually private ones
    - Private variables can only be accessed within the same class (an outside class has no access to it)
    - Within get(), I returned the rating variable to allow the user to see the rating
    - Within set(), I created an if statement which checks if the rating is within the allowed set of ratings
26. Static Class Attributes
    - Static attribute acts as a global variable for that specific class and not for individual objects
    - Static attributes can be altered within the constructor
    - It is possible to create a method for the static attribute which then can be used within the objects itself
27. Static Methods & Classes
    - Static methods allows that method to be accessed within a different class without an object attached to it
    - If a class becomes static, then we cannot create a instance of that class therefore cannot be instantiated
28. Inheritance
    - This allows to create a new class from an existing class
    - The derived class inherits the fields and methods of the base class
    - The use of virtual and override key words for methods, allows the Sub Class to override the method of a Super Class


###### *Reference: https://www.freecodecamp.org*
