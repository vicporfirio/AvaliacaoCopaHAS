using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvaliacaoCopaHAS.Models;
using CopaHAS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Identity.Client;

namespace CopaHAS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Jogador> TB_JOGADORES { get; set; }      
        public DbSet<Estadio> TB_ESTADIOS {get; set;}
        public DbSet <Selecao> TB_SELECOES { get; set; }
        public DbSet <Tecnico> TB_TECNICOS { get; set; }
        public DbSet <Jogo> TB_JOGOS { get; set; }
        public DbSet <JogoSelecao> TB_JOGO_SELECOES { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogador>().ToTable("TBL_JOGADORES");
            modelBuilder.Entity<Jogador>(entity => 
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(e => e.Posicao)
                      .HasMaxLength(50);
                entity.HasOne(d => d.SelecaoIdNavegacao)
                      .WithMany(p => p.Jogadores)
                      .HasForeignKey(d => d.SelecaoId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Estadio>().ToTable("TB_ESTADIOS");
            modelBuilder.Entity<Estadio>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome)
                      .IsRequired()
                      .HasMaxLength(150);
                entity.Property(e => e.Cidade)
                      .HasMaxLength(100);
            });
            modelBuilder.Entity<Selecao>().ToTable("TBL_SELECOES");
            modelBuilder.Entity<Selecao>(entity =>
            {
                entity.HasKey(e=> e.Id);
                entity.Property(e=> e.Pais)
                    .IsRequired()
                    .HasMaxLength(100);   
            });
            modelBuilder.Entity<Tecnico>().ToTable("TB_TECNICOS");
            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.HasOne(d => d.SelecaoIdNavegacao)
                      .WithOne(p => p.Tecnico)
                      .HasForeignKey<Tecnico>(d => d.SelecaoIdNavegacao)
                      .OnDelete(DeleteBehavior.Cascade); 
            });
            modelBuilder.Entity<Jogo>().ToTable("TB_JOGOS");
            modelBuilder.Entity<Jogo>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.DataHora)                      
                      .IsRequired();
                entity.HasOne(d => d.EstadioIdNavegacao)
                      .WithMany(p => p.Jogos)
                      .HasForeignKey(d => d.EstadioId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<JogoSelecao>().ToTable("TB_JOGO_SELECOES");
            modelBuilder.Entity<JogoSelecao>(entity=>
            {
                entity.HasKey(e=> new {e.JogoId,e.SelecaoId});
                entity.HasOne(d=> d.JogoIdNavegacao)
                      .WithMany(p=> p.Jogoselecoes)
                      .HasForeignKey(d=> d.JogoId);
                entity.HasOne(d=> d.SelecaoIdNavegacao)
                      .WithMany(p => p.JogosSelecoes)
                      .HasForeignKey(d=> d.SelecaoId);
            });

            modelBuilder.Entity<Jogador>().HasData
            (
                new Jogador(){ Id=1, Nome="Hugo Souza",NumeroCamisa=1,Posicao="Goleiro",Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=2, Nome="Yuri Alberto",NumeroCamisa=9,Posicao="Atacante",Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=3, Nome="Danilo", NumeroCamisa=2, Posicao="Lateral Direito", Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=4, Nome="Marquinhos", NumeroCamisa=4, Posicao="Zagueiro", Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=5, Nome="Casemiro", NumeroCamisa=5, Posicao="Volante", Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=6, Nome="Alex Sandro", NumeroCamisa=6, Posicao="Lateral Esquerdo", Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=7, Nome="Lucas Paquetá", NumeroCamisa=7, Posicao="Meio Campo", Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=8, Nome="Bruno Guimarães", NumeroCamisa=8, Posicao="Meio Campo", Status=Models.Enuns.StatusJogador.Reserva },
                new Jogador(){ Id=9, Nome="Richarlison", NumeroCamisa=10, Posicao="Atacante", Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=10, Nome="Vinicius Jr", NumeroCamisa=11, Posicao="Atacante", Status=Models.Enuns.StatusJogador.Titular },
                new Jogador(){ Id=11, Nome="Rodrygo", NumeroCamisa=19, Posicao="Atacante", Status=Models.Enuns.StatusJogador.DepartamentoMedico },
                new Jogador(){ Id=12, Nome="Alisson", NumeroCamisa=23, Posicao="Goleiro", Status=Models.Enuns.StatusJogador.NaoRelacionado }
            );
            modelBuilder.Entity<Estadio>().HasData(
                new Estadio(){ Id=1,Nome="Neo Quimica 1",Capacidade=600000,Cidade="São Paulo 1"},
                new Estadio(){ Id=2,Nome="Neo Quimica 2",Capacidade=600000,Cidade="São Paulo 2"},
                new Estadio(){ Id=3,Nome="Neo Quimica 3",Capacidade=600000,Cidade="São Paulo 3"},
                new Estadio(){ Id=4,Nome="Neo Quimica 4",Capacidade=600000,Cidade="São Paulo 4"},
                new Estadio(){ Id=5,Nome="Neo Quimica 5",Capacidade=600000,Cidade="São Paulo 5"},
                new Estadio(){ Id=6,Nome="Neo Quimica 6", Capacidade=600000,Cidade="São Paulo 6"},
                new Estadio(){ Id=7,Nome="Neo Quimica 7",Capacidade=600000,Cidade="São Paulo 7"}
            );
            //Área para futuros inserts no banco de dados a partir de outras classes/objetos
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings
                .Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>()
                .HaveColumnType("varchar").HaveMaxLength(200);

            base.ConfigureConventions(configurationBuilder);
        }

        //Inserir as linhas "new Jogador(){ Id = 1, ..." das lista de jogadores

    }
}

