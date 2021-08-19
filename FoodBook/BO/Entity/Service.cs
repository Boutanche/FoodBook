using System;
using System.Collections.Generic;

namespace BO.Entity
{
    /// <summary>
    /// Update 15/06/2021
    /// Remise à zéro des data : avec utilisation de "Date" pour une manipulation plus simple.
    /// Suppression de
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Identifiant unique du service
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Numéro de service : 
        /// 1 = Midi , 2 = Soir
        /// </summary>
        public int ServiceNumber { get; set; }
        /// <summary>
        /// Numéro du jour de la semaine,
        /// 1 = Lundi ..., 7 = Dimanche
        /// </summary>
        public DateTime DateService { get; set; }
        /// <summary>
        /// Récupérer la liste des plats car il y a pas entitée isComposed
        /// </summary>
        public List<int> ListOfIdDish { get; set; }
        /// <summary>
        /// 1 = midi , 2 = soir
        /// </summary>
        public Service() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="serviceNumber"></param>
        /// <param name="dateService"></param>
        
        public Service(int? id, int serviceNumber, DateTime dateService)
        {
            Id = id;
            ServiceNumber = serviceNumber;
            DateService = dateService;
        //    ListOfIntDishes = listOfIntDishes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Service service &&
                   Id == service.Id &&
                   ServiceNumber == service.ServiceNumber &&
                   DateService == service.DateService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hashCode = 993594278;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + ServiceNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + DateService.GetHashCode();
            //hashCode = hashCode * -1521134295 + EqualityComparer<List<int>>.Default.GetHashCode(ListOfIntDishes);
            return hashCode;
        }


    }
  
}
