using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core.model
{
    public class Auther
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int Age { get; set; }





        ///navigator
         public virtual ICollection<Post> Posts { get; set; }

    }
}
