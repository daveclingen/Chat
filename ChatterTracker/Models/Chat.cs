using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ChatterTracker.Models
{
    public class Chat
    {
        [Key]
        public int UserID { get; set; }

        [BindNever]
        [EmailAddress]
        public string UserName { get; set; }

        public string TextMessage { get; set; }
    }
}
