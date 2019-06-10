using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _200393479A1.Models
{
    public class GameDB : DropCreateDatabaseAlways<_200393479A1Context>
    {
        protected override void Seed(_200393479A1Context context)
        {
            Genre CallOfDuty = new Genre
            {
                Name = "Call Of Duty",
                Description = "A game which is based on true stories of U.S Army Surgical Strikes against Bad people."
            };
            Genre GTA = new Genre
            {
                Name = "GTA",
                Description = "This game is made on concept of real life of Gangstars."
            };
            videoGame ModernWarfare = new videoGame()
            {
                Name = "Call Of Duty",
                Description = "A game which is based on true stories of U.S Army Surgical Strikes against Bad people.",
                Requirements = "At least 4Gb Graphic card and Gaming Laptop or Computer",
                Price = 100,
                Publiser = "Call Of Duty Private LTD,.",
                Developer = "Avition Developer LTD,.",
                Genre = CallOfDuty
            };
            videoGame GTA5 = new videoGame()
            {
                Name = "GTA",
                Description = "This game is made on concept of real life of Gangstars.",
                Requirements = "At least 4Gb Graphic card and Gaming Laptop or Computer",
                Price = 110,
                Publiser = "GTA Private LTD,.",
                Developer = "Rockstar Developer LTD,.",
                Genre = GTA
            };
            context.Genres.Add(GTA);
            context.Genres.Add(CallOfDuty);
            context.videoGames.Add(ModernWarfare);
            context.videoGames.Add(GTA5);

            base.Seed(context);
        }
    }
}