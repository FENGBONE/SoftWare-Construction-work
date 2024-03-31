using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            Order order1 = new Order("1","a","a1",100);
            Order order2 = new Order("1", "a", "a1", 100);
            Assert.IsTrue(order1.Equals(order2));
        }
    }
    [TestClass]
    public class OrderDetailsTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            OrderDetails orderDetails1 = new OrderDetails("1", "a", 100);
            OrderDetails orderDetails2 = new OrderDetails("1", "a", 100);
            Assert.IsTrue(orderDetails1.Equals(orderDetails2));
        }
    }
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void FindTest()
        {
            OrderService orderService = new OrderService();
            orderService.Add(new Order("1", "a", "a1", 100));

            Assert.AreEqual<string>("1",orderService.Find("1").id);
        }
        [TestMethod()]
        public void AddTest()
        {
            OrderService orderService = new OrderService();
            orderService.Add(new Order("1", "a", "a1", 100));
            Assert.IsTrue(new Order("1", "a", "a1", 100).Equals( orderService.Find("1")));
        }
        [TestMethod()]
        public void RemoveTest()
        {
            OrderService orderService = new OrderService();
            orderService.Add(new Order("1", "a", "a1", 100));
            orderService.Add(new Order("2", "b", "b1", 200));
            orderService.Remove("1");
            orderService.GetOrders().ForEach(o => Assert.IsFalse(o.Equals(new Order("1", "a", "a1", 100))));
        }
        [TestMethod()]
        public void SortTest()
        {
            Order o1 = new Order("1", "a", "a1", 400);
            Order o2 = new Order("2", "b", "b1", 300);
            Order o3 = new Order("3", "c", "c1", 200);
            Order o4 = new Order("4", "d", "d1", 100);
            OrderService orderService = new OrderService();
            orderService.Add(o1);
            orderService.Add(o3);
            orderService.Add(o4);
            orderService.Add(o2);
            List<Order> orders = new List<Order>();
            orders.Add(o1);
            orders.Add(o2);
            orders.Add(o3);
            orders.Add(o4);

            for (int i = 0; i < orders.Count; i++)
            {
                if (!orders[i].Equals(orderService.Sort()[i]))
                {
                      Assert.Fail();
                }
            }

        }
    }
}