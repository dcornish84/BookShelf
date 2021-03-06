﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Display(Name = "Comment")]
        public string Text { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Book")]
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
