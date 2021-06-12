using System;

namespace BO.Entity
{
    /// <summary>
    /// Le menu de la semaine
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Identifiant unique du menu
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Année concernée par ce menu
        /// </summary>
        public DateTime Year { get; set; }
        /// <summary>
        /// Il y a 52 semaines dans une année
        /// </summary>
        public int WeekNumber { get; set; }
        /// <summary>
        /// Default Constructor for API serialisation
        /// </summary>
        public Menu() { }
        /// <summary>
        /// Utilitary constructor full properties
        /// </summary>
        /// <param name="id_menu"></param>
        /// <param name="year"></param>
        /// <param name="weekNumber"></param>
        public Menu(int? id_menu, DateTime year, int weekNumber)
        {
            Id = id_menu;
            Year = year;
            WeekNumber = weekNumber;
        }
        /// <summary>
        /// Equals()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Menu menu &&
                   Id == menu.Id &&
                   Year == menu.Year &&
                   WeekNumber == menu.WeekNumber;
        }
        /// <summary>
        /// GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Year, WeekNumber);
        }
    }
}
