using P4_1_1214060;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan2
{
    internal class DVD_1214060 : product_1214060
    {
        protected string duration; 

        public DVD_1214060(string title, string duration) //method constructor dengan 3 parameter
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("Ini dari class DVD!!!");
        }

        public string Duration
        {
            get { return this.duration; }
            set { duration = value; }
        }
    }
}
