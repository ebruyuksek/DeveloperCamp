using GameApp.Business;
using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userManager = new UserManager(new UserValidationManager());
            var user = new User();
            Console.WriteLine(" 1.Kayıt Ol \n 2.Giriş Yap");
            var output = Console.ReadLine();
            var isNewUser = output == "1" ? true : output == "2" ? false : true;

            if (isNewUser)
            {
                Console.WriteLine("Kaydolmak için isminizi giriniz:");
                user.Name = Console.ReadLine();
                userManager.CreateUser(user);
            }
            else if (!isNewUser)
            {
                Console.WriteLine("İsim ve tc no giriniz");
                user.Name = Console.ReadLine();
                user.IdentityNumber = Console.ReadLine();
                userManager.LogIn(user);
            }
                



            Console.ReadLine(); 
        }
    }
}
