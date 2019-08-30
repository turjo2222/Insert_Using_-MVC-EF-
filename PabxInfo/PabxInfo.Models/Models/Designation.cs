using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabxInfo.Models.Models
{
    public class Designation
    {
        public List<Designation> Designations;
        public int ID { get; set; }
        public string DesignationName { get; set; }
    }
}
