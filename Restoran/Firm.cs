using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Firm
    {

        private String directorName;
        private String directorLastName;
        private String chiefAcount;

        public Firm()
        {
        }

        public Firm(String directorName, String directorLastName, String chiefAcount)
        {
            this.directorName = directorName;
            this.directorLastName = directorLastName;
            this.chiefAcount = chiefAcount;
        }
        public void Show()
        {
            Console.WriteLine(directorName);
            Console.WriteLine(directorLastName);
            Console.WriteLine(chiefAcount);
        }
    }
}
