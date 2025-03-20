using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250317
{
    class Program
    {
        struct Item
        {
            public string itemName;
            public string itemId;

            public Item(string name, string id)
            {
                itemName = name;
                itemId = id;
            }
        }

        struct Inventory
        {
            List<Item> items;
            int capacity;
            public Inventory(int size)
            {
                capacity = size;
                items = new List<Item>(size);
            }
            public void AddItem(Item item)
            {
                items.Add(item);
            }
            public void PrintInventory()
            {
                foreach (var item in items)
                    Console.WriteLine("아이템 이름 : {0}, 아이템 ID: {1}", item.itemName, item.itemId);
            }
            public Item? GetItemByName(string name)
            {
                return items.Find(item => item.itemName == name);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("인벤토리 크기를 입력하세요: ");
            int size = int.Parse(Console.ReadLine());
            Inventory inventory = new Inventory(size);

            while (true)
            {
                Console.WriteLine("아이템 추가 (이름과 ID 입력, 종료하려면 'exit' 입력):");
                Console.Write("아이템 이름: ");
                string name = Console.ReadLine();
                if (name.ToLower() == "exit") break;

                Console.Write("아이템 ID: ");
                string id = Console.ReadLine();

                inventory.AddItem(new Item(name, id));
            }

            Console.WriteLine("\n--- 현재 인벤토리 ---");
            inventory.PrintInventory();

            while (true)
            {
                Console.Write("검색할 아이템 이름 (종료하려면 'exit' 입력): ");
                string searchName = Console.ReadLine();
                if (searchName.ToLower() == "exit")
                        break;

                Item? foundItem = inventory.GetItemByName(searchName);
                if (foundItem.HasValue)
                    Console.WriteLine("아이템 이름: {0}, 아이템 ID: {1}", foundItem.Value.itemName, foundItem.Value.itemId);
                else
                    Console.WriteLine("해당 아이템을 찾을 수 없습니다.");
            }
        }
    }
}
