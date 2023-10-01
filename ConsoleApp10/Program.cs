using System;

namespace internet_Magazine
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsSelected { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            IsSelected = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Ноутбук", 20000.00m);
            Product product2 = new Product("Смартфон", 5000.00m);
            Product product3 = new Product("Планшет", 4000.00m);
            Product product4 = new Product("Клавиатура", 590.00m);
            Product product5 = new Product("Мышь", 600.00m);

            Console.WriteLine("1. " + product1.Name + ", " + product1.Price + "грн");
            Console.WriteLine("2. " + product2.Name + ", " + product2.Price + "грн");
            Console.WriteLine("3. " + product3.Name + ", " + product3.Price + "грн");
            Console.WriteLine("4. " + product4.Name + ", " + product4.Price + "грн");
            Console.WriteLine("5. " + product5.Name + ", " + product5.Price + "грн");

            Console.WriteLine("Выберите продукт (1-5):");
            int choice = int.Parse(Console.ReadLine());

            
            if (choice >= 1 && choice <= 5)
            {
                Product selectedProduct = null;

               
                switch (choice)
                {
                    case 1:
                        selectedProduct = product1;
                        break;
                    case 2:
                        selectedProduct = product2;
                        break;
                    case 3:
                        selectedProduct = product3;
                        break;
                    case 4:
                        selectedProduct = product4;
                        break;
                    case 5:
                        selectedProduct = product5;
                        break;
                }

                if (selectedProduct != null)
                {
                    selectedProduct.IsSelected = true;
                    Console.WriteLine("Вы выбрали продукт: " + selectedProduct.Name);
                    Console.WriteLine("С вас: " + selectedProduct.Price + "грн");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный выбор продукта.");
            }
        }
    }
}



