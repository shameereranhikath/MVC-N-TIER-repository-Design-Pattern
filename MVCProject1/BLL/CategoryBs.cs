using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;
namespace BLL
{
    public class CategoryBs
    {
        private CategoryDb _objDAL;
        public CategoryBs()
        {
            _objDAL = new CategoryDb();

        }
        public IEnumerable<CATEGORy> GetAll()
        {
            return _objDAL.GetAll().ToList();
        }

        public CATEGORy  GetById(int id)
        {
            return _objDAL.GetByID(id);
        }

        public int GetByName(CATEGORy cat)
        {
            return _objDAL.GetByName(cat);
        }

        public void Insert(CATEGORy cat)
        {
            _objDAL.Insert(cat);

        }
        public void Update(CATEGORy cat)
        {
           
            _objDAL.Update(cat);


        }
        public void Delete(int id)
        {
            _objDAL.Delete(id);
        }


    }
}
