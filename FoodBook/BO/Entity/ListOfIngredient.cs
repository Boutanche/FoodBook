using System;

namespace BO.Entity
{   
    /// <summary>
    /// Entitée qui permet de faire la liaison entre l'ingrédient et l'un des plats dans lequel il est utilisé.
    /// Informe aussi sur la quantité nécéssaire de commander pour un plat.
    /// </summary>
    public class ListOfIngredient
    {
        /// <summary>
        /// Id de l'ingrédient
        /// </summary>
        public int? IdIngredient { get; set; }
        /// <summary>
        /// Id du plat
        /// </summary>
        public int? IdDish { get; set; }
        /// <summary>
        /// Quantité nécessaire de cet ingrédient dans un de ce plat.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Constructeur par défault pour la sérialisation de l'API
        /// </summary>
        public ListOfIngredient() { }
        /// <summary>
        /// Constructeur utilitaire avec l'ensemble des propriétés
        /// </summary>
        /// <param name="id_ingredient">L'id de l'ingrédient</param>
        /// <param name="id_dish">L'id du plat auquel il est nécessaire</param>
        /// <param name="quantity">Quantité nécéssaire de cet ingrédient pour ce plat</param>
        public ListOfIngredient(int? id_ingredient, int id_dish, int quantity)
        {
            IdIngredient = id_ingredient;
            IdDish = id_dish;
            Quantity = quantity;
        }
        /// <summary>
        /// Override Equals Methode for ListOfIngredient
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is ListOfIngredient ingredient &&
                   IdIngredient == ingredient.IdIngredient &&
                   IdDish == ingredient.IdDish &&
                   Quantity == ingredient.Quantity;
        }
        /// <summary>
        /// Override GetHashCode for ListOfIngredient
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(IdIngredient, IdDish, Quantity);
        }
    }
}
