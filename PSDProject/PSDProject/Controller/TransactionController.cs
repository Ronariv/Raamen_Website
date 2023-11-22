using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Handler;
using PSDProject.Model;
namespace PSDProject.Controller
{
    public class TransactionController
    {
        public static int CreateTransactionHeader(int UserId, int StaffId, DateTime date)
        {
            return TransactionHandler.CreateTransactionHeader(UserId, StaffId, date);
        }
        public static void CreateTransactionDetail(int headerId, int RamenId, int qty)
        {
            TransactionHandler.createTrDetail(headerId, RamenId, qty);
        }
        public static dynamic getAllTransactionHeader()
        {
            return TransactionHandler.getAllTransactionHeader();
        }
        public static dynamic getTransactionHeader(int CustomerId)
        {
            return TransactionHandler.getTransactionHeader(CustomerId);
        }
        public static dynamic getTrDetail(int HeaderId)
        {
            return TransactionHandler.getTrDetail(HeaderId);
        }

        public static dynamic getUnhandled()
        {
            return TransactionHandler.getUnhandled();
        }
        public static void handle(int headerId, int staffId)
        {
            TransactionHandler.handle(headerId, staffId);
        }
        public static void HandleAll(int staffId)
        {
            TransactionHandler.HandleAll(staffId);
        }

        public static List<Header> getTransactionHeaderReport()
        {
            return TransactionHandler.getTransactionHeaderReport();
        }
    }
}