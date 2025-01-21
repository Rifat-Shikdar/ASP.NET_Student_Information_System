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
    public class StudentRecordService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentRecord, StudentRecordDTO>();
                cfg.CreateMap<StudentRecordDTO, StudentRecord>();
                cfg.CreateMap<User, UserDTO>();
            });
            return new Mapper(config);
        }

        public static List<StudentRecordDTO> Get()
        {
            var repo = DataAccessFactory.StudentRecordData();
            return GetMapper().Map<List<StudentRecordDTO>>(repo.Get());
        }

        public static StudentRecordDTO Get(int id)
        {
            var repo = DataAccessFactory.StudentRecordData();
            return GetMapper().Map<StudentRecordDTO>(repo.Get(id));
        }

        public static void Create(StudentRecordDTO studentRecordDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentRecordDTO, StudentRecord>();
            });
            var mapper = new Mapper(config);
            var studentRecord = mapper.Map<StudentRecord>(studentRecordDTO);
            var repo = DataAccessFactory.StudentRecordData();
            repo.Create(studentRecord);
        }

        public static void UpdateStudentRecord(int id, StudentRecordDTO studentRecordDTO)
        {
            var repo = DataAccessFactory.StudentRecordData();
            var studentRecord = GetMapper().Map<StudentRecord>(studentRecordDTO);
            studentRecord.StudentRecordId = id;
            repo.Update(studentRecord);
        }

        public static void DeleteStudentRecord(int id)
        {
            var repo = DataAccessFactory.StudentRecordData();
            repo.Delete(id);
        }
    }
}
