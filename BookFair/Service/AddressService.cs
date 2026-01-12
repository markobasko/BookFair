using BookFair.DAO;
using BookFair.Model;

namespace BookFair.Service
{
    public class AddressService
    {
        private readonly AddressDAO _addressDAO;
        public AddressService()
        {
            _addressDAO = new AddressDAO();
        }
        public List<Address> GetAll()
        {
            List<Address> addresses = _addressDAO.GetAll();
            return addresses;
        }
        public Address GetById(int id)
        {
            return _addressDAO.GetById(id);
        }
        public void Add(Address addresses)
        {
            if (addresses == null)
                throw new ArgumentNullException(nameof(addresses), "Address cannot be null.");
            _addressDAO.Add(addresses);
        }
        public void Remove(int addressId)
        {
            _addressDAO.Remove(addressId);
        }
        public void Update(Address address)
        {
            if (address == null)
                throw new ArgumentNullException(nameof(address), "Address cannot be null.");
            _addressDAO.Update(address);
        }
    }
}
