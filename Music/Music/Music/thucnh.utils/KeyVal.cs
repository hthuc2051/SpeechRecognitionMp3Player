using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.utils
{
    class KeyVal
    {
        private int id;
        private double value;

        public int Id { get => id; set => id = value; }
        public double Value { get => value; set => this.value = value; }

        public KeyVal() { }

        public KeyVal(int id, double value)
        {
            this.Id = id;
            this.Value = value;
        }
    }
}
