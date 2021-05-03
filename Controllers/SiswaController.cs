using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using try_dotnet_api.Dto;
using try_dotnet_api.Entities;
using try_dotnet_api.Factory;
using try_dotnet_api.Repositories;

namespace try_dotnet_api.Controllers
{
    [Route("api/siswa")]
    public class SiswaController : Controller
    {
        private readonly SiswaRepository siswaRepository;

        public SiswaController()
        {
            this.siswaRepository = new SiswaRepository();
        }

        [HttpGet("")]
        public IEnumerable<SiswaEntity> GetAllSiswa()
        {
            return this.siswaRepository.GetAll();
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] ParamSiswaDto param)
        {
            return Ok(SiswaFactory.ParsingSiswa(param));
        }

        [HttpPost("bulk")]
        public IActionResult BulkPost([FromBody] List<ParamSiswaDto> param)
        {
            return Ok(SiswaFactory.ParsingListSiswa(param));
        }

        [HttpGet("{id}")]
        public IActionResult GetDetailSiswa(int id)
        {
            var data = siswaRepository.FindById(id);
            return Ok(SiswaFactory.ParsingSiswaFromEntity(data));
        }
    }
}
