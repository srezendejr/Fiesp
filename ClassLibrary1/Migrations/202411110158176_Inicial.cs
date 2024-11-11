namespace FIESP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 1000, unicode: false),
                        RazaoSocial = c.String(maxLength: 1000, unicode: false),
                        CNPJ = c.String(maxLength: 1000, unicode: false),
                        InscricacaoEstdual = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresa");
        }
    }
}
