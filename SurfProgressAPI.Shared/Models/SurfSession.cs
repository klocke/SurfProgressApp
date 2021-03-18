using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurfProgressAPI.Shared.Models
{
    public class SurfSession
    {
        [Key]
        [Column(TypeName = "int")]
        public int SurfSessionId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public TimeOfDayEnum TimeOfDay { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Location { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public WaveHeightEnum WaveHeight { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public DirectionEnum WaveDirection { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public DirectionEnum WindDirection { get; set; }

        [Column(TypeName = "int")]
        // knots of wind
        public int WindSpeed { get; set; }

        [Column(TypeName = "int")]
        // Star rating
        public int Rating { get; set; }

        [Column(TypeName = "int")]
        public int WaveCount { get; set; }

        [Required]
        [ForeignKey("SurfboardId")]
        public string SurfboardId { get; set; }

        // 1:n relationship 
        // 1 SurfSession has 1 Surfboard and 1 Surfboard has many SurfSessions
        // Reference Navigation Property
        // virtual is needed for using Lazy Loading
        public virtual Surfboard Surfboard { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Notes { get; set; }

        // ENUM DECLARATION
        public enum TimeOfDayEnum { EarlyMorning, Morning, LateMorning, Midday, EarlyArvo, Arvo, LateArvo, EarlyEvening, Evening, LateEvening }

        public enum WaveHeightEnum { Knee, Waist, Shoulder, Head, Overhead, HeadAndAHalf, DoubleHead, DoubleOverhead, Huge }

        public enum DirectionEnum { Northerly, NorthEasterly, Easterly, SouthEasterly, Southerly, SouthWesterly, Westerly, NorthWesterly }
    }
}
