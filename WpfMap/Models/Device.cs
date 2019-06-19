using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMap.Models
{
    public class Device
    {
        public string Model { get; set; }
        public string Ip { get; set; }
        public bool IsAvailable { get; set; }
        public Port[] Ports { get; set; }
    }
}
