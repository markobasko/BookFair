using BookFair.Model;
using BookFair.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFair.DAO
{
    public class AddressDAO : IDAO<Address>
    {
        private readonly List<Address> _addresses;
        private readonly Storage<Address> _storage;
        public AddressDAO()
        {
            _storage = new Storage<Address>("addresses.txt");
            _addresses = _storage.Load();
        }

        private int GenerateId()
        {
            if (_addresses.Count == 0)
                return 0;
            return _addresses.Max(a => a.Id) + 1;
        }

        public Address GetById(int id)
        {
            var address = _addresses.FirstOrDefault(a => a.Id == id);
            return address == null ? throw new KeyNotFoundException($"Address with ID {id} not found.") : address;
        }

        public void Add(Address item)
        {
            item.Id = GenerateId();
            _addresses.Add(item);
            _storage.Save(_addresses);
        }

        public void Remove(int id)
        {
            Address address = GetById(id);
            _addresses.Remove(address);
            _storage.Save(_addresses);
        }

        public void Update(Address item)
        {
            var index = _addresses.FindIndex(a => a.Id == item.Id);
            if (index != -1)
            {
                _addresses[index] = item;
                _storage.Save(_addresses);
            }
            else
            {
                throw new KeyNotFoundException($"Address with ID {item.Id} not found.");
            }
        }

        public List<Address> GetAll()
        {
            return _addresses;
        }

       
    }
}
