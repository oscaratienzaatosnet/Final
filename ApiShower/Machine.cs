namespace ApiShower{
public class Machine {
    public string Id {get;set;}
    public string Name {get;set;}
    public string Manufacturer {get;set;}

    public Machine (string id,string name,string manufacturer) {
        Id=id;
        Name=name;
        Manufacturer=manufacturer;
    }
}
}