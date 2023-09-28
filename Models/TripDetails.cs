using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TravelTrackEmpManegment.Models
{
    public class TripDetails
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime TodayDate { get; } = DateTime.Now;

        [DisplayName("Name")]
        public string nameEmp { get; set; }

        [DisplayName("Emp Code")]
        public string codeEmp { get; set; }

        [DisplayName("Visit Location")]
        public string daySchedule { get; set; }

        [DisplayName("Vehical Type")]
        public string vehicalTpe { get; set; }

        [DisplayName("Vehical No")]
        public string vehicalNo { get; set; }

        [DisplayName("Starting KM")]
        public int startPointKM { get; set; }

        [DisplayName("Ending KM")]
        public int endPointKM { get; set; }

        public int totalKM { get; set; }
        public int costOfKM { get; set; }

        [DisplayName("Food Expence")]
        public int foodEXP { get; set; }
        [DisplayName("meeting Expence")]
        public int meetingEXP { get; set; }
        [DisplayName("stay Expence")]
        public int stayEXP { get; set; }

        [DisplayName("Other Expence")]
        public int otherEXP { get; set; }
        public int totalEXP { get; set; }

        [DisplayName("Day Remark")]
        public String dayRemark { get; set; }


        [DisplayName("Upload Photos")]
        public HttpPostedFileBase PhotoStart { get; set; }

        public HttpPostedFileBase PhotoEnd { get; set; }
    }
}