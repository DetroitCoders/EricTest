using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOne
{
    class Post
    {
        private string title;
        private string description;
        private DateTime postTime;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public DateTime PostTime
        {
            get
            {
                return postTime;
            }

            set
            {
                postTime = value;
            }
        }
    }
}
