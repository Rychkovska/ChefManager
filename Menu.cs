using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefManager
{
	public abstract class Menu
{
    public int Persons { get; private set; } // Кількість осіб

    public Menu(int persons)
    {
        Persons = persons;
    }
		// Конструктор без параметрів
		protected Menu() { }

		// Абстрактний метод для меню на день
		public abstract void GenerateMenu(int persons);

		// Абстрактний метод для званої вечері
		public abstract void GenerateDinnerParty(int persons);
		
}


}
