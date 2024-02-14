
using Dtos;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.UserDao.Imp
{
    public interface IUserDao
    {
        // registrar un usuario
        Task<ResponseUserDto> RegisterUser(RequestUserDto requestUserDto);

        //login Usuario

        Task<ResponseUserDto> LoginUser(RequestUserDto requestUserDto);

    }
}
