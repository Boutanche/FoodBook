using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity

{
    /// <summary>
    /// /!\
    /// </summary>
    public class IsComposed
    {
        /// <summary>
        /// Id du plat
        /// </summary>
        public int? IdDish { get; set; }
        /// <summary>
        /// Id du servite 
        /// </summary>
        public int? IdService { get; set; }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idDish"></param>
        /// <param name="idService"></param>
        public IsComposed(int? idDish, int? idService)
        {
            IdDish = idDish;
            IdService = idService;
        }
        /// <summary>
        /// Généré automatiquement
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is IsComposed composed &&
                   IdDish == composed.IdDish &&
                   IdService == composed.IdService;
        }

        /// <summary>
        /// Généré automatiquement
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hashCode = -953204169;
            hashCode = hashCode * -1521134295 + IdDish.GetHashCode();
            hashCode = hashCode * -1521134295 + IdService.GetHashCode();
            return hashCode;
        }

        
    }
}
