namespace BasicRestaurant.Models{
  public class BoardMember
  {
    public string Name {get;set;}
    public int Id {get;set;}
    public int BusinessId {get;set;}
    public BoardMember( string name, int businessId)
    {
      Name = name;
      BusinessId = businessId;
    }
  }

}