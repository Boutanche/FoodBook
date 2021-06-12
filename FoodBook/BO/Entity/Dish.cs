using System;

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
        public int? Id { get; set; }
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
        public int IdType { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Dish() { }

        /// <summary>
        /// Utilitari constructor full properties
        /// </summary>
        /// <param name="idDish">Id of dish</param>
        /// <param name="name">Name of this dish</param>
        /// <param name="popularity">Number how many times this dish is selected by clients</param>
        /// <param name="fk_typeOfDish">Foreign Key</param>
        public Dish(int? idDish, string name, int popularity, int fk_typeOfDish)
        {
            Id = idDish;
            Name = name;
            Popularity = popularity;
            IdType = fk_typeOfDish;
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
                Id == dish.Id &&
                Name == dish.Name &&
                Popularity == dish.Popularity &&
                IdType == dish.IdType;
        }
        /// <summary>
        /// Override GetHashCode for dish
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Popularity, IdType);
        }
    }
}
