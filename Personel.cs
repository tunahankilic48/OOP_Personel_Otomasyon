using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_Uygulama_Personel_Otomasyon
{
    internal class Personel
    {
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        //private DateTime dogumTarihi;

        //public DateTime DogumTarihi
        //{
        //    get { return DogumTarihi; }
        //    set { DogumTarihi = value; }
        //}

        public DateTime DogumTarihi { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public Unvan Unvan { get; set; }
        public string Fotograf { get; set; }
        public Personel(int personelId, string ad, string soyad, DateTime dogumTarihi, DateTime ıseGirisTarihi, string telefonNo, string email, string adres, Unvan unvan, string fotograf)
        {
            PersonelId = personelId;
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
            IseGirisTarihi = ıseGirisTarihi;
            TelefonNo = telefonNo;
            Email = email;
            Adres = adres;
            Unvan = unvan;
            Fotograf = fotograf;
        }
    }
}
