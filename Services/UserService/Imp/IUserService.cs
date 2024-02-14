using Dtos;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.UserService.Imp
{
    public interface IUserService
    {
        // registrar un usuario
        Task<ResponseUserDto> RegisterUserService(RequestUserDto requestUserDto);

        //login Usuario

        Task<ResponseUserDto> LoginUserService(RequestUserDto requestUserDto);

    }
}
