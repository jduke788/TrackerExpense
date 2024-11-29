using TrackerExpense.Shared.Models;

namespace BlazorExpenseTracker.Client.Services.ExpenseService
{
    public interface IExpenseService
    {

        List<ExpenseModel> Expenses { get; set; }
        decimal TotalExpenses { get; set; }

        Task<List<ExpenseModel>> GetExpensesAsync();
        Task<ExpenseModel> CreateExpenseAsync(ExpenseModel expense);
        Task<ExpenseModel> EditExpenseAsync(ExpenseModel expense, int id);
        Task RemoveExpense(int id);

        Task<ExpenseModel> GetExpenseDetailsAsync(int id);
    }
}
