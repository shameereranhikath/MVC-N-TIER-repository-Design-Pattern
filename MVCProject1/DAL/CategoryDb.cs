using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class CategoryDb
    {
        private InventoryDBEntities db;
        public CategoryDb()
        {
            db = new InventoryDBEntities();
        }


        public IEnumerable<CATEGORy> GetAll()
        {
            return db.CATEGORIES.ToList();
        }

        public CATEGORy GetByID(int id)
        {
            return db.CATEGORIES.Find(id);
        }

        public int  GetByName(CATEGORy cat)
        {
            var val = db.CATEGORIES.Where(x=>x.CATNAME==cat.CATNAME && x.CAT_STATUS==cat.CAT_STATUS).FirstOrDefault();
            if (val!=null)
            {
                return 1;
            }
            else { return 0; }
        }

        public void Insert(CATEGORy cat)
        {
            db.CATEGORIES.Add(cat);
            SaveChanges();

        }
        public void Update(CATEGORy cat)
        {
            db.Entry(cat).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


        }
        public void Delete(int id)
        {
            CATEGORy cat = db.CATEGORIES.Find(id);
            db.CATEGORIES.Remove(cat);
            SaveChanges();
        }



        void SaveChanges()
        {
            db.SaveChanges();
        }


    }
}
