using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    public interface IUser<T>
    {
        void CreateUser(T entity);
        void UpdateUser();
        void DeleteUser();
        void LogIn(T entity);
    }
}
