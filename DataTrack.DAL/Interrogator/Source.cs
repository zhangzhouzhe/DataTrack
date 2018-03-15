using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTrack.DAL.Interrogator
{
    class Source
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Key { get; set; }
        [Required, MaxLength(300)]
        public string Location { get; set; }
    }
}
