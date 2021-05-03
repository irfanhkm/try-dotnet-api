using System;
using System.Collections.Generic;
using System.Linq;
using try_dotnet_api.Entities;

namespace try_dotnet_api.Repositories
{

    public class SiswaRepository
    {
        public List<SiswaEntity> _siswaEntity = new List<SiswaEntity>();
        public SiswaRepository()
        {
            SiswaEntity siswa1 = new SiswaEntity
            {
                Id = 1,
                NamaSiswa = "Irfan",
                Umur = 20,
            };

            SiswaEntity siswa2 = new SiswaEntity
            {
                Id = 2,
                NamaSiswa = "Fulani",
                Umur = 23,
            };

            _siswaEntity.Add(siswa1);
            _siswaEntity.Add(siswa2);
        }


        /**
         * get all data
         */
        public List<SiswaEntity> GetAll()
        {
            return _siswaEntity;
        }

        public SiswaEntity FindById(int id)
        {
            return _siswaEntity.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
