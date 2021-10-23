namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (1,'Action')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (2,'Adventure')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (3,'Sci-Fi')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (4,'Drama')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (5,'Historical')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (6,'Epics')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (7,'Animation')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (8,'Fantasy')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (9,'Comedy')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (10,'Family')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (11,'Romantic Comedy')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (12,'Crime')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (13,'Gangster')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (14,'Horror')");
            Sql("INSERT INTO GenreTypes(Id,Name) VALUES (15,'Musical')");
        }
        
        public override void Down()
        {
        }
    }
}
