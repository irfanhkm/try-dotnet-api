namespace try_dotnet_api.Dto
{
    public class ParamSiswaDto
    {
        public string Nama { get; set; }

        public int Umur { get; set; }

        public string NamaSekolah { get; set; }

        public ParamAlamatSiswaDto ListAlamat { get; set; }

        public ParamTemanSiswaDTO[] DaftarTeman { get; set; }
    }
}
