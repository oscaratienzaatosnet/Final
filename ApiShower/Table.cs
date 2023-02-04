using ConsoleTables;
namespace ApiShower {
    public class Table :ConsoleTable{

    public Table():base("Name","Manufacturer") {
        
    }


    
}

public static class TableExtension {
    public static void addMachine(this Table value,Machine machine) {
        value.AddRow(machine.Name,machine.Manufacturer);

    }
}
}