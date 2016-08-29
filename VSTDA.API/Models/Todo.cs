using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VSTDA.API.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        public int Order { get; set; }
    }
}