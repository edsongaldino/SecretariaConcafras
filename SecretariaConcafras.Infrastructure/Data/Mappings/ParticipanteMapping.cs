using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ParticipanteMapping : IEntityTypeConfiguration<Participante>
{
    public void Configure(EntityTypeBuilder<Participante> builder)
    {
        builder.ToTable("participantes");
        builder.HasKey(p => p.Id).HasName("pk_participantes");

        // NADA de WithMany() para Usuario aqui; o lado inverso j� foi definido acima com WithOne(p => p.Usuario)
        // Demais FKs/�ndices conforme j� mapeado
    }
}
