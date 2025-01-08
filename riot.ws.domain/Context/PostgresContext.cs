
using Microsoft.EntityFrameworkCore;
using riot.ws.domain.Models;

namespace riot.ws.domain.Context;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    //public virtual DbSet<Build> Builds { get; set; }

    public virtual DbSet<Participante> Participantes { get; set; }

    public virtual DbSet<Partida> Partida { get; set; }

    //public virtual DbSet<Perk> Perks { get; set; }

    public virtual DbSet<RankEntity> Ranks { get; set; }

    //public virtual DbSet<Runa> Runas { get; set; }

    //public virtual DbSet<Selection> Selections { get; set; }

    //public virtual DbSet<Style> Styles { get; set; }

    public virtual DbSet<SummonerAccount> SummonerAccounts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Participante>(entity =>
        {
            entity.HasKey(e => new { e.Matchid, e.Puuid }).HasName("participante_pkey");

            entity.ToTable("participante");

            entity.Property(e => e.Matchid).HasColumnName("matchid");
            entity.Property(e => e.Puuid).HasColumnName("puuid");
            entity.Property(e => e.Championid).HasColumnName("championid");
            entity.Property(e => e.Item0).HasColumnName("item0");
            entity.Property(e => e.Item1).HasColumnName("item1");
            entity.Property(e => e.Item2).HasColumnName("item2");
            entity.Property(e => e.Item3).HasColumnName("item3");
            entity.Property(e => e.Item4).HasColumnName("item4");
            entity.Property(e => e.Item5).HasColumnName("item5");
            entity.Property(e => e.Item6).HasColumnName("item6");
            entity.Property(e => e.TeamPosition).HasColumnName("roleplayed");
            entity.Property(e => e.Summoner1Id).HasColumnName("summoner1id");
            entity.Property(e => e.Summoner2Id).HasColumnName("summoner2id");
            entity.Property(e => e.Teamid).HasColumnName("teamid");
            entity.Property(e => e.TotalDamageDealt).HasColumnName("totaldamagedealt");
            entity.Property(e => e.Win).HasColumnName("win");

            entity.HasOne(d => d.Match).WithMany(p => p.Participantes)
                .HasForeignKey(d => d.Matchid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("participante_matchid_fkey");

            entity.HasOne(d => d.Summoner).WithMany(p => p.Participantes)
                .HasForeignKey(d => d.Puuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("participante_puuid_fkey");
        });

        modelBuilder.Entity<Partida>(entity =>
        {
            entity.HasKey(e => e.Matchid).HasName("partida_pkey");

            entity.ToTable("partida"); 

            entity.Property(e => e.Matchid).HasColumnName("matchid");
            entity.Property(e => e.Duracion)
                .HasColumnName("duracion");
            entity.Property(e => e.Fechafinalizacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fechafinalizacion");
            entity.Property(e => e.Gameversion).HasColumnName("gameversion");
            entity.Property(e => e.Platformid).HasColumnName("platformid");
            entity.Property(e => e.Queueid).HasColumnName("queueid");
            entity.Property(e => e.Teamidwin).HasColumnName("teamidwin");
        });

        modelBuilder.Entity<RankEntity>(entity =>
        {
            entity.HasKey(e => new { e.Summonerid, e.Queuetype }).HasName("rank_pkey");

            entity.ToTable("rank");

            entity.Property(e => e.Summonerid)
                .HasMaxLength(255)
                .HasColumnName("summonerid");
            entity.Property(e => e.Queuetype)
                .HasMaxLength(50)
                .HasColumnName("queuetype");
            entity.Property(e => e.Freshblood).HasColumnName("freshblood");
            entity.Property(e => e.Hotstreak).HasColumnName("hotstreak");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.Leagueid)
                .HasMaxLength(255)
                .HasColumnName("leagueid");
            entity.Property(e => e.Leaguepoints).HasColumnName("leaguepoints");
            entity.Property(e => e.Losses).HasColumnName("losses");
            entity.Property(e => e.Rank)
                .HasMaxLength(10)
                .HasColumnName("rank");
            entity.Property(e => e.Tier)
                .HasMaxLength(50)
                .HasColumnName("tier");
            entity.Property(e => e.Veteran).HasColumnName("veteran");
            entity.Property(e => e.Wins).HasColumnName("wins");

            entity.HasOne(d => d.SummonerAccount).WithMany(p => p.Ranks)
                .HasPrincipalKey(p => p.Summonerid)
                .HasForeignKey(d => d.Summonerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rank_summonerid_fkey");
        });

        modelBuilder.Entity<SummonerAccount>(entity =>
        {
            entity.HasKey(e => e.Puuid).HasName("pk_summoneraccount");

            entity.ToTable("summoneraccount");

            entity.HasIndex(e => e.Summonerid, "summoneraccount_summonerid_key").IsUnique();

            entity.Property(e => e.Puuid).HasColumnName("puuid");
            entity.Property(e => e.Gamename).HasColumnName("gamename");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Profileiconid).HasColumnName("profileiconid");
            entity.Property(e => e.Revisiondate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("revisiondate");
            entity.Property(e => e.Summonerid).HasColumnName("summonerid");
            entity.Property(e => e.Summonerlevel).HasColumnName("summonerlevel");
            entity.Property(e => e.Tagline).HasColumnName("tagline");
        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
