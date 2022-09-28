using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_Football.Models
{
    [Table("Statement")]
    public class SqlState
    {
        [Key]
        public long ID { get; set; }
        public int code { get; set; }
        public string name { get; set; } = "";
        public string des { get; set; } = "";
        public bool isdeleted { get; set; } = false;
    }
}
