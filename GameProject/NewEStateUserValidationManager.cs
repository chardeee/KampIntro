using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}// eğer yeni bir sistem gelirseprogram.csye git 9.satırın son paragrafını newstateuservalidationmanager yap
