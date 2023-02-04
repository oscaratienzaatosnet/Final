using ConsoleTables;
using System.Text.Json;
namespace ApiShower {

class Program
{
    static int Main(string[] args)
    {
            // ApiService.Deserialize_JSON_To_Objects();
            // ApiService.Call_To_API();
            // Table.Add_Machine_To_Table_Equals();

            var api = new ApiService();
            List<Machine>? machines = api.Call_Deserialize();
            if (machines == null) {
                Console.WriteLine("ERROR calling API");
                return -1;
            }
            var tabla = new Table();
            foreach (var item in machines)
            {
                tabla.addMachine(item);
            }
            Console.WriteLine(tabla);
            return 0;

        }
}


}