using BookFair.DAO;
using BookFair.Model;

namespace BookFair.Service
{
    public class VisitorService
    {
        private readonly VisitorDAO _visitorDAO;
        public VisitorService()
        {
            _visitorDAO = new VisitorDAO();
        }
        public List<Visitor> GetAll()
        {
            List<Visitor> visitors = _visitorDAO.GetAll();
            return visitors;
        }
        public Visitor GetById(int id)
        {
            return _visitorDAO.GetById(id);
        }
        public void Add(Visitor visitor)
        {
            if (visitor == null)
                throw new ArgumentNullException(nameof(visitor), "Visitor cannot be null.");
            _visitorDAO.Add(visitor);
        }
        public void Remove(int visitorId)
        {
            _visitorDAO.Remove(visitorId);
        }
        public void Update(Visitor visitor)
        {
            if (visitor == null)
                throw new ArgumentNullException(nameof(visitor), "Visitor cannot be null.");
            _visitorDAO.Update(visitor);
        }
    }
}
