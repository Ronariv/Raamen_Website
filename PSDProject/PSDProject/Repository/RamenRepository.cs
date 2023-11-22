using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;
using PSDProject.Factory;

namespace PSDProject.Repository
{
    public class RamenRepository
    {
        private static Database1Entities1 db = new Database1Entities1();

        public static void CreateRamen(string name, int meatid, string broth, int price)
        {
            db.Ramen1.Add(RamenFactory.CreateRamen(name, meatid, broth, price));
            db.SaveChanges();
        }

        public static void DeleteRamen(string id)
        {
            int idUpdate = Convert.ToInt32(id);
            Ramen ramen = db.Ramen1.Where(x => x.Id == idUpdate).FirstOrDefault();
            if (ramen == null) return;
            db.Ramen1.Remove(ramen);
            db.SaveChanges();
        }
        public static void UpdateRamen(string id, string name, int meatid, string broth, int price)
        {
            int idUpdate = Convert.ToInt32(id);
            Ramen ramen = db.Ramen1.Where(x => x.Id == idUpdate).FirstOrDefault();
            if (ramen == null) return;
            ramen.Name = name;
            ramen.Meatid = meatid;
            ramen.Broth = broth;
            ramen.Price = price;
            db.SaveChanges();
        }
        public static dynamic getRamenList()
        {
            return db.Ramen1.Join(db.Meats,
                ramen => ramen.Meatid,
                meat => meat.Id,
                (ramen, meat) => new
                {
                    Id = ramen.Id,
                    Name = ramen.Name,
                    Meat = meat.Name,
                    Broth = ramen.Broth,
                    Price = ramen.Price
                }).ToList();
        }

        public static Ramen getRamen(int id)
        {
            Ramen ramen = db.Ramen1.Find(id);

            return ramen;
        }
        public static List<Meat> getMeatList()
        {
            List<Meat> meatList = (from meat in db.Meats select meat).ToList();
            return meatList;
        }
    }
}