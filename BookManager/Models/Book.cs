using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace BookManager.Models
{
    
    public class Book
    {

        private int id;
        private string title;
        private string author;
        private string image_url;


        public int Id { get => id;
            set => id = value;
        }
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(250, ErrorMessage = "Tiêu đề không được vượt quá 250 ký tự")]
        [Display(Name = "Tiêu đề")]
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Image_url { get => image_url; set => image_url = value; }

        public Book()
        {
            
        }
        public Book(int id, string title, string author, string image_url)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_url = image_url;
        }
    }

    
}