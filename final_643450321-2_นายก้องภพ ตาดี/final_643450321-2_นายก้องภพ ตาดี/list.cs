using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_643450321_2_นายก้องภพ_ตาดี
{
    internal class list
    {
        private string _list;
        private string _price;

        public list(string list, string price)
        {
            this._list = list;
            this._price = price;
        }
        public string getlist() { return _list; }
        public string getprice() { return _price; }
    }
}
