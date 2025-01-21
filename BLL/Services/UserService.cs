using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>(); 
            });
            return new Mapper(config);
        }
        
        public static List<UserDTO> Get()
        {
            var repo = DataAccessFactory.UserData();
            return GetMapper().Map<List<UserDTO>>(repo.Get());
        }

        public static UserDTO Get(int id)
        {
            var repo = DataAccessFactory.UserData();
            return GetMapper().Map<UserDTO>(repo.Get(id));
        }

        public static void Create(UserDTO userDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var user = mapper.Map<User>(userDTO);
            var repo = DataAccessFactory.UserData();
            repo.Create(user);
        }

        public static void Update(int id, UserDTO u)
        {
            var repo = DataAccessFactory.UserData();
            var user = GetMapper().Map<User>(u);
            user.UserId = id;
            repo.Update(user);
        }

        public static void Delete(int id)
        {
            var repo = DataAccessFactory.UserData();
            repo.Delete(id);
        }

       
    }

}
