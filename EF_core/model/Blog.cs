using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EF_core.model
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
     


        //Navigators 
        public virtual ICollection<Post> Posts { get;}
    }
}
