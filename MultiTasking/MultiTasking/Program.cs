using MultiTasking.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace MultiTasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region file,directory&path
            //Directory.CreateDirectory(@"C:\Users\Gunay\Desktop\Task");
            //File.Create(@"C:\Users\Gunay\Desktop\Task\text.txt");
            //using (StreamWriter sr = new StreamWriter(@"C:\Users\Gunay\Desktop\Task\text.txt"))
            //{
            //    sr.Write("slm");
            //}
            //using (StreamReader sr = new StreamReader(@"C:\Users\Gunay\Desktop\Task\text.txt"))
            //{
            //    string result = sr.ReadToEnd();
            //    Console.WriteLine(result);
            //}

            #endregion

            #region Json
            GreenGrocer vegetable1 = new GreenGrocer()
            {
                Id = 1,
                Name = "alma",
                Price = 15
            };
            GreenGrocer vegetable2 = new GreenGrocer();
            GreenGrocer vegetable3 = new GreenGrocer();
            GreenGrocer vegetable4 = new GreenGrocer();

            OrderItem orderItem1 = new OrderItem()
            {
                Id = 1,
                Count = 1,
                vegetable = vegetable1,
                TotalPrice = vegetable1.Price
            };
            OrderItem orderItem2 = new OrderItem()
            {
                Id = 2,
                Count = 1,
                vegetable = vegetable2,
                TotalPrice = vegetable1.Price
            }; 
            OrderItem orderItem3 = new OrderItem()
            {
                Id = 3,
                Count = 1,
                vegetable = vegetable3,
                TotalPrice = vegetable1.Price
            }; 
            OrderItem orderItem4 = new OrderItem()
            {
                Id = 4,
                Count = 3,
                vegetable = vegetable4,
                TotalPrice = vegetable1.Price*3
            };
            List<OrderItem> orderlist = new List<OrderItem>();
            orderlist.Add(orderItem1);
            orderlist.Add(orderItem2);
            orderlist.Add(orderItem3);
            orderlist.Add(orderItem4);
            Order order=new Order {Id=1, items=orderlist };
            var json = JsonConvert.SerializeObject(orderItem1);

            string result;

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Gunay\source\repos\MultiTasking\MultiTasking\Files\jsconfig1.json"))
            {
               sw.WriteLine(json);
            }
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Gunay\source\repos\MultiTasking\MultiTasking\Files\jsconfig1.json"))
            {
                result = streamReader.ReadToEnd();
            }

            var parseJson = JsonConvert.DeserializeObject<Order>(result);
            
            #endregion

        }
    }
}
