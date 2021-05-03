using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace try_dotnet_api.Entities
{
    [Table("sekolah")]
    public class SekolahEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Key, Column("nama_sekolah")]
        public string NamaSekolah { get; set; }

        public ICollection<SiswaEntity> Siswa { get; set; }
    }
}
