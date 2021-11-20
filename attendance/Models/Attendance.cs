using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Attendance
    {
        //ID
        public int ID { get; set; }

        //勤務日
        [Display(Name = "勤務日")]
        [Required(ErrorMessage = "必須入力です")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime WorkingDate { get; set; }

        //始業時間
        [Display(Name = "始業時間")]
        [Required(ErrorMessage = "必須入力です")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:H:mm}", ApplyFormatInEditMode = true)]
        public DateTime ClonkingIn { get; set; }

        //終業時間
        [Display(Name = "終業時間")]
        [Required(AllowEmptyStrings = true)]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:H:mm}", ApplyFormatInEditMode = true)]
        public DateTime ClockingOut { get; set; }

        //休憩時間
        [Display(Name = "休憩時間")]
        [Required(AllowEmptyStrings = true)]
        public decimal BreakeTime { get; set; }

        //実働時間
        [Display(Name = "実働時間")]
        [Required(AllowEmptyStrings = true)]
        public decimal WorkingTime { get; set; }
    }
}
