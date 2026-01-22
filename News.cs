using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class News
    {

        public int Name { get; set; }
        public int Tag { get; set; }
        public DateTime Date { get; set; }
        public string Src { get; set; }


        public News(int name, int tag, DateTime date,string src)
        {
           this.Name = name;
        public News(int name, int tag, DateTime date, string src)
        {
            this.Name = name;
            this.Tag = tag;
            this.Date = date;
            this.Src = src;
        }


    }
}
