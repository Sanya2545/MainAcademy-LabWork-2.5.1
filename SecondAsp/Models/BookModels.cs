using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace CSharp_Net_module3_1_1_lab.Models
{
    // 1) Add properties to model
    public class BookModels
    {
        public BookModels(int id = 0, string name = "Unknown book name", string title = "unknown book title", string author = "unknown book author")
        {
            Name = name;
            Title = title;
            Author = author;
        }
        private int id = 0;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }
}