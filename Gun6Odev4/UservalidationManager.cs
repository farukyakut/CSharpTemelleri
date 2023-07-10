using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun6Odev4
{
    public class UservalidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if ( gamer.BirthYear == 1985 && gamer.IdentityNumber == 12345 && gamer.FirstName == "Faruk" && gamer.LastName == "YAKUT")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
