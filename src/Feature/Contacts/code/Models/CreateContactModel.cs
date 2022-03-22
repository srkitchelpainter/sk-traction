using System;
using System.ComponentModel.DataAnnotations;

namespace Sitecore.Feature.Contacts.Models
{
    public class CreateContactModel
    {
        public string Intro { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}