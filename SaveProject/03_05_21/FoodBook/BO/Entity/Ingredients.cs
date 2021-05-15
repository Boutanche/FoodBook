using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Ingredients(int? id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        
        // Générer automatiquement Equals() and GetHashCode()
        // TODO : Demander <<exactement>> pourquoi je fais ça...
        
        public override bool Equals(object obj)
        {
            return obj is Ingredients ingredients &&
                   Id == ingredients.Id &&
                   Name == ingredients.Name &&
                   Price == ingredients.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Price);
        }
    }
}
