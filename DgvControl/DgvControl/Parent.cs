using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgvControl
{
    public class Parent
    {
        public bool isChecked { get; set; }
        public string content { get; set; }
        public List<Child> childList = new List<Child>();
    }
}
