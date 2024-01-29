using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    class KlicServisa
    {
        public static async Task PopulateCats(ObservableCollection<Cats> cats)
        {
            string url = "https://api.thecatapi.com/v1/breeds";
            List<Cats> c = new List<Cats>();
            using (var klient = new HttpClient())
            {
                HttpResponseMessage sp = await klient.GetAsync(url);
                c = await sp.Content.ReadAsAsync<List<Cats>>();
            }
            foreach (var x in c)
            {
                if (x.image == null || x.image.url == null)
                {
                    x.image = new Image();
                    x.image.url = "/Img/placeholder.jpg";
                }
                cats.Add(x);
            }
        }
    }
}
