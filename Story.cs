using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Story
    {
        public string _title;
        public string _body;
        public string _vizualStayle;

        public override string ToString()
        {
            return "$ Story: title:{_title} body:{_bosy} vizualStayle:{_vizualStayle}";
        }
    }


}
