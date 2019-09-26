using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        private int integer = 0;
        public int Integer
        {
            get { return integer; }
            set { integer = value; }
        } 

        public Counter()
        {
        }

        public void Add(int number)
        {
            this.Integer += number;
            Console.WriteLine(this.Integer);
        }
        public void Add()
        {
            this.Integer++;
        }
        public void Get()
        {
            string value = this.Integer.ToString();
            Console.WriteLine(value);
        }
        public void Reset()
        {
            this.Integer = 0;
            Console.WriteLine(this.Integer);
        }
    }
}
