using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Properties_ctor
    {
            private string _name;
            private int _rollnumber;
            private double _fees;

            public Properties_ctor(string _name, int _rollnumber, double _fees)
            {
                this._name = _name;
                this._rollnumber = _rollnumber;
                this._fees = _fees;
            }
            public string name
            {
                set
                {
                    this._name = value;
                }
                get
                {
                    return this._name;
                }
            }
            public int rollnumber
            {
                set { this._rollnumber = value; }
                get { return this._rollnumber; }
            }
            public double fees
            {
                set { this._fees = value; }
                get
                {
                    return this._fees;
                }
            }
            public override string ToString()
            {
                return $"Name-> {name} \nRollnumber-> {rollnumber} \nFees->{fees}";
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
               Properties_ctor Student = new Properties_ctor("Uddhav", 1, 40000);
               
                Console.WriteLine($"{Student}");
                Console.WriteLine();
            }
        

     }
}

