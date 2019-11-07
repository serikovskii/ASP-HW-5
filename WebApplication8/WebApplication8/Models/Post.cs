using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; }
        public string Nik { get; set; }
    }
}