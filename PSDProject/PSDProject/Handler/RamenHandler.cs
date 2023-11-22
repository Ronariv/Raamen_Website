using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Repository;
using PSDProject.Model;
namespace PSDProject.Handler
{
    public class RamenHandler
    {
        public static Ramen getRamen(int id)
        {
            return RamenRepository.getRamen(id);
        }
        public static List<Meat> getMeatList()
        {
            return RamenRepository.getMeatList();
        }
        public static dynamic getRamenList()
        {
            return RamenRepository.getRamenList();
        }
        public static void CreateRamen(string name, int meat, string broth, int price)
        {
            RamenRepository.CreateRamen(name, meat, broth, price);
        }
        public static void DeleteRamen(string id)
        {
            RamenRepository.DeleteRamen(id);
        }
        public static void UpdateRamen(string id,string name, int meat, string broth, int price)
        {
            RamenRepository.UpdateRamen(id, name, meat, broth, price);
        }
    }
}