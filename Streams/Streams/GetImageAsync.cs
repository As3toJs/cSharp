using System;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace ThirdWeek
{
    public class GetImageAsync
    {
        public string webUrl = "https://api.thecatapi.com/v1/images/search?format=src&size=full";
        public string localPath = @"../../assets/cats.png";

        public async void GetImageHttpClientAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(webUrl);

            try {
                using (HttpContent content = response.Content)
                {
                    string result = await content.ReadAsStringAsync();

                    if (result != null)
                    {
                        StreamWriter streamWriter = new StreamWriter(localPath);

                        Encoding utf8 = Encoding.UTF8;
                        byte[] utf8Bytes = utf8.GetBytes(result);

                        FileStream fs = new FileStream(localPath, FileMode.Create);
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(utf8Bytes);

                        Console.ReadLine();                        
                    }
                }
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        /*
        public void GetImageses() {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileTaskAsync(new Uri(webUrl), localPath).Wait();
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage);
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Download completed!");
        }*/
    }
}
