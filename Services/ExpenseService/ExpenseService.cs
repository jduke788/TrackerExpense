using TrackerExpense.Shared.Models;
using System.Net.Http.Json;
using BlazorExpenseTracker.Client.Services.ExpenseService;

namespace TrackerExpense.Client.Services.ExpenseService
{
    public class ExpenseService : IExpenseService
    {
        private readonly HttpClient _http;

        public ExpenseService(HttpClient http)
        {
            _http = http;
        }


        public List<ExpenseModel> Expenses { get; set; }
        public decimal TotalExpenses { get; set; }

        public async Task<ExpenseModel> CreateExpenseAsync(ExpenseModel expense)
        {
            var response = await _http.PostAsJsonAsync<ExpenseModel>("/api/Expenses", expense);
            return await response.Content.ReadFromJsonAsync<ExpenseModel>();
        }

        public async Task<ExpenseModel> EditExpenseAsync(ExpenseModel expense, int id)
        {
            var response = await _http.PutAsJsonAsync<ExpenseModel>($"/api/Expenses/{id}", expense);
            return await response.Content.ReadFromJsonAsync<ExpenseModel>();
        }

        public async Task<List<ExpenseModel>> GetExpensesAsync()
        {
            var response = await _http.GetFromJsonAsync<List<ExpenseModel>>("/api/Expenses");

            if (response != null)
            {
                Expenses = response;

                CalculateTotalExpenses();

            }

            return Expenses;
        }

        public Task RemoveExpense(int id)
        {
            throw new NotImplementedException();
        }

        private void CalculateTotalExpenses()
        {
            TotalExpenses = 0;

            foreach (var expense in Expenses)
            {
                TotalExpenses += expense.Amount;
            }
        }

        public async Task<ExpenseModel> GetExpenseDetailsAsync(int id)
        {
            var response = await _http.GetFromJsonAsync<ExpenseModel>($"/api/Expenses/{id}");

            return response;

        }

    }
}
