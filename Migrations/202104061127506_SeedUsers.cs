namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cfb66558-e77e-49ca-9d1d-109c7ecbebe7', N'admin@store.pl', 0, N'AK96ngFBCzfOeaeMJH9xd1pHJiFZVrI3fJkRrWNppFTonQrk29INon2IZsrK3OIiLw==', N'a40a46a9-acc8-435b-acb8-f783104264fb', NULL, 0, 0, NULL, 1, 0, N'admin@store.pl')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ddba27f6-e949-4ad4-8df8-1e8e5efd11c7', N'flp.tomczak@gmail.com', 0, N'APsiGHcQgtN7V9GhgMYTWiTzgDmmdCfF4AGpOCOlhh140SvtSrHx5iATyWsE/8HwpQ==', N'9f1e096f-9035-4a49-9e13-93379d9f0e2a', NULL, 0, 0, NULL, 1, 0, N'flp.tomczak@gmail.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b6a8e4f9-64a7-4fa8-bb78-54af634fdee3', N'CanManageMovie')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6c403936-90f9-4a40-8e29-3cd667c25198', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cfb66558-e77e-49ca-9d1d-109c7ecbebe7', N'6c403936-90f9-4a40-8e29-3cd667c25198')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
