using System.Linq;
using SportStore.Models;
using Xunit;

namespace SportStore.Tests
{
    public class CartTests
    {
        [Fact]
        public void Can_Add_New_Lines()
        {
            Product p1 = new Product {ProductID = 1, Name = "P1"};
            Product p2 = new Product {ProductID = 2, Name = "P2"};

            Cart target = new Cart();
            
            target.AddItem(p1,1);
            target.AddItem(p2,2);

            CartLine[] lines = target.Lines.ToArray();
            
            Assert.Equal(2,lines.Length);
            Assert.Equal(lines[0].Product,p1);
            Assert.Equal(lines[1].Product,p2);
            
        }

        [Fact]
        public void Can_Add_Quantity_For_Existing_Lines()
        {
            Product p1 = new Product {ProductID = 1, Name = "P1"};
            Product p2 = new Product {ProductID = 2, Name = "P2"};

            Cart target = new Cart();
            
            target.AddItem(p1,1);
            target.AddItem(p2,1);
            target.AddItem(p1,10);

            CartLine[] lines = target.Lines.OrderBy(p=>p.Product.ProductID).ToArray();
            
            Assert.Equal(2,lines.Length);
            Assert.Equal(lines[0].Quantity,11);
            Assert.Equal(lines[1].Quantity,1);
        }

        [Fact]
        public void Can_Remove_Line()
        {
            Product p1 = new Product {ProductID = 1, Name = "P1"};
            Product p2 = new Product {ProductID = 2, Name = "P2"};
            Product p3 = new Product {ProductID = 3, Name = "P3"};

            Cart target = new Cart();
            
            target.AddItem(p1,1);
            target.AddItem(p2,3);
            target.AddItem(p3,5);
            target.AddItem(p2,1);
            
            target.RemoveLine(p2);
            
            Assert.Equal(0,target.Lines.Where(p=>p.Product == p2).Count());
            Assert.Equal(2,target.Lines.Count());
        }

        [Fact]
        public void Calcualte_Cart_Total()
        {
            Product p1 = new Product {ProductID = 1, Name = "P1", Price = 100M};
            Product p2 = new Product {ProductID = 2, Name = "P2", Price = 50M};

            Cart target = new Cart();
            
            target.AddItem(p1,1);
            target.AddItem(p2,1);
            target.AddItem(p1,3);

            decimal result = target.ComputeTotalValue();
            
            Assert.Equal(450M,result);
        }

        [Fact]
        public void Can_Clear_Contents()
        {
            Product p1 = new Product {ProductID = 1, Name = "P1", Price = 100M};
            Product p2 = new Product {ProductID = 2, Name = "P2", Price = 50M};

            Cart target = new Cart();
            
            target.AddItem(p1,1);
            target.AddItem(p2,1);
            
            target.Clear();
            
            Assert.Equal(0,target.Lines.Count());
        }
    }
}