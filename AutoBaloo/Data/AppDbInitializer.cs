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


                
                                //Vehicule
                                if (!context.Vehicules.Any())
                                {
                                    context.Vehicules.AddRange(new List<Vehicule>()
                                    {
                                                new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.Audi,
                                                    StatutVehicule        = StatutVehicule.Disponible,
                                                    TypeCarbu             = "Essence",
                                                    PrixVehicule          = 1000000,
                                                    DescriptionVehicule   = "qvhfizufhziufhffuhfu",
                                                    DateConstruct         = "01/01/2022",
                                                    KM                    =  "300 km",
                                                    OptionVehicule        = "A vendre",
                                                    CouleurVehicule       = "Rouge",
                                                    ImageURL              = "images/vehicules/1.jpeg"
                                                },

                                                new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.Audi,
                                                    StatutVehicule        = StatutVehicule.Disponible,
                                                    TypeCarbu             = "Essence",
                                                    PrixVehicule          = 100000000,
                                                    DescriptionVehicule   = "qvhfizufhziufhffuhfuzfh",
                                                    DateConstruct         = "01/01/2022",
                                                    KM                    =  "300 km",
                                                    OptionVehicule        = "A vendre",
                                                    CouleurVehicule       = "Rouge",
                                                    ImageURL              = "images/vehicules/1.jpeg"
                                                },

                                                new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.Audi,
                                                    StatutVehicule        = StatutVehicule.Disponible,
                                                    TypeCarbu             = "Essence",
                                                    PrixVehicule          = 2000000,
                                                    DescriptionVehicule   = "qvhfizufhziufhffuhfuzfh",
                                                    DateConstruct         = "01/01/2022",
                                                    KM                    =  "300 km",
                                                    OptionVehicule        = "A vendre",
                                                    CouleurVehicule       = "Rouge",
                                                    ImageURL              = "images/vehicules/1.jpeg"
                                                },

                                                new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.Audi,
                                                    StatutVehicule        = StatutVehicule.Disponible,
                                                    TypeCarbu             = "Essence",
                                                    PrixVehicule          = 1000000,
                                                    DescriptionVehicule   = "qvhfizufhziufhffuhfuzfh",
                                                    DateConstruct         = "01/01/2022",
                                                    KM                    =  "300 km",
                                                    OptionVehicule        = "A vendre",
                                                    CouleurVehicule       = "Rouge",
                                                    ImageURL              = "images/vehicules/1.jpeg"
                                                },

                                                new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.Audi,
                                                    StatutVehicule        = StatutVehicule.Disponible,
                                                    TypeCarbu             = "Essence",
                                                    PrixVehicule          = 900000,
                                                    DescriptionVehicule   = "qvhfizufhziufhffuhfuzfh",
                                                    DateConstruct         = "01/01/2022",
                                                    KM                    =  "300 km",
                                                    OptionVehicule        = "A vendre",
                                                    CouleurVehicule       = "Rouge",
                                                    ImageURL              = "images/vehicules/1.jpeg"
                                                },



                                                new Vehicule()
                                                {

                                                    MarqueVehicule        = MarqueVehicule.BMW,
                                                    StatutVehicule        = StatutVehicule.Disponible,
                                                    TypeCarbu             = "Essence",
                                                    PrixVehicule          = 900000,
                                                    DescriptionVehicule   = "qvhfizufhziufhffuhfuzfh",
                                                    DateConstruct         = "01/01/2022",
                                                    KM                    =  "300 km",
                                                    OptionVehicule        = "A Loué",
                                                    CouleurVehicule       = "Jaune",
                                                    ImageURL              = "images/vehicules/1.jpeg"
                                                }



                                    });

                                    context.SaveChanges();


                                }

                            /*    //Stock
                                if (!context.Stocks.Any())
                                {
                                    context.Stocks.AddRange(new List<Stock>()
                                    {
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





                                //Reservation
                                if (!context.Reservations.Any())
                                {
                                    context.Reservations.AddRange(new List<Reservation>()
                                    {
                                        new Reservation()
                                        {

                                        }
                                    });
                                    context.SaveChanges();

                                }

                                //Paiement
                                if (!context.Paiements.Any())
                                {
                                    context.Paiements.AddRange(new List<Paiement>()
                                    {
                                        new Paiement()
                                        {

                                        }
                                    });
                                    context.SaveChanges();
                                }

                                //Utilisateur
                                if (!context.Utilisateurs.Any())
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

                                }*/

                               

            }
        }
    }
}

