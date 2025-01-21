using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ParentService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Parent, ParentDTO>();
                cfg.CreateMap<ParentDTO, Parent>();
                cfg.CreateMap<Parent, ParentStudentDTO>();
                cfg.CreateMap<Student, StudentDTO>();
            });
            return new Mapper(config);
        }

        public static List<ParentDTO> Get()
        {
            var repo = DataAccessFactory.ParentData();
            return GetMapper().Map<List<ParentDTO>>(repo.Get());
        }

        public static ParentDTO Get(int id)
        {
            var repo = DataAccessFactory.ParentData();
            return GetMapper().Map<ParentDTO>(repo.Get(id));
        }

        public static void Create(ParentDTO parentDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ParentDTO, Parent>();
            });
            var mapper = new Mapper(config);
            var parent = mapper.Map<Parent>(parentDTO);
            var repo = DataAccessFactory.ParentData();
            repo.Create(parent);
        }

        public static void Update(int id, ParentDTO parentDTO)
        {
            var repo = DataAccessFactory.ParentData();
            var parent = GetMapper().Map<Parent>(parentDTO);
            parent.ParentId = id;
            repo.Update(parent);
        }

        public static void Delete(int id)
        {
            var repo = DataAccessFactory.ParentData();
            repo.Delete(id);
        }
    }
}
