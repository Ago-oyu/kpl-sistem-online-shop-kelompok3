namespace DataTypes
{       
    public enum UserTypes {
        pembeli, penjual
    }
    public record LoginInfo
    {
        public UserTypes Type {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
    }
    public record LoginOut<T>
    {
        /// <summary>
        /// login berhasil atau tidak dan alasannya kalau tidak berhasil
        /// </summary>
        public string Status {get; set;}
        /// <summary>
        /// kalau login berhasil data user akan disimpan disini, = null jika login gagal
        /// </summary>
        public T Info {get; set;}
    }
}