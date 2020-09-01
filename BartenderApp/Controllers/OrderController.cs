using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class OrderController : Controller
    {
        //Defaults and other houskeeping stuff
        //For some reason the new Orders are not saving between views
        public List<Order> queueList = new List<Order>();
        public OrderController()
        {
            queueList.Add(new Order { orderID = 0, drinkName = "Whiskey Coke", customerName = "Me" });
            queueList.Add(new Order { orderID = 1, drinkName = "4 Loko", customerName = "Also Me" });
        }
        public ActionResult index()
        {
            return View("orderQueue");
        }
        
        //Controller Code dealing with the Order Page
        public ActionResult addOrder()
        {
            return View();
        }
        public RedirectToActionResult createOrder(string drinkName, String customerName)
        {
            Order tobeAdded = new Order();
            tobeAdded.orderID = DateTime.Now.Hour*1000 + DateTime.Now.Second;
            tobeAdded.drinkName = drinkName;
            tobeAdded.customerName = customerName;
            queueList.Add(tobeAdded);
            //have not figured out how to pass details of the order between controllers
            return RedirectToAction("details");
        }
        //Controller Code dealing with the Order Queue
        //main veiw
        public ActionResult orderQueue()
        {
            return View(queueList);
        }
        //edting an order
        public ActionResult editOrder(int orderID, string drinkName, String customerName)
        {
            queueList[orderID].drinkName = drinkName;
            queueList[orderID].customerName = customerName;
            return View("editOrder");
        }
        //deleting an order from the queue
        public ActionResult deleteOrder(int orderID)
        {
            //could not figure out how to remove a list item using my orderID as a index (or even just searching for it)
            //queueList.RemoveAt() ;
            return View("orderQueue");
        }
        //for some reason when attempting to link direclty to this it doesnt work but the link through createOrder does...
        public ActionResult details(int id, string drinkName, String customerName)
        {
            return View("success");
        }
    }
}
