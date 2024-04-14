using CircularEconomy.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CircularEconomy.Pages
{
    public class FindModel : PageModel
    {
        private readonly CircularEconomyDbContext _dbContext;
        public List<Place> ToShow { get; private set; } = new List<Place>();

        public FindModel(CircularEconomyDbContext dbContext)
        {
            _dbContext = dbContext;
            ToShow.AddRange(_dbContext.Place);
        }

        public void OnPost(string secondhand,
            string markets, string nopackmarkets, string ecopackage,
            string localdeliver, string bedynky, string swap,
            string sdilenadilna, string kontejnery, string nonprofitorg,
            string reuse, string fixclothes, string fixshoes, string fixstuff, string pscInput

            )
        {
            IQueryable<Place> Places = _dbContext.Place;

            if (!string.IsNullOrEmpty(pscInput))
                ToShow.AddRange(Places.Where(x => x.PSC == pscInput));

            if (!string.IsNullOrEmpty(secondhand))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.textil &&
                                        x.ActivityOption == Enums.ActivityOption.second_hand));
            if (!string.IsNullOrEmpty(markets))
                ToShow.AddRange(Places.Where(x => (x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.textil &&
                                        x.ActivityOption == Enums.ActivityOption.bazar) ||
                                        (x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.domacnost &&
                                        x.ActivityOption == Enums.ActivityOption.bazar)));
            if (!string.IsNullOrEmpty(nopackmarkets))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.potraviny &&
                                        x.ActivityOption == Enums.ActivityOption.bezobalový_obchod));
            if (!string.IsNullOrEmpty(ecopackage))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.potraviny &&
                                        x.ActivityOption == Enums.ActivityOption.eko_obal));
            if (!string.IsNullOrEmpty(localdeliver))
                ToShow.AddRange(Places.Where(x => (x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.potraviny &&
                                        x.ActivityOption == Enums.ActivityOption.lokální_dodavatel) ||
                                        (x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.domacnost &&
                                        x.ActivityOption == Enums.ActivityOption.lokální_dodavatel) ||
                                        (x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.textil &&
                                        x.ActivityOption == Enums.ActivityOption.lokální_dodavatel)
                                        ));
            if (!string.IsNullOrEmpty(bedynky))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.nakoupit_udržitelně &&
                                        x.TypeTag == Enums.TypeTag.potraviny &&
                                        x.ActivityOption == Enums.ActivityOption.bedýnky));
            if (!string.IsNullOrEmpty(swap))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.vyměnit &&
                                        x.TypeTag == Enums.TypeTag.domacnost &&
                                        x.ActivityOption == Enums.ActivityOption.swap));
            if (!string.IsNullOrEmpty(sdilenadilna))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.opravit &&
                                        x.TypeTag == Enums.TypeTag.domacnost &&
                                        x.ActivityOption == Enums.ActivityOption.sdílená_dílna));
            if (!string.IsNullOrEmpty(kontejnery))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.darovat &&
                                        x.TypeTag == Enums.TypeTag.textil &&
                                        x.ActivityOption == Enums.ActivityOption.kontejner));
            if (!string.IsNullOrEmpty(nonprofitorg))
                ToShow.AddRange(Places.Where(x => (x.PlaceActivity == Enums.PlaceActivity.darovat &&
                                        x.TypeTag == Enums.TypeTag.textil &&
                                        x.ActivityOption == Enums.ActivityOption.nezísková_organizace) ||
                                        (x.PlaceActivity == Enums.PlaceActivity.darovat &&
                                        x.TypeTag == Enums.TypeTag.potraviny &&
                                        x.ActivityOption == Enums.ActivityOption.nezísková_organizace) ||
                                        (x.PlaceActivity == Enums.PlaceActivity.darovat &&
                                        x.TypeTag == Enums.TypeTag.domacnost &&
                                        x.ActivityOption == Enums.ActivityOption.nezísková_organizace)));
            if (!string.IsNullOrEmpty(reuse))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.darovat &&
                                        x.TypeTag == Enums.TypeTag.domacnost &&
                                        x.ActivityOption == Enums.ActivityOption.re_use_centrum));
            if (!string.IsNullOrEmpty(fixclothes))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.opravit &&
                                        x.TypeTag == Enums.TypeTag.textil &&
                                        x.ActivityOption == Enums.ActivityOption.oprava_oděvů));
            if (!string.IsNullOrEmpty(fixshoes))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.opravit &&
                                        x.TypeTag == Enums.TypeTag.textil &&
                                        x.ActivityOption == Enums.ActivityOption.oprava_obuvi));
            if (!string.IsNullOrEmpty(fixstuff))
                ToShow.AddRange(Places.Where(x => x.PlaceActivity == Enums.PlaceActivity.opravit &&
                                        x.TypeTag == Enums.TypeTag.domacnost &&
                                        x.ActivityOption == Enums.ActivityOption.oprava_spotřebičů));

            if (ToShow.Count() == 0)
            {
                ToShow.AddRange(Places);
            }
        }
    }
}