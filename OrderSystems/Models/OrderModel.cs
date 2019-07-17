using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderSystems.Models
{
    public class OrderModel
    {
        public void updateOrder()
        {
            using (OrderSystemsEntities1 db = new OrderSystemsEntities1())
            {
                int ID = 1;
                var update = db.Orders.Where(o => o.ID == ID).FirstOrDefault();
                if(update != null)
                {
                    update.Firstname = "Firstname2";
                    update.Surname = "Surname2";
                    update.Contact_Number = "1234567890";
                    update.email = "email2@gmail.com";
                    update.Date = DateTime.Now;
                }
                db.SaveChanges();
                updateItem(ID);
            }
        }

        public void updateItem(int ID)
        {
            using (OrderSystemsEntities1 db = new OrderSystemsEntities1())
            {
                var update = db.OrderItems.Where(i => i.OrderID == ID).ToList();
                if (update.Count() != 0)
                {
                    foreach (var item in update)
                    {
                        item.Name = "itemName2";
                        item.Category = "CategoryItem2";
                        item.Qty = 10;
                        item.Price = 10000;
                    }
                }
                db.SaveChanges();
            }
        }

        public void addOrder()
        {
            using (OrderSystemsEntities1 db = new OrderSystemsEntities1())
            {
                var ord = new Order()
                {
                    Firstname = "Firstname",
                    Surname = "Surname",
                    Contact_Number = "0123456789",
                    email = "email@gmail.com",
                    Date = DateTime.Now
                };
                db.Orders.Add(ord);
                db.SaveChanges();
                var fibNumbers = new List<int> { 0,1,2};
                foreach (int count in fibNumbers)
                {
                    addItem();
                }
            }
        }

        public void addItem()
        {
            using (OrderSystemsEntities1 db = new OrderSystemsEntities1())
            {
                var item = new OrderItem()
                {
                    Name = "itemName",
                    Category = "CategoryItem",
                    Qty = 5,
                    Price = 5000,
                    OrderID = 1
                };
                db.OrderItems.Add(item);
                db.SaveChanges();
            }
        }

        public List<Order> getOrder()
        {
            using (OrderSystemsEntities1 db = new OrderSystemsEntities1())
            {
                var ord = from O in db.Orders select O;
                return ord.ToList();
            }
        }
    }
}