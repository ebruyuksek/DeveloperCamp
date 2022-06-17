using GameApp.Interfaces;
using System;

namespace GameApp.Business
{
    public class UserManager : IUser<User>
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void CreateUser(User user)
        {
            Console.WriteLine( user.Name + " kullanıcısı oluşturuldu.");
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void LogIn(User user)
        {
            if (_userValidationService.Validate(user))
            Console.WriteLine( user.IdentityNumber + " kimlik nolu " + user.Name + " kullanıcısı giriş yaptı.");
            else
            {
                Console.WriteLine("Doğrulama başarısız..");
            }
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
