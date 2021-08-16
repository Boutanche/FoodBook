using System;
using System.Collections.Generic;

namespace BO.Entity
{
    /// <summary>
    /// Représente un objet Ingredient
    /// </summary>
    public class Ingredients
    {
        /// <summary>
        /// Identifiant unique de l'ingrédient 
        /// </summary>

        public int? Id { get; set; }
        /// <summary>
        /// Nom de l'ingrédient
        /// </summary>
        public string Name {get;set;}
        /// <summary>
        /// Prix moyen de l'ingrédient
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Default constructor for API serialisation
        /// </summary>
        public Ingredients() { }
        /// <summary>
        /// Utilitary constructor full properties
        /// </summary>
        /// <param name="id_ingredient"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Ingredients(int? id_ingredient, string name, decimal price)
        {
            Id = id_ingredient;
            Name = name;
            Price = price;
        }

        // Générer automatiquement Equals() and GetHashCode()
        /// <summary>
        /// Générer automatiquement Equals() and GetHashCode()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Ingredients</returns>
        public override bool Equals(object obj)
        {
            return obj is Ingredients ingredients &&
                   Id == ingredients.Id &&
                   Name == ingredients.Name &&
                   Price == ingredients.Price;
        }

        /// <summary>
        /// Hash Code
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            int hashCode = -479135040;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }


    }
}
