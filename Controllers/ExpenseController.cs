using TrackerExpense.Server.Data;
using TrackerExpense.Server.Services.ExpenseService;
using TrackerExpense.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TrackerExpense.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpensesController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ExpenseModel>>> GetAllExpensesAsync()
        {
            List<ExpenseModel> response = await _expenseService.GetExpensesAsync();
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ExpenseModel>> CreateExpenseAsync(ExpenseModel expense)
        {
            ExpenseModel response = await _expenseService.CreateExpensesAsync(expense);
            return Ok(response);

        }
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<ExpenseModel>> EditExpenseAsync(ExpenseModel expense, int id)
        {
            ExpenseModel resoponse = await _expenseService.EditExpenseAsync(expense, id);
            return Ok(resoponse);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task RemoveExpense(int id)
        {
            await _expenseService.RemoveExpense(id);
        }

        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ExpenseModel>> GetExpenseDetailsAsync(int id)
        {
            var response = await _expenseService.GetExpenseDetailsAsync(id);
            return Ok(response);
        }

    }
}
