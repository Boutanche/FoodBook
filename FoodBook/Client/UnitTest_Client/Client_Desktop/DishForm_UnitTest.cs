using BLLC.Services;
using BO.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Client.Services;
using Xunit;

namespace UnitTest_Client.Client_Desktop
{
    /// <summary>
    /// Tests unitaires sur le Client Desktop 
    /// </summary>
    public class DishForm_UnitTest
    {
        /// <summary>
        /// Test Unitaire sur le chargement des ingrédients
        /// </summary>
        [Fact]
        public async void LoadIngredients()
        {
            //Arrange :
            IRestaurantService restaurantService = new FakeRestautantService();
            //Act : 
            ActionResult<List<Ingredients>> listIngredientsActionResult = await restaurantService.GetAllIngredients();
            //Assert :
            Assert.NotNull(listIngredientsActionResult);
        }
        /// <summary>
        /// Test Unitaire sur le cellClick d'une dataGridView
        /// </summary>
        /// <param name="sender"></param>
        [Fact]
        public void Ingredients_CellClick()
        {
            //WIP : Apprendre comment tester une dataGridView : 
            //Créer une fausse cellule vide pour le format des données qu'elle contient.
            //Récupérer cette cellule avec une donnée ingrédient.
            //Vérifier que tout est OK.
        }
    }
}

