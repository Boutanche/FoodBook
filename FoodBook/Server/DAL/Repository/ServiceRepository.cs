using BO.Entity;
using DAL.UOW;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class ServiceRepository : IServiceRepository
    {
        private readonly DbSession _session;

        public ServiceRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        //Faut jointer mes services avec les plats.

        public async Task<int> DeleteAsync(long id)
        {
            
            var stmt = @"delete from service where id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            var stmt = @"select * from service";
            return await _session.Connection.QueryAsync<Service>(stmt, null, _session.Transaction);
        }

        public async Task<Service> GetAsync(int id)
        {
            var stmt = @"select * from service where id = @id";
            //
            return await _session.Connection.QueryFirstOrDefaultAsync<Service>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Service>> GetAsyncByDate(DateTime date)
        {

            var stmt = @"select * from service where dateService = @date";
            //Ajouter une requête sur les 

            return await _session.Connection.QueryAsync<Service>(stmt, new { Date = date }, _session.Transaction);
            
        }

        public async Task<Service> InsertAsync(Service entity)
        {
            var stmt = @"insert into service (serviceNumber, dateService) output inserted.id values (@ServiceNumber, @dateService)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task UpdateAsync(Service entity)
        {
            var stmt = @"update service set serviceNumber = @serviceNumber, dateService = @dateService where id = @id";
            await _session.Connection.QueryAsync<Service>(stmt, entity, _session.Transaction);
        }


        public async Task<bool> AddDishToService(Service entity)
        {
            var stmt = @"insert into isComposed (idService, idDish) values (@idService , @idDish)";
            var nbModifiedLines = 0;
            List<Dish> listDish = entity.ListOfDish;
            foreach (var dish in listDish)
            {
                await _session.Connection.QueryAsync(stmt, param: new { idService = entity.Id, idDish = dish.Id }, _session.Transaction);
                nbModifiedLines++;
            }
            return nbModifiedLines > 0;

        }
        public async Task<IEnumerable<Service>> GetServicesDetailsAsync()
        {
            //Retourner une ligne pour chaque plat du service de la date sélectionnée :
            var stmt = @"Select s.id, s.serviceNumber, s.dateService, d.id, d.name, d.idType , d.popularity, td.* 
                        from service as s
                        left join isComposed as i on i.idService = s.id  
                        left join dishes as d on i.idDish = d.id
                        left join typeOfDishes as td on d.idType = td.id;";

            //1ere étape avec doublons de services
            var servicesDoublons = await _session.Connection.QueryAsync<Service, Dish, TypeOfDish, Service>(stmt, (service, dish, typeOfDish) => {
                service.ListOfDish = new List<Dish>();
                if(dish != null)
                {
                    dish.TypeofDish = typeOfDish;
                    service.ListOfDish.Add(dish);
                }
                return service;
            }, null, _session.Transaction, splitOn: "id");

            //2eme étape : grouper 
            // s = service ; sg service groupé
            return servicesDoublons.GroupBy(s => s.Id).Select(sg =>
            {
                var firstGroupService = sg.First();
                //service next (suivant)
                //sg.Where : Filtre pour ne pas se retrouver avec une liste contenant des nulls
                firstGroupService.ListOfDish = sg.Where(sn => sn.ListOfDish.Count > 0).Select(sn => sn.ListOfDish.SingleOrDefault()).ToList();
                return firstGroupService;
            });
                    
        }
        
        public async Task<IEnumerable<Service>> GetServicesDetailsByDateAsync(DateTime date)
        {
            //Retourner une ligne pour chaque plat du service de la date sélectionnée :
            var stmt = @"Select s.id, s.serviceNumber, s.dateService, d.id, d.name, d.idType , d.popularity, td.* 
                            from service as s
                            left join isComposed as i on i.idService = s.id  
                            left join dishes as d on i.idDish = d.id
                            left join typeOfDishes as td on d.idType = td.id
                            where s.dateService = @dateService;";

            //1ere étape avec doublons de services
            var servicesDoublons = await _session.Connection.QueryAsync<Service, Dish, TypeOfDish, Service>(stmt, (service, dish, typeOfDish) => {
                service.ListOfDish = new List<Dish>();
                if (dish != null)
                {
                    dish.TypeofDish = typeOfDish;
                    service.ListOfDish.Add(dish);
                }
                return service;
            }, new { dateService= date}, _session.Transaction, splitOn: "id");


            return servicesDoublons.GroupBy(s => s.Id).Select(sg =>
            {
                var firstGroupService = sg.First();
                firstGroupService.ListOfDish = sg.Where(sn => sn.ListOfDish.Count > 0).Select(sn => sn.ListOfDish.SingleOrDefault()).ToList();
                return firstGroupService;
            });

        }
    }
}
/* *** Les requêtes *** 
 * 
 * GetDishForThisService
 * Select s.serviceNumber, s.dateService, s.id as idService, d.id as idDish, d.name, d.idType , d.popularity 
from service as s
left join isComposed as i on i.idService = s.id  
left join dishes as d on i.idDish = d.id

where s.id = 1;
 * 
 * 
 * 
 * */
