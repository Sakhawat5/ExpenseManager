using ExpenseManager.Interfaces;
using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class ExpensesDataAcessLayer : IExpenseService
    {
        private ExpenseDBContext db;

        public ExpensesDataAcessLayer(ExpenseDBContext _db)
        {
            db = _db;
        }

        // To calculate last six months expense
        public Dictionary<string, decimal> CalculateMonthlyExpense()
        {
            List<ExpenseReport> lstEmployee = new List<ExpenseReport>();

            Dictionary<string, decimal> dictMonthlySum = new Dictionary<string, decimal>();

            decimal waterBillSum = db.ExpenseReports.Where
                (cat => cat.ExpenseCategory.Category == "Water Bill" && (cat.ExpenseDate > DateTime.Now.AddMonths(-7)))
                .Select(cat => cat.Amount)
                .Sum();

            decimal electricBillSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Electric Bill" && (cat.ExpenseDate > DateTime.Now.AddMonths(-7)))
               .Select(cat => cat.Amount)
               .Sum();

            decimal groceriesSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Groceries" && (cat.ExpenseDate > DateTime.Now.AddMonths(-7)))
               .Select(cat => cat.Amount)
               .Sum();

            decimal uberSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Uber" && (cat.ExpenseDate > DateTime.Now.AddMonths(-7)))
               .Select(cat => cat.Amount)
               .Sum();
            decimal medicationSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Medication" && (cat.ExpenseDate > DateTime.Now.AddMonths(-7)))
               .Select(cat => cat.Amount)
               .Sum();
            decimal houseRendSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "House Rent" && (cat.ExpenseDate > DateTime.Now.AddMonths(-7)))
               .Select(cat => cat.Amount)
               .Sum();

            dictMonthlySum.Add("Water Bill", waterBillSum);
            dictMonthlySum.Add("Electric Bill", electricBillSum);
            dictMonthlySum.Add("Groceries", groceriesSum);
            dictMonthlySum.Add("Uber", uberSum);
            dictMonthlySum.Add("Medication", medicationSum);
            dictMonthlySum.Add("House Rent", houseRendSum);

            return dictMonthlySum;
        }

        // To calculate last four weeks expense
        public Dictionary<string, decimal> CalculateWeeklyExpense()
        {
            List<ExpenseReport> lstEmployee = new List<ExpenseReport>();

            Dictionary<string, decimal> dictWeeklySum = new Dictionary<string, decimal>();

            decimal waterBillSum = db.ExpenseReports.Where
                (cat => cat.ExpenseCategory.Category == "Water Bill" && (cat.ExpenseDate > DateTime.Now.AddDays(-28)))
                .Select(cat => cat.Amount)
                .Sum();

            decimal electricBillSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Electric Bill" && (cat.ExpenseDate > DateTime.Now.AddDays(-28)))
               .Select(cat => cat.Amount)
               .Sum();

            decimal groceriesSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Groceries" && (cat.ExpenseDate > DateTime.Now.AddDays(-28)))
               .Select(cat => cat.Amount)
               .Sum();

            decimal uberSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Uber" && (cat.ExpenseDate > DateTime.Now.AddDays(-28)))
               .Select(cat => cat.Amount)
               .Sum();
            decimal medicationSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Medication" && (cat.ExpenseDate > DateTime.Now.AddMonths(-28)))
               .Select(cat => cat.Amount)
               .Sum();
            decimal houseRendSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "House Rent" && (cat.ExpenseDate > DateTime.Now.AddMonths(-28)))
               .Select(cat => cat.Amount)
               .Sum();

            dictWeeklySum.Add("Water Bill", waterBillSum);
            dictWeeklySum.Add("Electric Bill", electricBillSum);
            dictWeeklySum.Add("Groceries", groceriesSum);
            dictWeeklySum.Add("Uber", uberSum);
            dictWeeklySum.Add("Medication", medicationSum);
            dictWeeklySum.Add("House Rent", houseRendSum);

            return dictWeeklySum;
        }

        // To calculate last four weeks expense
        public Dictionary<string, decimal> CalculateDailyExpense()
        {
            List<ExpenseReport> lstEmployee = new List<ExpenseReport>();

            Dictionary<string, decimal> dictWeeklySum = new Dictionary<string, decimal>();

            decimal waterBillSum = db.ExpenseReports.Where
                (cat => cat.ExpenseCategory.Category == "Water Bill" && (cat.ExpenseDate > DateTime.Now.AddDays(-1)))
                .Select(cat => cat.Amount)
                .Sum();

            decimal electricBillSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Electric Bill" && (cat.ExpenseDate > DateTime.Now.AddDays(-1)))
               .Select(cat => cat.Amount)
               .Sum();

            decimal groceriesSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Groceries" && (cat.ExpenseDate > DateTime.Now.AddDays(-1)))
               .Select(cat => cat.Amount)
               .Sum();

            decimal uberSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Uber" && (cat.ExpenseDate > DateTime.Now.AddDays(-1)))
               .Select(cat => cat.Amount)
               .Sum();
            decimal medicationSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "Medication" && (cat.ExpenseDate > DateTime.Now.AddDays(-1)))
               .Select(cat => cat.Amount)
               .Sum();
            decimal houseRendSum = db.ExpenseReports.Where
               (cat => cat.ExpenseCategory.Category == "House Rent" && (cat.ExpenseDate > DateTime.Now.AddDays(-1)))
               .Select(cat => cat.Amount)
               .Sum();

            dictWeeklySum.Add("Water Bill", waterBillSum);
            dictWeeklySum.Add("Electric Bill", electricBillSum);
            dictWeeklySum.Add("Groceries", groceriesSum);
            dictWeeklySum.Add("Uber", uberSum);
            dictWeeklySum.Add("Medication", medicationSum);
            dictWeeklySum.Add("House Rent", houseRendSum);

            return dictWeeklySum;
        }
    }
}
