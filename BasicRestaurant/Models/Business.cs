namespace BasicRestaurant.Models
{
  public class Business
  {
    public string Name {get;set;}
    public int Id {get;set;}

    public Business( string name)
    {
        Name = name;
    }
  }
}