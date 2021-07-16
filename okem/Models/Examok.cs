using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace okem.Models
{
    public class Examok
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        public string Subject { get; set; }

        [Required(ErrorMessage = " Vui lòng nhập thông tin ")]
        public string StartTime { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        public string ExamDate { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        public string Duration { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        public string ClassRoom { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        public string Faculty { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        public string Status { get; set; }

    }
}