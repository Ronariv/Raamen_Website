using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;
namespace PSDProject.Factory
{
    public class TransactionFactory
    {
        public static Header CreateTrHeader(int CustomerID, int StaffID, DateTime transactionDate)
        {
            return new Header
            {
                CustomerId = CustomerID,
                StaffId = StaffID,
                Date = transactionDate
            };
        }

        public static Detail CreateTrDetail(int headerID, int ramenID, int quantity)
        {
            return new Detail
            {
                HeaderId = headerID,
                RamenID = ramenID,
                Quantity = quantity
            };
        }
    }
}