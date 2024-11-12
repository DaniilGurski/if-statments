internal class Program
{    private static void Main(string[] args)
    {
        // Assigment 1
        // Console.WriteLine("Enter a number: ");
        // int firstNumber = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter a second number: ");
        // int secondNumber = Convert.ToInt32(Console.ReadLine());

        // if (firstNumber > secondNumber) {
        //     Console.WriteLine($"{firstNumber} is grater than {secondNumber}");
        // } 
        // else if (secondNumber > firstNumber) {
        //     Console.WriteLine($"{secondNumber} is grater than {firstNumber}");
        // } else {
        //     Console.WriteLine($"{secondNumber} is equal to {firstNumber}");
        // }  

        // Assigment 2
        // Console.WriteLine("Enter your age: ");
        // int age = Convert.ToInt32(Console.ReadLine());

        // if (age >= 0 && age <= 12) {
        //     Console.WriteLine("White");
        // } 
        // else if (age >= 13 && age <= 18) {
        //     Console.WriteLine("Green");
        // }
        // else if (age >= 19 && age <= 25) {
        //     Console.WriteLine("Red");
        // }
        // else if (age >= 26 && age <= 99) {
        //     Console.WriteLine("Blue");
        // } else {
        //     Console.WriteLine("Invalid age")
        // }

        // Assigment 3 
        // Console.WriteLine("Enter your age: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        
        // if (age % 2 == 0) {
        //     Console.WriteLine("Even");
        // } else {
        //     Console.WriteLine("Odd");
        // }

        // Assigment 4
        Console.WriteLine("Enter a character: ");
        string? character = Console.ReadLine();

        switch(character) {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }
    }
}
