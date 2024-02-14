using Dtos;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.UserFacade.Imp
{
    public interface IUserFacade
    {
        // registrar un usuario
        Task<ResponseUserDto> RegisterUserFacade(RequestUserDto requestUserDto);

        //login Usuario

        Task<ResponseUserDto> LoginUserFacade(RequestUserDto requestUserDto);

    }
}
