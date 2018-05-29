using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Chair
    {
        [Key]
        public int ChairId { get; set; }
        public string Name { get; set; }
    }
}
