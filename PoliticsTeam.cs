using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class PoliticsTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            Console.WriteLine("$ stoty:{_story} title:{_title} body:{_body}");
        }
        internal override void AddStyle()
        {
            Console.WriteLine("$ vizualStayle:{_vizualStayle}");
        }
    }
}
