using AutoBaloo.Data.Enums;
using AutoBaloo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                
                                /*//Vehicule
                                if (!context.Vehicules.Any())
                                {
                    context.Vehicules.AddRange(new List<Vehicule>()
                                    {
                                                new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.Audi,
                                                    StatutVehicule        = StatutVehicule.Disponible,
                                                    TypeCarbu             = "Diesel",
                                                    PrixVehicule          = 1000000,
                                                    DescriptionVehicule   = " Audi A3 SEDAN 1.6 TDi S tronic Business NAVI/FULL LED/JA16/PDC",
                                                    DateConstruct         = "2017",
                                                    KM                    =  "68.082km ",
                                                    OptionVehicule        = "A vendre",
                                                    CouleurVehicule       = "noir",
                                                    ImageURL              = "~/images/12.jpg.jpg",
                                                },

                                                new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.Audi,
                                                    StatutVehicule        = StatutVehicule.Disponible,
                                                    TypeCarbu             = "Diesel",
                                                    PrixVehicule          = 255000,
                                                    DescriptionVehicule   = " Audi A3 SEDAN 1.6 TDi S tronic Business NAVI/FULL LED/JA16/PDC",
                                                    DateConstruct         = "2017",
                                                    KM                    =  " 65.851km ",
                                                    OptionVehicule        = "A Louer ",
                                                    CouleurVehicule       = "Rouge",
                                                    ImageURL              = "~/images/1.jpg"
                                                },

                                                 new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.BMW,
                                                    StatutVehicule        = StatutVehicule.Loué,
                                                    TypeCarbu             = "Diesel",
                                                    PrixVehicule          = 20566,
                                                    DescriptionVehicule   = "BMW X1 2.0 d sDrive18 NAVI / CUIR / PDC AV+AR / JA 17         ",
                                                    DateConstruct         = "2017",
                                                    KM                    =  " 89.196km ",
                                                    OptionVehicule        = "A Louer ",
                                                    CouleurVehicule       = "Blanc",
                                                    ImageURL              = "~/images/2.jpg"
                                                },




                                    }) ;

                                    context.SaveChanges();


                                }

                             /* //Stock
                               if (!context.Stocks.Any())
                                {
                                    context.Stocks.AddRange(new List<Stock>()
                                    {
                                        new Stock()
                                        {
                                              DateStock           = "01/01/2022",
                                              QteStock            = 100,
                                              IdVehicule          =  30
                                        },

                                        new Stock()
                                        {
                                              DateStock           = "01/01/2022",
                                              QteStock            = 100,
                                               IdVehicule          =  31

                                        },

                                       /* new Stock()
                                        {
                                              DateStock           = "01/01/2010",
                                              QteStock            = 100,
                                               IdVehicule          =  

                                        },

                                        new Stock()
                                        {
                                              DateStock           = "01/01/2010",
                                              QteStock            = 100,
                                               IdVehicule          =  

                                        },

                                        new Stock()
                                        {
                                              DateStock           = "01/01/2010",
                                              QteStock            = 100,
                                               IdVehicule          =  

                                        }
                                    });
                                    context.SaveChanges();
                                }
                           
        */



                          /*      //Reservation
                            if (!context.Reservations.Any())
                                {
                    context.Reservations.AddRange(new List<Reservation>()
                                    {
                                        new Reservation()
                                        {

                                           DateDebut="01/05/2022",
                                            DateFin = "01/06/2022",
                                           Duree =30  ,
                                           MontantReservation= " 5566",

                                           TypeReservation=TypeReservation.Louer,
                                           IdUtilisateur=1,
                                           IdVehicule= 44,
    }
                                    }) ;
                                    context.SaveChanges();

                                }

                                //Paiement
                           /*     if (!context.Paiements.Any())
                                {
                                    context.Paiements.AddRange(new List<Paiement>()
                                    {
                                        new Paiement()
                                        {

                                        }
                                    });
                                    context.SaveChanges();
                                }*/

                                //Utilisateur
                           /*   if (!context.Utilisateurs.Any())
                                {
                                    context.Utilisateurs.AddRange(new List<Utilisateur>()
                                    {
                                        new Utilisateur()
                                        {
                                             NomUtilisateur  = "Théo",
                                            EmailUtilisateur =  "theos@gmail.com",
                                            MotPasse         = "theo??",
                                            Adresse          = "vapart 40"

                                        },


                                    });
                                    context.SaveChanges();

                                }

                               */

            }
        }
    }
}

