using Yoga;

namespace YogaTesting
{
    [TestClass]
    public class PenjualTest
    {
        Penjual P1 = new Penjual("Nama1", "Email1", "Password1", "Toko1");
        Produk PR1 = new Produk("Colokan", "elektronik");
        Produk PR2 = new Produk("Charger", "elektronik");
        Produk PR3 = new Produk("Palu", "alat");

        [TestMethod]
        public void TestStatusPenjual1()
        {
            String expected = "New";
            Assert.AreEqual(expected, P1.GetStatusToko());
        }

        [TestMethod]
        public void TestStatusPenjual2()
        {
            String expected = "Silver";

            P1.GetDaftarProduk().Add(PR1);
            P1.GetDaftarProduk().Add(PR2);
            P1.GetDaftarProduk().Add(PR3);
            PR1.AddPenjualan(12);
            PR2.AddPenjualan(8);
            PR3.AddPenjualan(5);
            P1.UpdateStatusToko();
            Assert.AreEqual(expected, P1.GetStatusToko());
        }

        [TestMethod]
        public void TestPoinPenjual()
        {
            int expected = 125;
            P1.GetDaftarProduk().Add(PR1);
            P1.GetDaftarProduk().Add(PR2);
            P1.GetDaftarProduk().Add(PR3);
            PR1.AddPenjualan(12);
            PR2.AddPenjualan(8);
            PR3.AddPenjualan(5);
            P1.UpdatePoin();
            Assert.AreEqual(expected, P1.GetPoin());
        }

        [TestMethod]
        public void TestTotalPenjualan()
        {
            int expected = 25;
            P1.GetDaftarProduk().Add(PR1);
            P1.GetDaftarProduk().Add(PR2);
            P1.GetDaftarProduk().Add(PR3);
            PR1.AddPenjualan(12);
            PR2.AddPenjualan(8);
            PR3.AddPenjualan(5);

            Assert.AreEqual(expected, P1.GetDaftarProduk().GetTotalPenjualan());
        }
    }
}
