using DataAccess.DAO.UserDao.Imp;
using Dtos;
using Entities.View;
using Services.UserService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserDao _userDao;

        public UserService(IUserDao userDao)
        {
            _userDao = userDao;
        }


        public async Task<ResponseUserDto> LoginUserService(RequestUserDto requestUserDto)
        {
            return  await _userDao.LoginUser(requestUserDto);
        }

        public async Task<ResponseUserDto> RegisterUserService(RequestUserDto requestUserDto)
        {
            return await _userDao.RegisterUser(requestUserDto);
        }

    }
}
