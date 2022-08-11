using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartGuesterLibrary.Models
{
    public class GuestLibararyClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MessageToHost { get; set; }

        private string _FullStuff;

        public string FullStuff
        {
            get 
            {
                return $"{FirstName} {LastName}: {MessageToHost}";
            }
            
        }


    }
}
