namespace Personnel.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        AdherentID = c.String(nullable: false, maxLength: 128),
                        LastName = c.String(nullable: false, maxLength: 75),
                        FirstName = c.String(nullable: false, maxLength: 75),
                        BirthDate = c.DateTime(nullable: false),
                        GrossSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstablishmentSiret = c.String(maxLength: 14),
                        RoleId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        WorkQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Role_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AdherentID)
                .ForeignKey("dbo.Establishments", t => t.EstablishmentSiret)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.EstablishmentSiret)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Establishments",
                c => new
                    {
                        Siret = c.String(nullable: false, maxLength: 14),
                        Name = c.String(nullable: false),
                        Adress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Siret);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Label = c.String(nullable: false, maxLength: 75),
                        MinimumSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Employees", "EstablishmentSiret", "dbo.Establishments");
            DropIndex("dbo.Employees", new[] { "Role_Id" });
            DropIndex("dbo.Employees", new[] { "EstablishmentSiret" });
            DropTable("dbo.Roles");
            DropTable("dbo.Establishments");
            DropTable("dbo.Employees");
        }
    }
}
