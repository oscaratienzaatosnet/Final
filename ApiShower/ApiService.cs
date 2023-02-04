using System.ComponentModel;
using System.Text.Json;
using dotenv.net;
using dotenv.net.Utilities;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ApiShower
{
    public class ApiService
    {

        string Url { get; set; }
        string User { get; set; }
        string Pass { get; set; }

        public ApiService()
        {
            DotEnv.Load();
            Url = EnvReader.GetStringValue("url");
            User = EnvReader.GetStringValue("user");
            Pass = EnvReader.GetStringValue("pass");

        }

        public string Call()
        {
            var authenticationString = $"{User}:{Pass}";
            var base64String = Convert.ToBase64String(
               System.Text.Encoding.ASCII.GetBytes(authenticationString));
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64String);
            client.DefaultRequestHeaders.Accept
  .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMsg = client.GetStringAsync(Url);
            if (EnvReader.GetBooleanValue("debug")) {
                Console.WriteLine(responseMsg.Result);
            }
            return responseMsg.Result;
        }

        // Testing call to api
        public static void Call_To_API() 
        {
            var api = new ApiService();
            var retorno = api.Call();
            Console.WriteLine($"Retorna {retorno.Length == 921}");
            var machines = Deserialize(retorno);
            Console.WriteLine($"Tamaño es {machines?.Count}");

        }

        public List<Machine>? Call_Deserialize() {
            var retorno = Call();
            var machines = Deserialize(retorno);
            return machines;
        }

        // Testing deserialization of sample
        public static void Deserialize_JSON_To_Objects()
        {
            string example = """
    [
        {
        "id": "8bd1304b-5ac6-49ef-93b4-df0a12b93a3b",
        "name": "GF3015",
        "manufacturer": "HGTech"
        },
        {
        "id": "fffe0fd5-5b1e-49d3-b761-8b9518ee1b72",
        "name": "LT8.10",
        "manufacturer": "BLM Group"
        }
        ]
    """;
            Console.WriteLine(example);
            var machines = Deserialize(example);
            Console.WriteLine($"Tamaño es {machines?.Count == 2}");
        }

        public static List<Machine>? Deserialize (string json) {
            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase

            };

            var machines = JsonSerializer.Deserialize<List<Machine>>(json, opciones);
            return machines;

        }


    }
}