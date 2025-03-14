using DocumentCollaboration.Data;
using System.ComponentModel.DataAnnotations;

namespace DocumentCollaboration.Models
{
    public class DocumentUsers
    {
        [Key]
        public int Id { get; set; }

        public string DocumentId { get; set; }
        public Document Document { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string Role { get; set; }
    }
}
