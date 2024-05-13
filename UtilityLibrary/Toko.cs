namespace UtilityLibrary
{
    public class Toko
    {
        private static List<string> kodeKategori = ["A", "B", "C", "D"];
        private static List<string> listKategori = ["elektronik", "perabotan", "alat", "baju"];

        public static string GetKategori(string id)
        {

            // Get the integer value of the enum
            int idIntValue = kodeKategori.IndexOf(id.Substring(0,1));

            return listKategori[idIntValue];
        }

        public static string GenId(string kategori, int numId)
        {

            int index = listKategori.IndexOf(kategori.ToLower());

            return $"{kodeKategori[index]}{numId}";
        }
    }
}
