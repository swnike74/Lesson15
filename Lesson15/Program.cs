namespace Lesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new Customer[]
           {
               new Customer{ID = 5, Name = "Андрей"},
               new Customer{ID = 6, Name = "Сергей"},
               new Customer{ID = 7, Name = "Юлия"},
               new Customer{ID = 8, Name = "Анна"}
           };

            var orders = new Order[]
            {
               new Order{ID = 6, Product = "Игру"},
               new Order{ID = 7, Product = "Компьютер"},
               new Order{ID = 3, Product = "Рубашку"} ,
               new Order{ID = 5, Product = "Книгу"}
            };

            var query = from c in customers
                        join o in orders on c.ID equals o.ID
                        select new { c.Name, o.Product };
            foreach (var group in query)
                Console.WriteLine($"{group.Name} покупает {group.Product}");
        }
    }
}
