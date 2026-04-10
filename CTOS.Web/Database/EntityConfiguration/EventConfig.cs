


// Configurations -> set the attribute types and relationships for each table to be created
// After each new change (related to database) ---> Add Migrations!
// Use "Package Manager Console" to add migrations then update database
// {Add-Migration "MigrationName"} command then {Update-Database} command

using CTOS.Web.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CTOS.Web.Database.EntityConfiguration {
    public class EventConfig : IEntityTypeConfiguration<Event> {
        public void Configure(EntityTypeBuilder<Event> builder) {

            builder.Property(x => x.EventId)
                .HasMaxLength(64);

            builder.Property(x => x.EventName)
                .HasMaxLength(256); // Event name has max size of 256 in database 

            builder.Property(x => x.Location)
                .HasMaxLength(512);

            builder.Property(x => x.Priority)
                .HasMaxLength(256);



            #region Relationships if present
            // Ex:

            /* 
            builder.HasOne(p => p.Company)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);
            */
            #endregion
        }
    }
}
