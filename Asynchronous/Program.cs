using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Asynchronous
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await DoAsync();
        }

        static async Task DoAsync() // 비동기 메서드
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://www.naver.com");
                var content = await response.Content.ReadAsStringAsync();

                Console.WriteLine(content);
            }
        }
    }
}
