using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using try_dotnet_api.Dto;
using try_dotnet_api.Entities;

namespace try_dotnet_api.Controllers
{
    [Route("api/siswa")]
    public class SiswaController : Controller
    {
        private readonly List<SiswaEntity> listSiswa = new List<SiswaEntity>();
        public SiswaController()
        {
            SiswaEntity siswa1 = new SiswaEntity
            {
                Id = 1,
                Nama = "Irfan",
                Umur = 20,
                NamaSekolah = "DOT"
            };

            SiswaEntity siswa2 = new SiswaEntity
            {
                Id = 2,
                Nama = "Fulani",
                Umur = 23,
                NamaSekolah = "DOT"
            };

            listSiswa.Add(siswa1);
            listSiswa.Add(siswa2);
        }

        [HttpGet("")]
        public IActionResult GetAllSiswa()
        {
            return Ok(this.listSiswa);
        }

        [HttpPost("")]
        public IActionResult Post([FromBody]ParamSiswaDto param)
        {
            return Ok(param);
        }

        [HttpGet("{id}")]
        public IActionResult GetDetailSiswa(int id)
        {
            return Ok(this.listSiswa.Find(x => x.Id == id));
        }
    }
}
