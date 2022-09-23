using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Login.Register_Homework_23._09._2022.Https.Json
{
    public class Json
    {
        public class https_json
        {
            static string path = @"C:\Users\Admin\OneDrive\Рабочий стол\Lab\Test\Test\Https Json\ToDoOutput.txt";
            static async Task Main(string[] args)
            {
                Console.WriteLine("Please enter the url you want");
                string url = Console.ReadLine();
                var awaiter = await GetToDoAsync(url);
                if (awaiter != null)
                {
                    File.WriteAllText(path, awaiter.ToString());
                }
                Console.WriteLine("Press X to Exit");
                Console.ReadKey();
            }
            public static async Task<string> GetToDoAsync(string url)
            {

                HttpClient client = new HttpClient();
                 var strginResult = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
                {
                    Console.WriteLine(strginResult);
                    return strginResult;
                }
               
            }

        }

    }
}

