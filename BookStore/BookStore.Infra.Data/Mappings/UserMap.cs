using System.Data.Entity.ModelConfiguration;
using BookStore.Domain.Account.Entities;

namespace BookStore.Infra.Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Usuario");

            HasKey(p => p.Id);

            Property(p => p.Username)
                .HasColumnName("Usuario")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.Password)
                .HasColumnName("Senha")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.Email)
                .HasColumnName("Email")
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Active)
                .HasColumnName("Ativo")
                .IsRequired();

            Property(p => p.LastLoginDate)
                .HasColumnName("UltimoLogin")
                .IsRequired();

            Property(p => p.Role)
                .HasColumnName("Tipo")
                .IsRequired();
        }
    }
}