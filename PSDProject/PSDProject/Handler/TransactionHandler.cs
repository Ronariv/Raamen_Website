using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Repository;
using PSDProject.Model;
namespace PSDProject.Handler
{
    public class TransactionHandler
    {
        public static int CreateTransactionHeader(int UserId, int StaffId, DateTime date)
        {
            return TransactionRepository.CreateTransactionHeader(UserId, StaffId, date);
        }

        public static void createTrDetail(int HeaderId, int ramenId, int qty)
        {
            TransactionRepository.CreateTransactionDetail(HeaderId, ramenId, qty);
        }

        public static dynamic getAllTransactionHeader()
        {
            return TransactionRepository.getAllTransactionHeader();
        }
        public static dynamic getTransactionHeader(int CustomerId)
        {
            return TransactionRepository.getTransactionHeader(CustomerId);
        }
        public static dynamic getTrDetail(int HeaderId)
        {
            return TransactionRepository.getTrDetail(HeaderId);
        }
        public static dynamic getUnhandled()
        {
            return TransactionRepository.getUnhandled();
        }
        public static void handle(int headerId, int staffId)
        {
            TransactionRepository.handle(headerId, staffId);
        }
        public static void HandleAll(int staffId)
        {
            TransactionRepository.HandleAll(staffId);
        }

        public static List<Header> getTransactionHeaderReport()
        {
            return TransactionRepository.getTransactionHeaderReport();
        }
    }
}