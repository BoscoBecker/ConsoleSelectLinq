using ConsoleSelectLinq.Entities;

namespace ConsoleSelectLinq {
    
    internal static class Program {
        private static void Main() {
            var list = new List<Product>() {
                new Product("TV", 1000.00),
                new Product("TV 4K",1500.00)
            };
           
            // 🔍♻ Ways to use Select by Linq 🔍♻    
            
            var result1 = list.Select(NameUpper).ToList();
            foreach (var l in result1) {
                Console.WriteLine(l);
            }
            
            var result2 = list.Select(p =>p.Name.ToUpper());
            foreach (var ls in result2) {
                Console.WriteLine(ls);
            }
            
        }
        
        private static string NameUpper(Product product) => product.Name.ToUpper();
    }
}