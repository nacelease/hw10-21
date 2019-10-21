using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test1.Data
{
    public class store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int snum { get; set; }
        public string location { get; set; }
        public int ETotal { get; set; }

        [ForeignKey("FID")]
        public food foods { get; set; }

        public int PID { get; set; }

        [ForeignKey("PID")]
        public People peoples { get; set; }
    }
}
