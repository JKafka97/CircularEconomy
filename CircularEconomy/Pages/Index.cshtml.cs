using CircularEconomy.Data;
using CircularEconomy.Enums;
using CircularEconomy.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.FileIO;

namespace CircularEconomy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DbFiller _dbFiller;


        public IndexModel(ILogger<IndexModel> logger, DbFiller dbFiller)
        {
            _logger = logger;
            _dbFiller = dbFiller;
        }

        public void OnGet()
        {
            //FirstEvent = _dbContext.Event.Where(e => e.Id == 1).FirstOrDefault();
            //_dbFiller.CirkularniEkonomikaFiller();
            //_dbFiller.KontainerFiller();
            //_dbFiller.NeziskovkyFiller();
            //_dbFiller.KurzFiller();



        }
    }
}
