using ApiShower;
namespace Program.Tests;

public class ApiTest
{
    // Testing call to api
    [Fact]
    public void Call_To_API()
    {
        var api = new ApiService();
        var retorno = api.Call();
        Assert.Equal(921,retorno.Length);
        var machines = ApiService.Deserialize(retorno);
        Assert.Equal(10,machines?.Count);

    }

    // Testing deserialization of sample
     [Fact]
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
        var machines = ApiService.Deserialize(example);
        Assert.Equal(2,machines?.Count);
    }
}