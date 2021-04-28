using System;
using try_dotnet_api.Dto;

namespace try_dotnet_api.Dmo
{
    public class ShowSiswaDMO
    {
        public int IdSiswa { get; set; }

        public string NamaSiswa { get; set; }

        public string UmurSiswa { get; set; }

        public string NamaSekolah { get; set; }

        public ParamAlamatSiswaDto ListAlamat { get; set; }

        public ShowTemanSiswaDMO[] DaftarTeman { get; set; }
    }
}
