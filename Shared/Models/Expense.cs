using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerExpense.Shared.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; } = 0.0M;
        public DateTime CreatedAt { get; set; }
    }
}

