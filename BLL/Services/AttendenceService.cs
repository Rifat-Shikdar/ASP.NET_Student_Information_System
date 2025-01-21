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
   public class AttendanceService
{
    public static Mapper GetMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Attendence, AttendenceDTO>();
            cfg.CreateMap<AttendenceDTO, Attendence>();
            cfg.CreateMap<Student, StudentDTO>(); 
            cfg.CreateMap<StudentDTO, Student>();
        });
        return new Mapper(config);
    }

    public static List<AttendenceDTO> Get()
    {
        var repo = DataAccessFactory.AttendenceData();
        return GetMapper().Map<List<AttendenceDTO>>(repo.Get());
    }

    public static AttendenceDTO Get(int id)
    {
        var repo = DataAccessFactory.AttendenceData();
        return GetMapper().Map<AttendenceDTO>(repo.Get(id));
    }

    public static void Create(AttendenceDTO a)
    {
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<AttendenceDTO, Attendence>();
        });
        var mapper = new Mapper(config);
        var attendance = mapper.Map<Attendence>(a);
        var repo = DataAccessFactory.AttendenceData();
        repo.Create(attendance);
    }

    public static void Update(int id, AttendenceDTO attendanceDTO)
    {
        var repo = DataAccessFactory.AttendenceData();
        var attendance = GetMapper().Map<Attendence>(attendanceDTO);
        attendance.AttendenceId = id; 
        repo.Update(attendance);
    }

    public static void Delete(int id)
    {
        var repo = DataAccessFactory.AttendenceData();
        repo.Delete(id);
    }

        
    }

}
