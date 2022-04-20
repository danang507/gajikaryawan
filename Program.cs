using System;


namespace responsi4417
{
    public class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }
        public Karyawan(string nik, string nama, float gaji)
        {
            this.NIK = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                gaji = 0;
            }
            this.GajiBulanan = gaji;
        }

        public void NaikkanGaji(float persentase)
        {
            this.GajiBulanan = persentase / 100 * this.GajiBulanan + this.GajiBulanan;
        }
        public static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("647201926", "Danang", 250000);
            Karyawan karyawan2 = new Karyawan("647109922", "Reyhan", 400000);
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine("Naikkan Gaji Sebesar 10%");
            Console.WriteLine();

            karyawan1.NaikkanGaji(10);
            karyawan2.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
        }

    }
}
