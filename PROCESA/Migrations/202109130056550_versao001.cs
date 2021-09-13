namespace PROCESA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cartorios",
                c => new
                    {
                        Cod = c.Int(nullable: false),
                        Cidade = c.String(nullable: false, maxLength: 30),
                        Contato = c.String(nullable: false, maxLength: 60),
                        Telefone = c.String(nullable: false, maxLength: 70),
                        Observacao = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Cod);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cartorios");
        }
    }
}
