using DuHair;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ModelContext:DbContext
    {
        public ModelContext() : base("name=cn") { }
        public DbSet<Employee> EmployeeList { get; set; }
        public DbSet<Material> MaterialList { get; set; }
        public DbSet<Service> ServiceList { get; set; }
        public DbSet<Customer> CustomerList { get; set; }
        public DbSet<Transaction> TransactionList { get; set; }
        public DbSet<Chair> ChairList { get; set; }
        public DbSet<Warehouse> WarehouseList { get; set; }
        public DbSet<Restock> RestockList { get; set; }
        public DbSet<RestockDetail> RestockDetailList { get; set; }
        public DbSet<SpendNote> SpendNoteList { get; set; }
        public DbSet<WarehouseCheck> WarehouseCheckList { get; set; }
        public DbSet<WarehouseCheckDetail> WarehouseCheckDetailList { get; set; }
        public DbSet<Commission> ComissionList { get; set; }
        public DbSet<TimeKeeping> TimeKeepingList { get; set; }
        public DbSet<TkDetail> TkDetailList { get; set; }
        public DbSet<SellTran> SellTranList { get; set; }
        public DbSet<SellTranDetail> SellTranDetailList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

