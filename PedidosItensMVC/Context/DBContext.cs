using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using PedidosItensMVC.Models;

namespace PedidosItensMVC.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Itens> Itens { get; set; }

        public DBContext()
            : base("PedidoBD")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}