using Microsoft.AspNetCore.Mvc;
using BasicRestaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace BasicRestaurant.Controllers
{
  public class HomeController : Controller
  {
    private readonly BasicRestaurantContext _db;

    public HomeController(BasicRestaurantContext db)
//where is this being instantiated? under the hood?
    {
      _db = db;
    }


    [HttpGet("/")]
    public ActionResult Index()
    {
      List<BoardMember> boardMembersList = _db.Board_Members.OrderByDescending(member => member.BusinessId).ToList();
      // order by descending is a method that works on db tables.. cannot perform the OrderBY on an already existing list
      List<Business> businessesList = _db.Businesses.ToList();
      ViewBag.Boards = boardMembersList;
      return View(businessesList);
    }
  }
}