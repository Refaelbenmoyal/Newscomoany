using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class GossipTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            Console.WriteLine("$ stoty:{_story} title:{_title} body:{_body}");
        }

    }
}
