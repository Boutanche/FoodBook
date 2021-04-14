using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_FoodBook.Models
{
    /// <summary>
    /// Modéle des données pour les Ingrédients
    /// </summary>
    public class IngredientsModel
    {
        // Identifiant unique de l'ingrédient
        public int Id { get; set; }
        // Nom de l'ingrédient
        public string Name { get; set; }
        // Prix moyen de l'ingrédient
        public double Price { get; set; }

        public IngredientsModel() { }

        public IngredientsModel(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}