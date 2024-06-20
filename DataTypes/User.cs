using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Mapster;
using System.Text.RegularExpressions;

namespace DataTypes
{
    public class User<T> : Syncronizeable<T> where T : class, IHashable
    {
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// gak perlu diapa apain, keperluan hashing
        /// </summary>
        public string Salt { get; set; }

        public User(string Email, string Password, string Id=null) : base(Id)
        {
            this.Email = Email;
            this.Password = Password;
        }

        public bool CheckPassword(string plainPassword)
        {
            return PasswordHandler.CheckPassword(plainPassword, Salt, Password);
        }
        /// <summary>
        /// email dan password harus terisi untuk proses pull
        /// </summary>
        public new async Task Pull()
        {
            var serverObj = await Login(new LoginInfo(){Email=Email, Password=Password});
            if (serverObj.Info is not null)
                serverObj.Info.Adapt(this as T);
            else
                Console.WriteLine($"pull gagal: {serverObj.Status}");
        }

        /// <summary>
        /// login user berdasarkan email dan password / objek loginInfo
        /// </summary>
        /// <returns>objek loginOut yang berisi status login dan objek user jika login berhasil</returns>
        public static async Task<LoginOut<T>> Login(string Email, string Password)
        {
            return await Login(new LoginInfo(){ Email=Email, Password=Password });
        }

        /// <inheritdoc cref="Login(string, string)"/>
        public static async Task<LoginOut<T>> Login(LoginInfo form)
        {
            form.Type = typeof(T) == typeof(Pembeli) ? UserTypes.pembeli:UserTypes.penjual;

            using var client = new HttpClient();

            string requestUrl = baseUrl + "/api/login";

            // Console.WriteLine(requestUrl);

            var content = new StringContent(JsonSerializer.Serialize(form), Encoding.UTF8, "application/json");
            
            // try
            // {
                HttpResponseMessage response = await client.PostAsync(requestUrl, content);

                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {

                    return JsonSerializer.Deserialize<LoginOut<T>>(responseBody);
                }
                else
                {
                    return new LoginOut<T>(){ Status = "status msg eror"};
                }
            // }
            // catch (Exception ex)
            // {
            //     return new LoginOut<T>(){ Status = $"An error occurred: {ex.Message}"};
            // }
        }

        /// <summary>
        /// register user baru ke database
        /// </summary>
        /// <returns>info apakah register berhasil atau gagal (e.g. kalau email sudah terpakai)</returns>
       public async Task<string> Register()
       {
            using var client = new HttpClient();

            string requestUrl = baseUrl + $"/api/register/" + (typeof(T) == typeof(Pembeli)? UserTypes.pembeli.ToString():UserTypes.penjual.ToString());

            // Console.WriteLine(requestUrl);

            var content = new StringContent(JsonSerializer.Serialize(this as T), Encoding.UTF8, "application/json");
            
            // try
            // {
                HttpResponseMessage response = await client.PostAsync(requestUrl, content);

                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {

                    return responseBody;
                }
                else
                {
                    return "status error:" + responseBody;
                }
            // }
            // catch (Exception ex)
            // {
            //     return $"An error occurred: {ex.Message}";
            // }
       }
       public static string ValidasiPassword(string password)
       {
        // verfikasi validasi password
            List<string> msg = new List<string>();

            if (password.Length < 8)
            {
                msg.Add("Password minimal memiliki 8 karakter.");
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                msg.Add("Password minimal memiliki 1 angka.");
            }

            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                msg.Add("Password minimal memiliki 1 karakter spesial.");
            }

            if (msg.Count > 0)
                return string.Join("\n", msg);
            
            return null;
       }
    }
    public class PasswordHandler
    {
        public static string CreateSalt(int size=16)
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(size));
        }
        public static string GenerateSHA512Hash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            byte[] hash = SHA512.HashData(bytes);

            return Convert.ToBase64String(hash);
        }
        public static bool CheckPassword(string plainPassword, string Salt, string HashedPassword)
        {
            string h = GenerateSHA512Hash(plainPassword, Salt);
            return GenerateSHA512Hash(plainPassword, Salt) == HashedPassword;
        }
    }
    public interface IHashable
    {
        public string Password {get; set; }
        public string Salt {get; set; }
    }
}
