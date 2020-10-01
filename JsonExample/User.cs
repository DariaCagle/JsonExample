using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample
{
    public class User
    {
        
        public string Login { get; set; }

        [MyIgnore]
        public string PassWord { get; set; }
        

        public string FirstName { get; set; }

        [MyIgnore]
        public string LastName { get; set; }
        

        public int Age { get; set; }

    }
}
