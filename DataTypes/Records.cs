namespace DataTypes
{       
    public enum UserTypes {
        pembeli, penjual
    }
    public record LoginInfo
    {
        public UserTypes type;
        public string email;
        public string password;
    }
    public record LoginOut<T>
    {
        public string status;
        public T info;
    }
}