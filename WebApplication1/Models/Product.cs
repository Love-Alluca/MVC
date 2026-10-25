namespace MyMvcApp.Models; //container into a folder
public class ProductModel // we make a new class or entity
{
    //we define what belongs inside the productmodel class.
    public int Id { get; set; } // entity 1/columns // get; set; are auto-implemented properties
    public required string Name { get; set; } //entity 2/columns
    public decimal Price { get; set; }//entity 3/columns

}