namespace tpmodul3_1302204128
{
    public class KodePos
    {
        static void Main()
        {
            Console.Write("Masukan Nama Kelurahan: ");
            string namaKelurahan = Console.ReadLine();
            Console.WriteLine(getKodePos(namaKelurahan));
        }
        static int getKodePos(string namaKelurahan)
        {
            string[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
            int[] kodePosKelurahan = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            int maxKelurahan = kelurahan.Length - 1;

            int listKelurahan = 40273;
            int kelurahanLevel = 0;
            while ((listKelurahan == 40273) && (kelurahanLevel < maxKelurahan))
            {
                if (namaKelurahan == kelurahan[kelurahanLevel])
                {
                    listKelurahan = kodePosKelurahan[kelurahanLevel];
                }
                kelurahanLevel = kelurahanLevel + 1;
            }
            return listKelurahan;
        }
    }
}