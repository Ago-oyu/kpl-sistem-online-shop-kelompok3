namespace UtilityLibrary
{
    public class Toko
    {
        enum Month { A, B, C, D }
        public static List<String> listKategori = new List<string>() { "elektronik", "perabotan", "alat", "baju" };

        public static string getKategori(string id)
        {
            Month idEnumValue = (Month)Enum.Parse(typeof(Month), id.Substring(0,1));

            // Get the integer value of the enum
            int idIntValue = (int)idEnumValue;

            return listKategori[idIntValue];
        }

        public static string genId(string kategori, int numId)
        {
            Month[] allMonths = (Month[])Enum.GetValues(typeof(Month));

            int index = listKategori.IndexOf(kategori);

            return $"{allMonths[index]}{numId}";
        }
    }
}
