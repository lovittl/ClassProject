using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Lynzy.Domain
{
    public class SongFiles
    {
        public string Name { get; set; }
        public string Title { get; set; }
        [Column("Contributing Artists")]
        public string ContributingArtists { get; set; }
        public string  Album { get; set; }
        [Column("File Extension")]
        public string FileExtension { get; set; }
        public string Genre { get; set; }
        public TimeSpan Length { get; set; }
        public byte Favorite { get; set; }
        public DateTime Year { get; set; }
    }
}
