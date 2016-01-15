using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models
{
    public class Post
    {
        //Properties for our table
        //Displayed in COLUMNS
        public int PostId { get; set; }
        public string Message { get; set; }
        public string TimeStamp { get; set; }
    }
}
