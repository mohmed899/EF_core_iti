using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EF_core.model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public int? Post_Time { get; set; }

        [ForeignKey("blog")]
        public int blog_id { get; set; }
        [ForeignKey("auther")]
        public int auther_id { get; set; }



        //navigator
        public virtual Blog blog { get; set; }  
        public virtual Auther auther { get; set; }  
        public virtual PostImg PostImg { get; set; }

 
    }
}
