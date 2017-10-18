namespace BookStore.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 15),
                        Senha = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 150),
                        Tipo = c.Int(nullable: false),
                        VerificationCode = c.Guid(nullable: false),
                        Verification = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UltimoLogin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
