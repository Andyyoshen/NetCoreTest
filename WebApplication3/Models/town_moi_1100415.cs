using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using NetTopologySuite.Geometries;
namespace WebApplication3.Models
{
    public class town_moi_1100415
    {
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int gid { get; set; }
        
        public string countyname { get; set; }
        [NotMapped]
        public string townname { get; set; }
        [NotMapped]
        public string townid { get; set; }
        [NotMapped]
        public Geometry geog { get; set; }
    }
}
