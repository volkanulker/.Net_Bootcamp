using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 2000 && gamer.FirstName == "Volkan"
                && gamer.LastName == "Ülker" && gamer.IdentityNumber == 01234567910 )
            {
                return true;

            }
            else { return false; }
        }
    }
}
