namespace try_dotnet_api.Dto
{
    public class ParamTemanSiswaDTO
    {
        public string Nama { get; set; }

        public int Umur { get; set; }

        public string NamaSekolah { get; set; }

        public ParamAlamatSiswaDto ListAlamat { get; set; }
    }
}
