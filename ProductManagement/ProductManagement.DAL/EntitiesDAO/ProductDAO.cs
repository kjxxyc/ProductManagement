using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DAL.EntitiesDAO
{
    public class ProductDAO : BaseDAO<Product>
    {
        public List<Option> GetOptionsByProductId(int productId)
        {
            return _context.Options.Where(x => x.ProductId == productId).ToList();
        }

        public int AddOption(Option option, bool saveChanges = true)
        {
            var affectedRows = 0;

            _context.Options.Add(option);

            if (saveChanges)
            {
                affectedRows = _context.SaveChanges();
            }

            return affectedRows;
        }

        public int DeleteOption(Option option, bool saveChanges = true)
        {
            var affectedRows = 0;

            _context.Options.Remove(option);

            if (saveChanges)
            {
                affectedRows = _context.SaveChanges();
            }

            return affectedRows;
        }

        public int UpdateOption(Option option, bool saveChanges = true)
        {
            var affectedRows = 0;

            _context.Entry(option).State = System.Data.Entity.EntityState.Modified; 

            if (saveChanges)
            {
                affectedRows = _context.SaveChanges();
            }

            return affectedRows;
        }
    }
}
