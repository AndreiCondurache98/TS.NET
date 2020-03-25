namespace Laborator5
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class BusinessModel : DbContext
    {
        // Your context has been configured to use a 'BusinessModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Laborator5.BusinessModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BusinessModel' 
        // connection string in the application configuration file.
        public BusinessModel()
            : base("name=BusinessModel")
        {
        }

        public DbSet<Business> Businesses { get; set; }
    }

    [Table("Business", Schema = "BazaDeDate")]
    public class Business
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessId { get; protected set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
    }

    [Table("eCommerce", Schema = "BazaDeDate")]
    public class eCommerce : Business
    {
        public string URL { get; set; }
    }

    [Table("Retail", Schema = "BazaDeDate")]
    public class Retail : Business
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIPCode { get; set; }
    }


}