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
    public class StudentService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
                cfg.CreateMap<StudentDTO, Student>();
                cfg.CreateMap<Attendence, AttendenceDTO>();
                cfg.CreateMap<AttendenceDTO, Attendence>();
                cfg.CreateMap<Schedule, ScheduleDTO>();
                cfg.CreateMap<ScheduleDTO, Schedule>();
                cfg.CreateMap<Parent, ParentDTO>();
                cfg.CreateMap<ParentDTO, Parent>();
                cfg.CreateMap<StudentRecord, StudentRecordDTO>();
                cfg.CreateMap<StudentRecordDTO, StudentRecord>();

                cfg.CreateMap<Student, StudentParentDTO>();
                cfg.CreateMap<StudentParentDTO, Student>();
                cfg.CreateMap<StudentAttendenceDTO, Student>();
                cfg.CreateMap<Student, StudentScheduleDTO>();
                cfg.CreateMap<StudentScheduleDTO, Student>();
            });
            return new Mapper(config);
        }

        public static List<StudentDTO> Get()
        {
            var repo = DataAccessFactory.StudentData();
            return GetMapper().Map<List<StudentDTO>>(repo.Get());
        }

        public static StudentDTO Get(int id)
        {
            var repo = DataAccessFactory.StudentData();
            return GetMapper().Map<StudentDTO>(repo.Get(id));
        }

        public static List<StudentDTO> SearchByName(string name)
        {
            var repo = DataAccessFactory.StudentData();
            var data = repo.Get().Where(x => x.FirstName.Contains(name) || x.LastName.Contains(name)).ToList();
            return GetMapper().Map<List<StudentDTO>>(data);
        }

        public static StudentAttendenceDTO GetWithAttendance(int id)
        {
            var repo = DataAccessFactory.StudentData();
            return GetMapper().Map<StudentAttendenceDTO>(repo.Get(id));
        }

        public static StudentScheduleDTO GetWithSchedule(int id)
        {
            var repo = DataAccessFactory.StudentData();
            var s = repo.Get(id);
            return GetMapper().Map<StudentScheduleDTO>(s);
        }

        public static StudentParentDTO GetWithParent(int id)
        {
            var repo = DataAccessFactory.StudentData();
            var s = repo.Get(id);
            return GetMapper().Map<StudentParentDTO>(s);
        }


        public static void Create(StudentDTO a)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<Student>(a);
            var repo = DataAccessFactory.StudentData();
            repo.Create(ret);

        }

        public static void Update(int id, StudentDTO sd)
        {
            var repo = DataAccessFactory.StudentData();
            var s = GetMapper().Map<Student>(sd);
            s.StudentId = id; 
            repo.Update(s);
        }

        public static void Delete(int id)
        {
            var repo = DataAccessFactory.StudentData();
            repo.Delete(id);
        }
    }
}
