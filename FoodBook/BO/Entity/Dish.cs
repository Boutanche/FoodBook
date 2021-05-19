using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    /// <summary>
    /// Dish composed by 1 or n Ingredients.
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// int : Id Dish
        /// </summary>
        public int? Id_dish { get; set; }
        /// <summary>
        /// string : Name of a dish
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// int : Popularity of a dish
        /// </summary>
        public int Popularity { get; set; }
        /// <summary>
        /// int : Foreign key of type of dish
        /// </summary>
        public int Id_type { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Dish() { }

        /// <summary>
        /// Utilitaru constructor ful properties
        /// </summary>
        /// <param name="id_dish">Id of dish</param>
        /// <param name="name">Name of this dish</param>
        /// <param name="popularity">Number how many times this dish is selected by clients</param>
        /// <param name="fk_typeOfDish">Foreign Key</param>
        public Dish(int? id_dish, string name, int popularity, int fk_typeOfDish)
        {
            Id_dish = id_dish;
            Name = name;
            Popularity = popularity;
            Id_type = fk_typeOfDish;
        }

        //Générer automatiquement Equals() and GetHashCocde()
        /// <summary>
        /// Override Equals Methode for dish
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Dish dish &&
                Id_dish == dish.Id_dish &&
                Name == dish.Name &&
                Popularity == dish.Popularity &&
                Id_type == dish.Id_type;
        }
        /// <summary>
        /// Override GetHashCode for dish
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id_dish, Name, Popularity, Id_type);
        }
    }
}
