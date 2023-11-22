using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;
using PSDProject.Factory;
namespace PSDProject.Repository
{
    public class TransactionRepository
    {
        private static Database1Entities1 db = new Database1Entities1();
        public static int CreateTransactionHeader(int userId, int staffId, DateTime date)
        {
            Header header = db.Headers.Add(TransactionFactory.CreateTrHeader(userId, staffId, date));
            db.SaveChanges();
            return header.Id;
        }

        public static void CreateTransactionDetail(int HeaderId, int RamenId, int qty)
        {
            db.Details.Add(TransactionFactory.CreateTrDetail(HeaderId, RamenId, qty));
            db.SaveChanges();
        }

        public static dynamic getAllTransactionHeader()
        {
            var transaction = db.Headers.Join(
                db.Users,
                head => head.StaffId,
                staff => staff.Id,
                (head, staff) => new
                {
                    Id = head.Id,
                    Customer = head.CustomerId,
                    Date = head.Date,
                    Staff = staff.Username
                }
                ).ToList();
            return transaction;
        }
        public static dynamic getTransactionHeader(int CustomerId)
        {
            //nama customer tidak dishow karena yang login customer sendiri
            var transaction = db.Headers.Where(x=> x.CustomerId == CustomerId).Join(
                db.Users,
                head => head.StaffId,
                staff => staff.Id,
                (head, staff) => new
                {
                    Id = head.Id,
                    Customer = head.CustomerId,
                    Date = head.Date,
                    Staff = staff.Username
                }
                ).ToList();
            return transaction;
        }
        public static dynamic getTrDetail(int HeaderId)
        {
            var trDetail = db.Details.Where(x => x.HeaderId == HeaderId).Join(
                db.Ramen1,
                detail => detail.RamenID,
                ramen => ramen.Id,
                (detail, ramen) => new
                {
                    HeaderId = detail.HeaderId,
                    Ramen = ramen.Name,
                    Quantity = detail.Quantity
                }).ToList();
            return trDetail;
        }
        public static dynamic getUnhandled()
        {
            //untuk nama staff tidak ditunjukan karena blum dihandle
            var unhandled = db.Headers.Where(x => x.CustomerId == x.StaffId).Join(
                db.Users,
                head => head.CustomerId,
                user => user.Id,
                (head,user) => new
                {
                    Id = head.Id,
                    Customer = user.Username,
                    Date = head.Date
                }

                ).ToList();
            return unhandled;
        }
        public static void handle(int headerId, int staffId)
        {
            var header = db.Headers.Find(headerId);
            if (header == null) return;

            header.StaffId = staffId;
            db.SaveChanges();
        }

        public static void HandleAll(int staffId)
        {
            var unhandled = db.Headers.Where(x => x.CustomerId == x.StaffId).FirstOrDefault();
            do
            {
                unhandled.StaffId = staffId;
                db.SaveChanges();
                unhandled = db.Headers.Where(x => x.CustomerId == x.StaffId).FirstOrDefault();
            } while (unhandled != null);
        }
        
        public static List<Header> getTransactionHeaderReport()
        {
            return db.Headers.ToList();
        }
    }
}