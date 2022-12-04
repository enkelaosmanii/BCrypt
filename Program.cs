using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
      {
        var password = "enkela@123";
        Console.Writeline("Working with bcrypt hashing");
        var hastPassword = HashPassword(password);

        var verifyPassword = Hashing.ValidatePassword(password, hastPassword);
       }
    }
}

