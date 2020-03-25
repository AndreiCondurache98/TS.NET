using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            //TestPerson();
            TestOneToMany();
            TestManyToMany();

            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person p = new Person()
                {
                    FirstName = "Julie",
                    LastName = "Andrew",
                    MidleName = "T",
                    TelephonNumber = "1234567890"
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

        static void TestOneToMany()
        {
            Console.WriteLine("One to many association");
            using (ModelOneToManyContainer context = new ModelOneToManyContainer())
            {
                Customer c = new Customer()
                {
                    Name = "Customer 1",
                    City = "Iasi"
                };
                Order o1 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = 300,
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }
        static void TestManyToMany()
        {
            Console.WriteLine("Many to many association");
            using(ModelManyToManyContainer context = new ModelManyToManyContainer())
            {
                Album a1 = new Album()
                {
                    AlbumName = "Album 1"
                };

                Album a2 = new Album()
                {
                    AlbumName = "Album 2"
                };

                Artist art1 = new Artist()
                {
                    FirstName = "Kirk",
                    LastName = "Hammet"
                };

                Artist art2 = new Artist()
                {
                    FirstName = "James",
                    LastName = "Hatfield"
                };
                context.Albums.Add(a1);
                context.Albums.Add(a2);
                context.Artists.Add(art1);
                context.Artists.Add(art2);
                context.SaveChanges();

                art1.Albums.Add(a1);
                art1.Albums.Add(a2);
                art2.Albums.Add(a1);
                var items = context.Artists;
                foreach (var x in items)
                {
                    Console.WriteLine("Artist : {0}, {1}, {2}", x.ArtistId, x.FirstName, x.LastName);
                    foreach(var ox in x.Albums)
                    {
                        Console.WriteLine("\tAlbums: {0}, {1}", ox.AlbumId, ox.AlbumName);
                    }
                }
            }
        }   
    }
}
