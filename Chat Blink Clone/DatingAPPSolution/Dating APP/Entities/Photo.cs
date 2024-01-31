using System.ComponentModel.DataAnnotations.Schema;

namespace Dating_APP.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}