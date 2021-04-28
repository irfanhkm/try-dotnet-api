﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using try_dotnet_api.Dmo;
using try_dotnet_api.Dto;

namespace try_dotnet_api.Factory
{
    public class SiswaFactory
    {
        public static ShowSiswaDMO ParsingSiswa(ParamSiswaDto param)
        {
            List<ShowTemanSiswaDMO> dmoTemanSiswa = new List<ShowTemanSiswaDMO>();
            for (int i = 0; i < param.DaftarTeman.Length; i++)
            {
                dmoTemanSiswa.Add(
                    new ShowTemanSiswaDMO()
                    {
                        NamaTeman = param.DaftarTeman[i].Nama,
                        UmurTeman = param.DaftarTeman[i].Umur.ToString(),
                        AlamatUtama = param.DaftarTeman[i].ListAlamat.AlamatUtama,
                    }
                );
            }
            return new ShowSiswaDMO()
            {
                IdSiswa = 1,
                NamaSiswa = param.Nama,
                UmurSiswa = param.Umur.ToString(),
                NamaSekolah = param.NamaSekolah,
                ListAlamat = param.ListAlamat,
                DaftarTeman = dmoTemanSiswa.ToArray()
            };
        }

        public static List<ShowSiswaDMO> ParsingListSiswa(List<ParamSiswaDto> param)
        {
            List<ShowSiswaDMO> Datas = new List<ShowSiswaDMO>();
            param.ForEach(data =>
            {
                Datas.Add(
                    new ShowSiswaDMO()
                    {
                        IdSiswa = 1,
                        NamaSiswa = data.Nama,
                        UmurSiswa = data.Umur.ToString(),
                        NamaSekolah = data.NamaSekolah
                    }
                ); ;
            });
            return Datas;
        }
    }
}
