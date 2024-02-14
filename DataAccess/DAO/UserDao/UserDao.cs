using DataAccess.DAO.UserDao.Imp;
using DataAccess.Utils;
using Dtos;
using Entities.Context;
using Entities.Models;
using Entities.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Security.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.UserDao
{
    public class UserDao : IUserDao
    {
        private readonly IDataBaseContext _databaseContext;
        private readonly UserManager<Cliente> _userManager;
        private readonly SignInManager<Cliente> _signInManager;
        private readonly DataBaseContext _dataBaseContext2;
        private readonly IJwtGenerador _jwtGenerador;
        private readonly IPasswordHasher<Cliente> _passwordHasher;

        public UserDao(IDataBaseContext databaseContext, UserManager<Cliente> userManager, IJwtGenerador jwtGenerador, DataBaseContext dataBaseContext2, SignInManager<Cliente> signInManager, IPasswordHasher<Cliente> passwordHasher)
        {
            _databaseContext = databaseContext;
            _userManager = userManager;
            _jwtGenerador = jwtGenerador;
            _dataBaseContext2 = dataBaseContext2;
            _signInManager = signInManager;
            _passwordHasher = passwordHasher;
        }
        public Task<bool> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticuloTiendaViewModel>> GetArticulosUser()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseUserDto> LoginUser(RequestUserDto requestUserDto)
        {
            var usuario = await _userManager.FindByEmailAsync(requestUserDto.Email);
            if (usuario == null)
            {
                throw new ManejadorExcepcion(HttpStatusCode.Unauthorized);
            }

            var resultado = await _signInManager.CheckPasswordSignInAsync(usuario, requestUserDto.Password, false);

            if (resultado.Succeeded)
            {          
                    return new ResponseUserDto
                    {
                        Nombre = usuario.Nombre,
                        Token = _jwtGenerador.CrearToken(usuario),
                        Username = usuario.UserName,
                        Email = usuario.Email,
                    };
            }
            throw new ManejadorExcepcion(HttpStatusCode.Unauthorized);
        }

        public async Task<ResponseUserDto> RegisterUser(RequestUserDto requestUserDto)
        {
            var existe = await _dataBaseContext2.Users.Where(x => x.Email == requestUserDto.Email).AnyAsync();
            if (existe)
            {
                throw new ManejadorExcepcion(HttpStatusCode.BadRequest, new { mensaje = "Existe ya un usuario registrado con este email" });
            }

            var existeUserName = await _dataBaseContext2.Users.Where(x => x.UserName == requestUserDto.Username).AnyAsync();
            if (existeUserName)
            {
                throw new ManejadorExcepcion(HttpStatusCode.BadRequest, new { mensaje = "Existe ya un usuario con este username" });
            }


            var usuario = new Cliente
            {
                Nombre = requestUserDto.Nombre,
                Email = requestUserDto.Email,
                UserName = requestUserDto.Username,
              
            };

            var resultado = await _userManager.CreateAsync(usuario, requestUserDto.Password);
            if (resultado.Succeeded)
            {
                return new ResponseUserDto
                {
                    Nombre = usuario.Nombre,
                    Token = _jwtGenerador.CrearToken(usuario),
                    Username = usuario.UserName,
                    Email = usuario.Email
                };
            }



            throw new Exception("No se pudo agregar al nuevo usuario");
        }

        public async Task<ResponseUserDto> UpdateUser(RequestUserDto requestUserDto)
        {
            var usuarioIden = await _userManager.FindByNameAsync(requestUserDto.Username);
            if (usuarioIden == null)
            {
                throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { mensaje = "No existe un usuario con este username" });
            }

            var resultado = await _dataBaseContext2.Users.Where(x => x.Email == requestUserDto.Email && x.UserName != requestUserDto.Username).AnyAsync();
            if (resultado)
            {
                throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Este email pertenece a otro usuario" });
            }

            usuarioIden.Nombre = requestUserDto.Nombre;
            usuarioIden.PasswordHash = _passwordHasher.HashPassword(usuarioIden, requestUserDto.Password);
            usuarioIden.Email = requestUserDto.Email;

            var resultadoUpdate = await _userManager.UpdateAsync(usuarioIden);

            if (resultadoUpdate.Succeeded)
            {
                return new ResponseUserDto
                {
                    Nombre = usuarioIden.Nombre,
                    Username = usuarioIden.UserName,
                    Email = usuarioIden.Email,
                    Token = _jwtGenerador.CrearToken(usuarioIden),
                };
            }

            throw new System.Exception("No se pudo actualizar el usuario");
        }
    }
}
