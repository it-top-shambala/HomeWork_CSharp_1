using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class Bank
    {
        private int _deposit;
        public int Deposit { get => _deposit; }

        private int _p;
        public int P {
            get => _p;
            set
            {
                _p = value > 25 ? 25 : value < 0 ? 0 : value;
            }
        }
        public Bank() { }
        public Bank(int p = 0)
        {
            _p = p;
            _deposit = 10000;
        }
        public int Count()
        {
            double tempP = (double)_p / 100;
            int i = 0;
            while(_deposit < 11000)
            {
                i++;
                _deposit = _deposit + (int)(_deposit * tempP);
            }
            return i;
        }
    }
}
