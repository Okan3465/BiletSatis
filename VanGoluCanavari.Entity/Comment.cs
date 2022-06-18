using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanGoluCanavari.Entity
{
   public class Comment
    {

        [Key]
        public int CommentID { get; set; }
        public string CommenUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }

        public DateTime CommentDate { get; set; }

        public bool ComentStatus { get; set; }
       
    }
}
