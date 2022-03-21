using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF_core.model
{
    public class PostImg
    {
        [ForeignKey("post")]
        public int Id { get; set; } 
        public string Path { get; set; }


        //navigator
       public virtual Post  post { get; set; } 
    }
}
