using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_CSharp_1
{
    struct Request
    {
        public int order_id { get; set; }
        public Client client { get; set; }
        public DateTime order_date { get; set; }
        public List<Article> articles { get; set; }
        public int order_price { get; set; }
        public PayType type { get; set; }
    }
}
