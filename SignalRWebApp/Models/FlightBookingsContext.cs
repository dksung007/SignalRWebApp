using System;
using System.Data.Entity;

namespace SignalRWebApp.Models
{
    public class FlightBookingsContext : DbContext
    {
        const String DefaultConnectionName = "SignaRTestConnection";

        #region "ctor"

        public FlightBookingsContext() : this(DefaultConnectionName)
        {
        }

        public FlightBookingsContext(String sqlConnectionName) : base(String.Format("Name={0}", sqlConnectionName))
        {
        }

        #endregion

        #region Collections Definitions

        public DbSet<FlightBookings> FlightBookings { get; set; }


        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightBookings>()
                        .ToTable("FlightBookings", "dbo")
                        .HasKey(t => t.FlightId);
        }
    }
}