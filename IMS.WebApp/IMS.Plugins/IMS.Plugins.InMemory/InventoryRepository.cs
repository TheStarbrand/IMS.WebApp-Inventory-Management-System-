using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System.Security.Cryptography.X509Certificates;

namespace IMS.Plugins.InMemory
{
	public class InventoryRepository : IInventoryRepository
	{
		private List<Inventory> _inventories;

		public InventoryRepository() {
			_inventories = new()
			{
				new Inventory { InventoryID = 1, InventoryName = "Bike Seats", Quantity = 10, Price = 130 },

				new Inventory { InventoryID = 2, InventoryName = "Bike Handlebars", Quantity = 10, Price = 140 },

				new Inventory { InventoryID = 3, InventoryName = "Bike Pedal", Quantity = 10, Price = 100 },

				new Inventory { InventoryID = 4, InventoryName = "Bike Headlight", Quantity = 10, Price = 90 },

				new Inventory { InventoryID = 5, InventoryName = "Bike Reflector", Quantity = 10, Price = 96 },

				new Inventory { InventoryID = 6, InventoryName = "Bike Body", Quantity = 10, Price = 170 },

				new Inventory { InventoryID = 7, InventoryName = "Bike Wheel", Quantity = 10, Price = 170 },

				new Inventory { InventoryID = 8, InventoryName = "Bike Helmet", Quantity = 10, Price = 170 }
			};

		}
		public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
		{
			if (string.IsNullOrWhiteSpace(name)) return  await Task.FromResult(_inventories);
			return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
		}
	}
}
