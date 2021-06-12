using System;

namespace BO.Entity
{
    /// <summary>
    /// Représente un service : 
    /// Un service est composé de un ou plusieurs plats.
    /// 14, (7 jours * 2 par jours) services composent un menu dit "menu de la semaine".
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Identifiant unique du service
        /// </summary>
        public int? Id_service { get; set; }
        /// <summary>
        /// Numéro de service : 
        /// 1 = Midi , 2 = Soir
        /// </summary>
        public int ServiceNumber { get; set; }
        /// <summary>
        /// Numéro du jour de la semaine,
        /// 1 = Lundi ..., 7 = Dimanche
        /// </summary>
        public int DayNumber { get; set; }
        /// <summary>
        /// Clé étrangère sur le Menu de la semaine qui contient ce service
        /// </summary>
        public int Id_Menu { get; set; }
        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Service() { }
        /// <summary>
        /// Utilitary constructor full properties
        /// </summary>
        /// <param name="id_service"></param>
        /// <param name="serviceNumber"></param>
        /// <param name="dayNumber"></param>
        /// <param name="id_menu"></param>
        public Service(int? id_service, int serviceNumber, int dayNumber, int id_menu)
        {
            Id_service = id_service;
            ServiceNumber = serviceNumber;
            DayNumber = dayNumber;
            Id_Menu = id_menu;
        }
        /// <summary>
        /// Equals() 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Ingredients</returns>
        public override bool Equals(object obj)
        {
            return obj is Service service &&
                   Id_service == service.Id_service &&
                   ServiceNumber == service.ServiceNumber &&
                   DayNumber == service.DayNumber &&
                   Id_Menu == service.Id_Menu;
        }
        /// <summary>
        /// Get Hash Code ()
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id_service, ServiceNumber, DayNumber, Id_Menu);
        }
    }
  
}
