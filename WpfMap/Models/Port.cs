using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMap.Models
{
    public class Port
    {
        public int Id { get; set; }
        public bool Sfp { get; set; } = false;
        public bool Link { get; set; } = false;
    }
}
