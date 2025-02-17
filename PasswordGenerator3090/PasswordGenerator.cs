using System.Numerics;
using System.Text;

/// <summary>
/// Generates a password after prompting user for certian desired
/// properties of password.
/// 
/// Author: Ian Kerr
/// Date: 2/17/25
/// For: U of U CS3090 Block Project 2
/// </summary>
class PasswordGenerator
{
    /// <summary>
    /// Generates a password of specified length and charecter type
    /// </summary>
    /// <param name="length"> Desired length of password </param>
    /// <param name="containsSpecialCharacters"> User input for desired charecters </param>
    /// <returns> Password as a string </returns>
    public static string GeneratePassword(int length, bool containsSpecialCharacters)
    {


        if (!containsSpecialCharacters)
            return generatePasswordBasic(length);
        else
            return generatePasswordAdvanced(length);


    }

    /// <summary>
    /// Checks if letter is outside range of allowed charecters
    /// </summary>
    /// <param name="letter"> ASCII value of charecter</param>
    /// <returns> True if the letter is outside the range, false if otherwise </returns>
    private static bool OutsideRange(int letter)
    {
        return (letter > 57 && letter < 65) || (letter > 91 && letter < 97);

    }

    /// <summary>
    /// Generates a password containing no special charecters of the desired length
    /// </summary>
    /// <param name="length"> Length of password </param>
    /// <returns> Generated password as a string </returns>
    private static String generatePasswordBasic(int length)
    {
        StringBuilder password = new StringBuilder();
        Random random = new Random();
        int letter;


        for (int i = 0; i < length; i++)
        {
            letter = random.Next(48, 123);
            while (OutsideRange(letter))
                letter = random.Next(48, 123);

            password.Append((char)letter);

        }

        return password.ToString();
    }

    /// <summary>
    /// Generates a password containing special charecters of the desired length
    /// </summary>
    /// <param name="length"> Length of password </param>
    /// <returns> Generated password as a string </returns>
    private static String generatePasswordAdvanced(int length)
    {
        StringBuilder password = new StringBuilder();
        Random random = new Random();
        int letter = 0;

        for (int i = 0; i < length; i++)
        {
            letter = random.Next(48, 123);
            password.Append((char)letter);

        }

        return password.ToString();
    }

    /*
     * Prompts user for desired length of password and asks if they want
     * their password to contain special charecters
     */
    public static void Main(string[] args)
    {
        int length;
        bool containsSpecialCharacters = false;

        Console.WriteLine("<<<Password Generator>>>");
        Console.WriteLine("Welcome!");
        Console.WriteLine("Please enter the desired length of your password. [1-20]");
        string lengthS = Console.ReadLine();
        length = int.Parse(lengthS);
        Console.WriteLine("Would you like your password to contain special charecters? [Y/N]");
        string input = Console.ReadLine();
        containsSpecialCharacters = input.Equals("Y");

        Console.WriteLine("Your password is: " + GeneratePassword(length, containsSpecialCharacters));

    }
}