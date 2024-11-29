using TrackerExpense.Shared.Models;

namespace TrackerExpense.Server.Services.ExpenseService
{
    public interface IExpenseService
    {

        Task<List<ExpenseModel>> GetExpensesAsync();
        Task<ExpenseModel> CreateExpensesAsync(ExpenseModel expense);
        Task<ExpenseModel> EditExpenseAsync(ExpenseModel expense, int id);
        Task RemoveExpense(int id);

        Task<ExpenseModel> GetExpenseDetailsAsync(int id);

    }
}
