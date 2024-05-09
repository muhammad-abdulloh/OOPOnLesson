using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOnLesson.Exeptions
{
    public class TopilmadiExseption
    {
        public TopilmadiExseption(string message)
        {
            throw new Exception(message);

        }


    }
}
