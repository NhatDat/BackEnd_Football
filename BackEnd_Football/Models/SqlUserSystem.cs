using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_Football.Models
{
    [Table("UserSystem")]
    public class SqlUserSystem
    {
        [Key]
        public long ID { get; set; }
        public string user { get; set; } = "";
        public string username { get; set; } = "";
        public string password { get; set; } = "";
        public string token { get; set; } = "";
        public bool isdeleted { get; set; } = false;
        public string phoneNumber { get; set; } = "";
        public string des { get; set; } = "";
        public string avatar { get; set; } = "";
        public SqlRole? role { get; set; }


    }
}
