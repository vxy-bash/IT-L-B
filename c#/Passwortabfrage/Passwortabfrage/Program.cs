using System;

public class Program
{
    static void Main(string[] args)
    {
        var security = new Security();

        Console.Write("Benutzer-ID: ");
        if (!int.TryParse(Console.ReadLine(), out int userId))
        {
            Console.WriteLine("Ungültige Benutzer-ID");
            return;
        }

        Console.Write("Passwort: ");
        string inputPassword = Console.ReadLine() ?? string.Empty;

        security.CheckPassword(inputPassword, userId);
    }
}

public class Security 
{
    private readonly string[] passwords = new string[] { "admin", "admin123" };

    public void CheckPassword(string inputPassword, int userId)
    {
        if (userId >= 0 && userId < passwords.Length)
        {
            if (inputPassword == passwords[userId])
            {
                Console.WriteLine("Passwort korrekt");
            }
            else
            {
                Console.WriteLine("Falsches Passwort");
            }
        }
        else
        {
            Console.WriteLine("Ungültige Benutzer-ID");
        }
    }
}

public class User
{
    public Security security = new Security();
    private string username = "admin";
    public int userid = 0; 
    private string password = "admin123";
}