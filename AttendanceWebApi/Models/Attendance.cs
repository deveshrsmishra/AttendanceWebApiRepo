using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceWebApi.Models
{
    public class Attendance
    {
        [Key]
        public string AttendanceId { get; set; }

        public string AttendanceStatus { get; set; }

        public string AttendanceDate { get; set; }
    }
}
