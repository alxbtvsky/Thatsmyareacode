namespace thatsmyareacode.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using thatsmyareacode.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<thatsmyareacode.Models.ZingerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(thatsmyareacode.Models.ZingerDBContext context)
        {
            context.Zingers.AddOrUpdate(i => i.ZingerID,
                new Zinger
                {
                    ZingerMessage = "When Harry Met Sally",
                    ZingerImage = "image",
                    ZingerUserName = "Alex",
                    Genre = "Comedy",
                    AreaCode = "502",
                    UpVote = 1,
                    DownVote = -1,
                    Favorite = true,
                    TimeCreated = DateTime.Now
                },

                new Zinger
                {
                    ZingerMessage = "When Harry Met Sally",
                    ZingerImage = "image",
                    ZingerUserName = "Brett",
                    Genre = "Romantic",
                    AreaCode = "502",
                    UpVote = 1,
                    DownVote = -1,
                    Favorite = true,
                    TimeCreated = DateTime.Now
                },

                new Zinger
                {
                    ZingerMessage = "When Harry Met Sally",
                    ZingerImage = "image",
                    ZingerUserName = "Alicia",
                    Genre = "Serious",
                    AreaCode = "502",
                    UpVote = 1,
                    DownVote = -1,
                    Favorite = true,
                    TimeCreated = DateTime.Now
                },

                new Zinger
                {
                    ZingerMessage = "When Harry Met Sally",
                    ZingerImage = "image",
                    ZingerUserName = "Ollie",
                    Genre = "Action",
                    AreaCode = "502",
                    UpVote = 1,
                    DownVote = -1,
                    Favorite = true,
                    TimeCreated = DateTime.Now
                }
           );

        }
    }
}
