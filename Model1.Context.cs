﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_3___Arcade
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ArcadeDBEntities : DbContext
    {
        public ArcadeDBEntities()
            : base("name=ArcadeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gebruiker> Gebruikers { get; set; }
        public virtual DbSet<ScoreEndlessRunner> ScoresEndlessRunner { get; set; }
        public virtual DbSet<ScoreFlappyBird> ScoresFlappyBird { get; set; }
        public virtual DbSet<ScoreSnake> ScoresSnake { get; set; }
        public virtual DbSet<ScoreTetris> ScoresTetris { get; set; }
        public virtual DbSet<ScoreZombieShooter> ScoresZombieShooter { get; set; }
    }
}
