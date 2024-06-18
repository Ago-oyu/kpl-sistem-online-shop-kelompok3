using DataTypes;

namespace ShopApiClient
{
    public class Database
    {

/*        private Pembeli pembeliUser;
        private Penjual penjualUser;
*/
        private static List<Produk> listProduk;
        private static List<Pesanan> listPesanan;


        public static async Task<List<Produk>> GetProdukList()
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }
            
/*            if (filter != null)
            {
                List<Produk> = tempList
            }
*/
            return listProduk;
        }

        public static async Task<List<Produk>> GetProdukList(Penjual penj)
        {
            if (listProduk == null)
            {
                listProduk = new();
                foreach (Produk produk in await Produk.GetPage())
                {
                    if (produk.IDPenjual == penj.Id)
                    {
                        listProduk.Add(produk);
                    }
                }
            }

            return listProduk;
        }

        public void Reset()
        {
            listProduk = null;
            listPesanan = null;
        }

        /*        private async Task Login(string email, string password)
                {

                    LoginInfo loginInfo = new()
                    {
                        Email = email,
                        Password = password
                    };

                    LoginOut<Penjual> penjualLogin = await Penjual.Login(loginInfo);

                    if (penjualLogin.Info != null)
                    {
                        penjualUser = penjualLogin.Info;
                    } else
                    {
                        LoginOut <Pembeli> pembeliLogin = await User<Pembeli>.Login(loginInfo);
                        pembeliUser = pembeliLogin.Info;

                        if (pembeliUser == null)
                        {
                            throw new Exception("Username atau Password salah");
                        }
                    }
                }

                public User Login()

                public async Task GetProdukList<T>()
                {
                    if (typeof(T) == typeof(Pembeli))
                    {
                        List<Produk> produks = await Produk.GetPage();
                    }
                }*/


    }
}
