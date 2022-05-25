using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_CSharp_1
{
    struct Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int number_of_orders { get; set; }
        public int total_sum { get; set; }
        public ClientType type { get; set; }
    }
}
