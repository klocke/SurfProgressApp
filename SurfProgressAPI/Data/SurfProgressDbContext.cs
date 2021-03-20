using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SurfProgressAPI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfProgressAPI.Data
{
    public class SurfProgressDbContext : DbContext
    {
        public SurfProgressDbContext(DbContextOptions<SurfProgressDbContext> options) : base(options)
        {
        }

        public DbSet<Surfboard> Surfboards { get; set; }

        public DbSet<SurfSession> SurfSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: Add JSON Sample data file

            //Surfboard[] surfboardData = new Surfboard[] {
            //        new Surfboard
            //        {
            //            SurfboardId = "rocket9",
            //            Length = "5'8",
            //            Width = "19 1/4",
            //            Thickness = "2 7/16",
            //            Volume = "28.4 L",
            //            FinSetup = Surfboard.FinSetupEnum.Thruster,
            //            Tail = Surfboard.TailEnum.Swallow,
            //            Brand = "CI Surfboards",
            //            Shaper = "Al Merrick"
            //        },
            //        new Surfboard
            //        {
            //            SurfboardId = "five-ten-fish",
            //            Length = "5'10",
            //            Width = "21 1/8",
            //            Thickness = "2 1/2",
            //            Volume = "35.7 L",
            //            FinSetup = Surfboard.FinSetupEnum.Twin,
            //            Tail = Surfboard.TailEnum.Fish,
            //            Brand = "Studer Surfboards",
            //            Shaper = "Luke Studer"
            //        }
            //};

            //SurfSession[] surfSessionData = new SurfSession[]
            //{
            //         new SurfSession
            //         {
            //                        SurfSessionId = 1,
            //                        Date = new DateTime(2021, 4, 20),
            //                        TimeOfDay = SurfSession.TimeOfDayEnum.Arvo,
            //                        Location = "Beliche",
            //                        WaveHeight = SurfSession.WaveHeightEnum.Shoulder,
            //                        WaveDirection = SurfSession.DirectionEnum.Easterly,
            //                        WindDirection = SurfSession.DirectionEnum.Easterly,
            //                        WindSpeed = 11,
            //                        Rating = 4,
            //                        WaveCount = 13,
            //                        SurfboardId = "rocket9",
            //                        Notes = "Good day out."
            //         },
            //         new SurfSession
            //         {
            //                        SurfSessionId = 2,
            //                        Date = new DateTime(2021, 3, 2),
            //                        Location = "Scheveningen",
            //                        TimeOfDay = SurfSession.TimeOfDayEnum.EarlyMorning,
            //                        WaveHeight = SurfSession.WaveHeightEnum.Waist,
            //                        WaveDirection = SurfSession.DirectionEnum.NorthEasterly,
            //                        WindDirection = SurfSession.DirectionEnum.Westerly,
            //                        WindSpeed = 20,
            //                        Rating = 1,
            //                        WaveCount = 5,
            //                        SurfboardId = "five-ten-fish",
            //                        Notes = "Pretty Average day."
            //         }
            //};

            //modelBuilder.Entity<Surfboard>().HasData(surfboardData);
            //modelBuilder.Entity<SurfSession>().HasData(surfSessionData);
        }
    }
}
