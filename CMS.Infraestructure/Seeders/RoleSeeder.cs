﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CMS.infraestructure.Seeders
{
    public class RoleSeeder : IEntityTypeConfiguration<IdentityRole<Guid>>
    {

        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityRole<Guid>
                {
                    Id = Guid.Parse("b1f6c811-53a5-4819-bb47-28861c5f5a74"),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.Parse("21e56e0e-cf41-4602-a8ba-e38853c26954"),
                    Name = "Editor",
                    NormalizedName = "EDITOR",
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.Parse("f8886107-ee3d-4156-9fbc-673aec657c72"),
                    Name = "Viewer",
                    NormalizedName = "VIEWER"
                }
            );
        }

    }
}
