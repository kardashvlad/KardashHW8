using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    // Було порушено принцип єдиного обов'язку
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        protected ItemFunctionality _itemFunctionality;
        protected OrderFunctionality _orderFunctionality;
        protected ConfigurationFunctionality _configurationFunctionality;

        public void CreateOrder()
        {
            _configurationFunctionality.Load();
            _itemFunctionality.AddItem(new Item());
            _itemFunctionality.CalculateTotalSum();
            _orderFunctionality.PrintOrder();
            _configurationFunctionality.Save();
        }
    }

    class ItemFunctionality
    {
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    class OrderFunctionality
    {
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }
    class ConfigurationFunctionality
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }


    class Program
    {
        static void Main()
        {
            Order order = new Order();
            order.CreateOrder();
        }
    }
}
