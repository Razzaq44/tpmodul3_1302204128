using System;
namespace tpmodul3_1302204128
{
    public class main
    {
        public static void Main()
        {
            Console.WriteLine("---------- KodePos Program ----------");
            Console.Write("Masukan Nama Kelurahan: ");
            string namaKelurahan = Console.ReadLine();
            Console.WriteLine(KodePos.getKodePos(namaKelurahan));
            Console.WriteLine("---------- DoorMachine Program ----------");
            DoorMachine.doorMachine();
        }        
    }
}