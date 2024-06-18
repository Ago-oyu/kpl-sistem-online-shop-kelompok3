using DataTypes;
using GUI;

namespace GUI2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Pembeli.baseUrl = "http://localhost:5058";
            Pembeli.endpoint = "/api/pembeli";

            Penjual.baseUrl = "http://localhost:5058";
            Penjual.endpoint = "/api/penjual";

            Produk.baseUrl = "http://localhost:5058";
            Produk.endpoint = "/api/Produk";

            Pesanan.baseUrl = "http://localhost:5058";
            Pesanan.endpoint = "/api/pesanan";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}