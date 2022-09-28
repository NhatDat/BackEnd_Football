using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_Football.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public long id { get; set; }
        public string comments { get; set; } = "";
        public DateTime time { get; set; }
        public News? News { get; set; }
        public SqlUser? useComments { get; set; }
    }
}
