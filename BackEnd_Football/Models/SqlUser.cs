using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_Football.Models
{
    [Table("User")]
    public class SqlUser
    {
        [Key]
        public long ID { get; set; }
        public string UID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string username { get; set; } = "";
        public string password { get; set; } = "";
        public string Email { get; set; } = string.Empty;
        public string PhotoURL { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public string Phone { get; set; } = string.Empty;
        public bool ChucVu { get; set; } = true;
        public List<SqlTeam>? team { get; set; } 
    }
}
