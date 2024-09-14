namespace ConsoleApp6
{
    class ProductInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberInStock { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0}, Description={1}, Number in Stock={2}",
            Name, Description, NumberInStock);
        }
    }
    class Entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");
            // This array will be the basis of our testing...
            ProductInfo[] itemsInStock = new[]
             {
        new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH",
                                         NumberInStock = 24},
        new ProductInfo { Name = "Milk Maid Milk",Description = "Milk cow's love",
                                            NumberInStock = 100},
         new ProductInfo{ Name = "Pure Silk Tofu",  Description = "Bland as Possible",
                                            NumberInStock = 120},
        new ProductInfo{ Name = "Cruchy Pops",  Description = "Cheezy, peppery goodness",
                                        NumberInStock = 2},
       new ProductInfo{ Name = "RipOff Water",   Description = "From the tap to your wallet",
                                        NumberInStock = 100},
    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!",
         NumberInStock = 73}
            };
            var detail = from item in itemsInStock
                         select item;
            foreach(var item in detail)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.NumberInStock);
            }

            var detail1 = itemsInStock.Select(item => item);
            foreach(var item1 in detail1) 
            {
                Console.WriteLine("by use " + item1.Name);
                Console.WriteLine("by use " + item1.Description);
                Console.WriteLine("by use " + item1.NumberInStock);
            }
            Console.WriteLine("=============================================================================");

            var name=from i in itemsInStock
                     select i.Name;

            foreach(var i in name) 
            {
                Console.WriteLine(i);            
            }

            var name2 =itemsInStock.Select(item => item.Name);
            foreach(var item in name2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================================================================");
            var data=from i in itemsInStock
                     select new { Name = i.Name, Description = i.Description,NumberInStock=i.NumberInStock };
            foreach(var item in data)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------------------------");

            var data2=itemsInStock.Select(i => new { Name = i.Name, Description = i.Description, NumberInStock = i.NumberInStock });
            foreach(var item in data2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=======================================================================");
            var b = from i in itemsInStock
                    where i.NumberInStock == 100
                    select new { Name = i.Name, Description = i.Description, NumberInStock = i.NumberInStock };

            foreach(var item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            var b2=itemsInStock.Where(i=>i.NumberInStock == 100).Select(i => new { Name = i.Name, Description = i.Description, NumberInStock = i.NumberInStock });
            foreach (var item in b2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================================================");

            IOrderedEnumerable<ProductInfo> display = from i in itemsInStock
                          where i.Name.Contains("s")
                          orderby i
                          select i;

            foreach (var item in display)
            {
                Console.WriteLine(item);
            }

            //var dispaly1=itemsInStock.Where(i=>i.Name.Contains("s").orderby(i=>i).select(i=>i));
    }

}
}
