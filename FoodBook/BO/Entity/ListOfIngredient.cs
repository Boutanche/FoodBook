using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{   
    /// <summary>
    /// Entitée qui permet de faire la liaison entre l'ingrédient et l'un des plats dans lequel il est utilisé.
    /// Informe aussi sur la quantité nécéssaire de commander pour un plat.
    /// </summary>
    class ListOfIngredient
    {
        /// <summary>
        /// Id de l'ingrédient
        /// </summary>
        public int? Id_ingredient { get; set; }
        /// <summary>
        /// Id du plat
        /// </summary>
        public int Id_dish { get; set; }
        /// <summary>
        /// Quantité nécessaire de cet ingrédient dans un de ce plat.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Constructeur par défault pour la sérialisation de l'API
        /// </summary>
        public ListOfIngredient() { }
        public ListOfIngredient(int? id_ingredient, int id_dish, int quantity)
        {
            Id_ingredient = id_ingredient;
            Id_dish = id_dish;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is ListOfIngredient ingredient &&
                   Id_ingredient == ingredient.Id_ingredient &&
                   Id_dish == ingredient.Id_dish &&
                   Quantity == ingredient.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id_ingredient, Id_dish, Quantity);
        }
    }
}
