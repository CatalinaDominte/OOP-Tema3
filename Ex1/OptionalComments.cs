using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class OptionalComments
    {
        private List<string> Comment;
        public OptionalComments()
        {
            this.Comment = new List<string>();
        }
        public void AddComment(string comment)
        {
            Comment.Add(comment);
            Console.WriteLine(comment);
        }

    }
}
