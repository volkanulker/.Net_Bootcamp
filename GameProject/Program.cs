using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { 
                Id=1, BirthYear=2000, FirstName="Volkan", IdentityNumber=01234567910, LastName="Ülker"
            });
            
        }
    }
}
