using AppGame.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppGame
{
    class PlayerService
    {
        HttpClient client;

        public List<Player> Items { get; private set; }
        private string RestUrl = @"http://10.0.2.2:61050/api/players";
        
        public PlayerService()
        {        
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<Player>> GetPlayers()
        {
            Items = new List<Player>();

            var uri = new Uri(RestUrl);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject < List < Player>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return Items;
        }

        public async Task SavePlayerAsync(Player item, bool isNewItem = false)
        {
            // RestUrl = http://developer.xamarin.com:8081/api/todoitems
            var uri = new Uri(string.Format(RestUrl, string.Empty));

            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    response = await client.PutAsync(uri, content);
                }

                //if (response.IsSuccessStatusCode)
                //{
                //    Debug.WriteLine(@"				TodoItem successfully saved.");
                //}

            }
            catch (Exception ex)
            {
                //Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
        }

        public async Task DeletePlayerItemAsync(string id)
        {
            // RestUrl = http://developer.xamarin.com:8081/api/todoitems/{0}
            var uri = new Uri(string.Format(RestUrl, id));

            try
            {
                var response = await client.DeleteAsync(uri);

                //if (response.IsSuccessStatusCode)
                //{
                //    Debug.WriteLine(@"				TodoItem successfully deleted.");
                //}

            }
            catch (Exception ex)
            {
                //Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
        }
    }
}
