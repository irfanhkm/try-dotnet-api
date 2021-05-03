using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace try_dotnet_api.Entities
{
    [Table("siswa")]
    public class SiswaEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Key, Column("nama_siswa")]
        public string NamaSiswa { get; set; }

        [Key, Column("umur")]
        public int Umur { get; set; }

        [Key, Column("sekolah_id")]
        public int SekolahId { get; set; }

        [ForeignKey("SekolahId")]
        public SekolahEntity Sekolah { get; set; }
    }
}
