using CircularEconomy.Data;
using CircularEconomy.Enums;
using Microsoft.VisualBasic.FileIO;

namespace CircularEconomy.Helpers;

public class DbFiller(CircularEconomyDbContext circularEconomyDbContext)
{
    private readonly CircularEconomyDbContext _circularEconomyDbContext = circularEconomyDbContext;

    public void CirkularniEkonomikaFiller()
    {
        try
        {
            using var csvParser = new TextFieldParser("C:\\git\\CircularEconomy\\CircularEconomy\\Pages\\data\\cirkulární_ekonomika_v2.csv");
            csvParser.CommentTokens = ["#"];
            csvParser.SetDelimiters(["/n"]);
            csvParser.HasFieldsEnclosedInQuotes = true;

            // Skip the row with the column names
            csvParser.ReadLine();

            while (!csvParser.EndOfData)
            {
                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();
                var lineSplit = fields[0].Split(';');
                var formatActivityOption = lineSplit[3].Replace("-", "_").Replace(" ", "_");
                if (formatActivityOption == "lokální_dodavatel_" ||
                    formatActivityOption == "oprava_spotřebičů_" ||
                    formatActivityOption == "oprava_oděvů_" ||
                    formatActivityOption == "oprava_obuvi_")
                {
                    formatActivityOption = formatActivityOption.Substring(0, formatActivityOption.Length - 1);
                }

                var placeActivityoption = lineSplit[2].Replace("-", "_").Replace(" ", "_");
                var placeActivity = (PlaceActivity)Enum.Parse(typeof(PlaceActivity), placeActivityoption);
                var typeTag = (TypeTag)Enum.Parse(typeof(TypeTag), lineSplit[1]);
                var activityOption = (ActivityOption)Enum.Parse(typeof(ActivityOption), formatActivityOption);

                _circularEconomyDbContext.Place.Add(new Place
                {
                    ActivityOption = activityOption,
                    PlaceActivity = placeActivity,
                    TypeTag = typeTag,
                    Name = lineSplit[0],
                    Contact = lineSplit[7],

                        Ulice = lineSplit[4],
                        CisloPopisne = lineSplit[5],
                        PSC = lineSplit[6]
                    
                });
                _circularEconomyDbContext.SaveChanges();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
        }
    }

    public void KontainerFiller()
    {
        using var csvParser = new TextFieldParser("C:\\git\\CircularEconomy\\CircularEconomy\\Pages\\data\\kontejnery_v2.csv");
        csvParser.CommentTokens = ["#"];
        csvParser.SetDelimiters(["/n"]);
        csvParser.HasFieldsEnclosedInQuotes = true;

        // Skip the row with the column names
        csvParser.ReadLine();

        while (!csvParser.EndOfData)
        {
            // Read current line fields, pointer moves to the next line.
            string[] fields = csvParser.ReadFields();
            var lineSplit = fields[0].Split(';');
            var formatActivityOption = lineSplit[3].Replace("-", "_").Replace(" ", "_");
            if (formatActivityOption == "lokální_dodavatel_" ||
    formatActivityOption == "oprava_spotřebičů_" ||
    formatActivityOption == "oprava_oděvů_" ||
    formatActivityOption == "oprava_obuvi_")
            {
                formatActivityOption = formatActivityOption.Substring(0, formatActivityOption.Length - 1);
            }
            var placeActivity = (PlaceActivity)Enum.Parse(typeof(PlaceActivity), lineSplit[2]);
            var typeTag = (TypeTag)Enum.Parse(typeof(TypeTag), lineSplit[1]);
            var activityOption = (ActivityOption)Enum.Parse(typeof(ActivityOption), formatActivityOption);

            _circularEconomyDbContext.Place.Add(new Place
            {
                ActivityOption = activityOption,
                PlaceActivity = placeActivity,
                TypeTag = typeTag,
                Name = lineSplit[0],
                Vlastnik = lineSplit[7],
                Vyvoz = lineSplit[8],

                    Ulice = lineSplit[4],
                    CisloPopisne = lineSplit[5],
                    PSC = lineSplit[6]
                
            });
        }
        _circularEconomyDbContext.SaveChanges();
    }

    public void KurzFiller()
    {
        using var csvParser = new TextFieldParser("C:\\git\\CircularEconomy\\CircularEconomy\\Pages\\data\\kurzy_v2.csv");
        csvParser.CommentTokens = ["#"];
        csvParser.SetDelimiters(["/n"]);
        csvParser.HasFieldsEnclosedInQuotes = true;

        // Skip the row with the column names
        csvParser.ReadLine();

        while (!csvParser.EndOfData)
        {
            // Read current line fields, pointer moves to the next line.
            string[] fields = csvParser.ReadFields();
            var lineSplit = fields[0].Split(';');
            var formatActivityOption = lineSplit[2].Replace("-", "_").Replace(" ", "_");
            if (formatActivityOption == "lokální_dodavatel_" ||
    formatActivityOption == "oprava_spotřebičů_" ||
    formatActivityOption == "oprava_oděvů_" ||
    formatActivityOption == "oprava_obuvi_")
            {
                formatActivityOption = formatActivityOption.Substring(0, formatActivityOption.Length - 1);
            }
            var placeActivity = (PlaceActivity)Enum.Parse(typeof(PlaceActivity), lineSplit[1]);
            var activityOption = (ActivityOption)Enum.Parse(typeof(ActivityOption), formatActivityOption);

            _circularEconomyDbContext.Place.Add(new Place
            {
                ActivityOption = activityOption,
                PlaceActivity = placeActivity,
                Name = lineSplit[0],
                Contact = lineSplit[6],


                    Ulice = lineSplit[3],
                    CisloPopisne = lineSplit[4],
                    PSC = lineSplit[5]
                
            });
        }
        _circularEconomyDbContext.SaveChanges();
    }

    public void NeziskovkyFiller()
    {
        using var csvParser = new TextFieldParser("C:\\git\\CircularEconomy\\CircularEconomy\\Pages\\data\\neziskovka_v2.csv", System.Text.Encoding.UTF8);

        csvParser.CommentTokens = ["#"];
        csvParser.SetDelimiters(["/n"]);
        csvParser.HasFieldsEnclosedInQuotes = true;

        // Skip the row with the column names
        csvParser.ReadLine();

        while (!csvParser.EndOfData)
        {
            try
            {
                string[] fields = csvParser.ReadFields();
                var lineSplit = fields[0].Split(';');
                var formatActivityOption = lineSplit[3].Replace("-", "_").Replace(" ", "_");
                if (formatActivityOption == "lokální_dodavatel_" ||
        formatActivityOption == "oprava_spotřebičů_" ||
        formatActivityOption == "oprava_oděvů_" ||
        formatActivityOption == "oprava_obuvi_")
                {
                    formatActivityOption = formatActivityOption.Substring(0, formatActivityOption.Length - 1);
                }
                var placeActivity = (PlaceActivity)Enum.Parse(typeof(PlaceActivity), lineSplit[2]);
                var typeTag = (TypeTag)Enum.Parse(typeof(TypeTag), lineSplit[1]);
                var activityOption = (ActivityOption)Enum.Parse(typeof(ActivityOption), formatActivityOption);

                _circularEconomyDbContext.Place.Add(new Place
                {
                    ActivityOption = activityOption,
                    PlaceActivity = placeActivity,
                    TypeTag = typeTag,
                    Name = lineSplit[0],
                    Contact = lineSplit[7],
                    ICO = lineSplit[8],

                        Ulice = lineSplit[4],
                        CisloPopisne = lineSplit[5],
                        PSC = lineSplit[6]
                    
                });

            }
            catch (Exception)
            {

                Console.WriteLine(); ;
            }
            // Read current line fields, pointer moves to the next line.
        }

        _circularEconomyDbContext.SaveChanges();
    }
}