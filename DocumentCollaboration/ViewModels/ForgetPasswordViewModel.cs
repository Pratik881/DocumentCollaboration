using System.ComponentModel.DataAnnotations;

namespace DocumentCollaboration.ViewModels
{
   
        public class ForgetPasswordViewModel
        {
            [Required, EmailAddress]
            public string Email { get; set; }
        }
 }

