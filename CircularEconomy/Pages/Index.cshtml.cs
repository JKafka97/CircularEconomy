using CircularEconomy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CircularEconomy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CircularEconomyDbContext _dbContext;

        public IndexModel(ILogger<IndexModel> logger, CircularEconomyDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public Event FirstEvent { get; private set; }

        public void OnGet()
        {
            FirstEvent = _dbContext.Event.Where(e => e.Id == 1).FirstOrDefault();

            _logger.LogDebug($"{_dbContext.Event.Where(e => e.Id==1).FirstOrDefault()}");
        }
    }
}
