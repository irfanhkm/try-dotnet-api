using System;
using try_dotnet_api.Dmo;
using try_dotnet_api.Dto;

namespace try_dotnet_api.Factory
{
    public class SiswaFactory
    {
        public static ShowSiswaDMO ParsingSiswa(ParamSiswaDto param)
        {
            return new ShowSiswaDMO()
            {
                IdSiswa = 1,
                NamaSiswa = param.Nama,
                UmurSiswa = param.Umur.ToString(),
                NamaSekolah = param.NamaSekolah,
            };
        }
    }
}
