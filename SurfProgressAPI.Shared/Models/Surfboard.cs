using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurfProgressAPI.Shared.Models
{
    public class Surfboard
    {
        [Key]
        [Column(TypeName = "int")]
        public int SurfboardId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string DisplayName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Length { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Width { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Thickness { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Volume { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public FinSetupEnum FinSetup { get; set; }

        [Column(TypeName = "nvarchar(50)")] 
        public TailEnum Tail { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Brand { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Shaper { get; set; }

        public virtual List<SurfSession> SurfSessions { get; set; }

        // ENUM DECLARATION
        public enum FinSetupEnum { Thruster, Quad, Twin, Single };

        public enum TailEnum { Pin, Round, Square, Squash, Swallow, Fish}

    }
}
