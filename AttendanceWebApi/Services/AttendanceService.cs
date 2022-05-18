using AttendanceWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceWebApi.Services
{
    public class AttendanceService : IAttendanceService
    {
        public static readonly List<Attendance> attendances = new List<Attendance>()
      {
          new Attendance{AttendanceId = "01" , AttendanceStatus = "Present", AttendanceDate = "18/05/2022"},
          new Attendance {AttendanceId = "02" ,AttendanceStatus = "Absent", AttendanceDate = "18/05/2022"}

      };

        public async Task<IEnumerable<Attendance>> GetAttendances()
        {
            return attendances;
        }
        public async Task<Attendance> GetAttendanceById(string attendanceId)
        {
            var result = attendances.FirstOrDefault(a => a.AttendanceId == attendanceId);
            return result;
        }

        public async Task<Attendance> CreateAttendance(Attendance attendanceObj)
        {
            attendances.Add(attendanceObj);
            return attendanceObj;
        }

        public async Task<Attendance> DeleteAttendance(string attendanceId)
        {
            var result = attendances.FirstOrDefault(a => a.AttendanceId == attendanceId);
            if (result != null)
            {
                attendances.Remove(result);
            }
            return result;
        }

        public async Task<Attendance> UpdateAttendance(Attendance attendanceObj)
        {
            var result = attendances.FirstOrDefault(a => a.AttendanceId == attendanceObj.AttendanceId);

            if (result != null)
            {
                result.AttendanceId = attendanceObj.AttendanceId;
                result.AttendanceStatus = attendanceObj.AttendanceStatus;
                result.AttendanceDate = attendanceObj.AttendanceDate;
                return result;
            }
            return null;
        }
    }
}
