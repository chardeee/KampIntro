using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2002 && gamer.FirstName =="İsmail" && 
                gamer.LastName =="Serin" && gamer.IdentityNumber ==12345)
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
