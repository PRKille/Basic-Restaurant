namespace BasicRestaurant.Models{
  public class BoardMembers
  {
    public string Name {get;set;}
    public int Id {get;set;}
    public int BusinessId {get;set;}
    public BoardMembers( string name, int buisnessId)
    {
      Name = name;
      BuisnessId = buisnessId;
    }
  }

}