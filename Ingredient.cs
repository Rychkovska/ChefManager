namespace ChefManager
{
	public class Ingredient
	{
		public string Name { get; set; }
		public string Category { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }

			// Конструктор без аргументів
			public Ingredient()
			{
			}

			// Конструктор з аргументами
			public Ingredient(string name, string category, double price, int quantity)
			{
				Name = name;
				Category = category;
				Price = price;
				Quantity = quantity;
			}
	}	
}
