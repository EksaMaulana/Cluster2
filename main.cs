using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("SELAMAT DI PROGRAM NILAI SISWA");
        
        Console.Write("Masukkan Nama: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan Nilai Harian: ");
        double nilaiHarian = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan Nilai UTS: ");
        double nilaiUts = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan Nilai UAS: ");
        double nilaiUas = Convert.ToDouble(Console.ReadLine());

        
        double nilaiAkhir = (nilaiHarian + nilaiUts + nilaiUas) / 3;

        
        string predikat = "";
        if (nilaiAkhir >= 80)
        {
            predikat = "A";
        }
        else if (nilaiAkhir >= 70 && nilaiAkhir < 80)
        {
            predikat = "B";
        }
        else if (nilaiAkhir >= 60 && nilaiAkhir < 70)
        {
            predikat = "C";
        }
        else if (nilaiAkhir >= 50 && nilaiAkhir < 60)
        {
            predikat = "D";
        }
        else
        {
            predikat = "E";
        }

        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Nilai Harian: {nilaiHarian}");
        Console.WriteLine($"Nilai UTS: {nilaiUts}");
        Console.WriteLine($"Nilai UAS: {nilaiUas}");
        Console.WriteLine($"Nilai Rata-Rata: {nilaiAkhir}");
        Console.WriteLine($"Predikat Nilai: {predikat}");
    }
}