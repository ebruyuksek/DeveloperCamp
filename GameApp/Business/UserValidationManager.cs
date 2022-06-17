using GameApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Business
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.Name == "Ebru" && user.IdentityNumber == "123456789")
            {
                Console.WriteLine("Doğrulama başarılı.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
