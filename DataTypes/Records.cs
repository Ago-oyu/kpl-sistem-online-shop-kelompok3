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
        public string Status {get; set;}
        public T Info {get; set;}
    }
}