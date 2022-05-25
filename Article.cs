using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_CSharp_1
{
    struct Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ArticleType type { get; set; }
    }
}
