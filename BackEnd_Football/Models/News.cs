using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_Football.Models
{
    [Table("News")]
    public class News
    {

        [Key]
        public long id { get; set; }
        public string content { get; set; } = "";
        public string contact { get; set; } = "";
        public SqlUser? userNews { get; set; }
        public List<string> images { get; set; } = new List<string>();

    }
}
