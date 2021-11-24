using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14WpfApp
{
    public enum ProblemTypes
    {
        Food, // Еда
        Appliances // Бытовая техника  Food Appliances
    }
    public class Problem // Product
    {
        public string ProblemName { get; set; } // ProductName
        public string Description { get; set; } // Image
        public int Priority { get; set; } // Price
        public ProblemTypes ProblemType { get; set; } // Category

        public override string ToString()
        {
            return Description;
        }
    }
}
