using ELIXIRDEPOT.DATA.JWT.AUTHENTICATION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIXIRDEPOT.DATA.CORE.ICONFIGURATION
{
    public interface IUserService
    {

        AuthenticateResponse Authenticate(AuthenticateRequest request);
        Task<bool> NewPassword(AutenticateNewPassword newpassword);

    }
}
