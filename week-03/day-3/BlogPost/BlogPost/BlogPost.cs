using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    class BlogPost
    {
        public string _AuthorName { get; set; }
        public string _Title { get; set; }
        public string _Text { get; set; }
        public string _PublicationDate { get; set; }

        public BlogPost (string authorName, string title, string text, string publicationDate)
        {
            this._AuthorName = authorName;
            this._Title = title;
            this._Text = text;
            this._PublicationDate = publicationDate;
        }
        public void Blog()
        {
            Console.WriteLine($"The post {_Title} was written by {_AuthorName} on {_PublicationDate}");
        }

    }
}
