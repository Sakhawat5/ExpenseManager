using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ExpenseTrackerWebApp.Data.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        [Display(Name = "Expense Category")]
        [Remote(action: "IsExist", controller: "ExpenseCategory")]
        public string Category { get; set; }
    }
}
