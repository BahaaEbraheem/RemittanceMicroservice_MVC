using CustomerManagement.Customers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CustomerManagement.EntityFrameworkCore;

public static class CustomerManagementDbContextModelCreatingExtensions
{
    public static void ConfigureCustomerManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));



        builder.Entity<Customer>(b => {

            b.ToTable(CustomerManagementDbProperties.DbTablePrefix + "Customers" + CustomerManagementDbProperties.DbSchema);
            b.ConfigureByConvention();
            b.HasKey(x => new { x.Id });
            b.Property(x => x.FirstName).IsRequired();
            b.Property(x => x.LastName).IsRequired();
            b.Property(x => x.FatherName).IsRequired();
            b.Property(x => x.MotherName).IsRequired();
            b.Property(x => x.BirthDate).IsRequired();
            b.Property(x => x.Phone).IsRequired();
            b.Property(x => x.Gender).IsRequired();

            b.HasIndex(e => new { e.FirstName, e.LastName, e.FatherName, e.MotherName }).IsUnique();

        });



        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(CustomerManagementDbProperties.DbTablePrefix + "Questions", CustomerManagementDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
