using MDP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDP.Infrastructure.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(e => e.Id)
                    .HasName("Cliente_Id_CPK")
                    .IsClustered(false);

            builder.Property(e => e.Id)
               .HasColumnName("Id");

            builder.Property(e => e.Nombre)
                .HasColumnName("Nombre")
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Apellido)
                .HasColumnName("Apellido")
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Correo)
                .HasColumnName("Correo")
                .IsRequired()
                .HasMaxLength(320)
                .IsUnicode(false);

            builder.Property(e => e.FechaNacimiento)
                .HasColumnName("FechaNacimiento")
                .HasColumnType("datetime");

            builder.Property(e => e.Direccion)
                .HasColumnName("Direccion")
                .HasMaxLength(800)
                .IsUnicode(false);

            builder.Property(e => e.Activo)
              .HasColumnName("Activo");

            builder.Property(e => e.FechaRegistro)
                .HasColumnName("FechaRegistro")
                .HasColumnType("datetime");

        }
    }
}
