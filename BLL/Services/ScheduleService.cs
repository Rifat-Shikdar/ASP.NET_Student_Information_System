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
    public class ScheduleService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Schedule, ScheduleDTO>();
                cfg.CreateMap<Student, StudentDTO>(); // Mapping for related student
            });
            return new Mapper(config);
        }

        public static List<ScheduleDTO> Get()
        {
            var repo = DataAccessFactory.ScheduleData();
            return GetMapper().Map<List<ScheduleDTO>>(repo.Get());
        }

        public static ScheduleDTO Get(int id)
        {
            var repo = DataAccessFactory.ScheduleData();
            return GetMapper().Map<ScheduleDTO>(repo.Get(id));
        }

        public static void Create(ScheduleDTO scheduleDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ScheduleDTO, Schedule>();
            });
            var mapper = new Mapper(config);
            var schedule = mapper.Map<Schedule>(scheduleDTO);
            var repo = DataAccessFactory.ScheduleData();
            repo.Create(schedule);
        }

        public static void UpdateSchedule(int id, ScheduleDTO scheduleDTO)
        {
            var repo = DataAccessFactory.ScheduleData();
            var schedule = GetMapper().Map<Schedule>(scheduleDTO);
            schedule.ScheduleId = id;
            repo.Update(schedule);
        }

        public static void DeleteSchedule(int id)
        {
            var repo = DataAccessFactory.ScheduleData();
            repo.Delete(id);
        }
    }

}
