using System;
using System.Collections.Generic;
using System.Text;

namespace LearningLibrary
{
    public class StackOverflow
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        private int vote { get; set; }          

        public void UpVote()
        {
            vote++;
        }
        public void DownVote()
        {
            vote--;
        }
    }
}
