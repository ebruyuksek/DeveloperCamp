using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Interfaces
{
    public interface IUserValidationService
    {
        bool Validate(User user);
    }
}
