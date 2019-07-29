namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataInUserTables : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b40c22fe-ea40-4346-a0be-f6a7e4917e19', N'nh@gmail.com', 0, N'AIwu5wmxtF/7H8aOCI7Jn4179oJZOBD5sRAHs61bN80KxEXuanbBicochXuplvEd8w==', N'fe8e701f-2670-4b6a-a123-530392652c10', NULL, 0, 0, NULL, 1, 0, N'nh@gmail.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f6363e47-677b-4543-b860-564c378d023c', N'admin')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b40c22fe-ea40-4346-a0be-f6a7e4917e19', N'f6363e47-677b-4543-b860-564c378d023c')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
