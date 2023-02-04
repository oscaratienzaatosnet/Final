using ApiShower;
using Xunit;

namespace Program.Tests
{
    public class TableTest
    {
        //Testing table formats ok
    [Fact]
    public  void Add_Machine_To_Table_Equals () {
        var manu = new Machine("id","name","manufacturer");
        var tabla = new Table();
        tabla.addMachine(manu);
        tabla.addMachine(manu);
        string finalTable = 
$@" ----------------------- 
 | Name | Manufacturer |
 ----------------------- 
 | name | manufacturer |
 ----------------------- 
 | name | manufacturer |
 ----------------------- 

 Count: 2";
            Assert.Equal(tabla.ToString(), finalTable);


        }
    
    }
}