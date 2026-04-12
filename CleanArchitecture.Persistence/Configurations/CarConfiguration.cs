using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Persistence.Configurations
{
    public sealed class CarConfiguration : IEntityTypeConfiguration<Domain.Entities.Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            
            builder.HasKey(c => c.Id);


        }
    }
}
