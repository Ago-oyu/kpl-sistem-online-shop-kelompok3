﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Mapster;

namespace DataTypes
{
    public class User<T> : Syncronizeable<T> where T : class
    {
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string Email, string Password, string Id=null) : base(Id)
        {
            this.Email = Email;
            this.Password = Password;
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

        public static async Task<LoginOut<T>> Login(LoginInfo form)
        {
            form.Type = typeof(T) == typeof(Pembeli) ? UserTypes.pembeli:UserTypes.penjual;

            using var client = new HttpClient();

            string requestUrl = baseUrl + "/api/login";

            Console.WriteLine(requestUrl);

            var content = new StringContent(JsonSerializer.Serialize(form), Encoding.UTF8, "application/json");
            
            try
            {
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
            }
            catch (Exception ex)
            {
                return new LoginOut<T>(){ Status = $"An error occurred: {ex.Message}"};
            }
        }

       public async Task<string> Register()
       {
            using var client = new HttpClient();

            string requestUrl = baseUrl + $"/api/register/" + (typeof(T) == typeof(Pembeli)? UserTypes.pembeli.ToString():UserTypes.penjual.ToString());

            Console.WriteLine(requestUrl);

            var content = new StringContent(JsonSerializer.Serialize(this as T), Encoding.UTF8, "application/json");
            
            try
            {
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
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
       }
    }
}
