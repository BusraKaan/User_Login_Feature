namespace Digitus_User_Login_Feature.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Digitus_User_Login_Feature.Models.UserLoginModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Digitus_User_Login_Feature.Models.UserLoginModel context)
        {
            context.Users.AddOrUpdate(s => s.ID, new Models.User()
            {
                ID = 1,
                NameSurname = "B��ra Kaan",
                UserName = "busra",
                Mail = "busrakaan96@gmail.com",
                Password = "123",
                Status = true,
                Authority=Models.Enums.AuthorityEnum.admin
            });
        }
    }
}
