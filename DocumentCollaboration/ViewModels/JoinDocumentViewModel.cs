using System.ComponentModel.DataAnnotations;

namespace DocumentCollaboration.ViewModels
{
    public class JoinDocumentViewModel
    {
      
            [Required(ErrorMessage = "Document Id is required")]
            public string DocumentId { get; set; }
        
    }
}
