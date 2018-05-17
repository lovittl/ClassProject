using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

//Properties to access data base table dbo.Song
namespace Lynzy.Domain.Entities
{
    [Table("dbo.Song")]
    public class SongFiles
    {
        [Key]
        public int SID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        [Column("Contributing Artists")]
        public string ContributingArtists { get; set; }
        public string  Album { get; set; }
        [Column("File extension")]
        public string FileExtension { get; set; }
        public string Genre { get; set; }
        public TimeSpan Length { get; set; }
        public bool Favorite { get; set; }
        public DateTime Year { get; set; }
        [Column("Bit Rate")]
        public string BitRate { get; set; }
    }
}
