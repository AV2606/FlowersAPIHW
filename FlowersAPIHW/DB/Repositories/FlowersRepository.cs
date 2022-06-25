using FlowersAPIHW.Controllers.Model;
using FlowersAPIHW.DB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersAPIHW.DB.Repositories
{
    public class FlowersRepository
    {
        private readonly FlowerDbContext context;

        public FlowersRepository(FlowerDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Return all the flowers in the data base
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FlowerItem> GetAll()
        {
            return context.Flowers.ToList();
        }
        
        /// <summary>
        /// Return the flower with id <paramref name="id"/>, or null if it doesnt exists.
        /// </summary>
        /// <param name="id">The id of the flower</param>
        /// <returns></returns>
        public FlowerItem GetFlowerById(int id)
        {
            return context.Flowers.FirstOrDefault(f => f.Id == id);
        }

        /// <summary>
        /// Adds a flower to the database
        /// </summary>
        /// <param name="flower">The flower to add.</param>
        public async Task<FlowerItem> Add(FlowerItem flower)
        {
            context.Flowers.Add(flower);
            await context.SaveChangesAsync();
            return flower;
        }

        /// <summary>
        /// Remove the flower with the id from the database
        /// </summary>
        /// <param name="id">The id of the flower to remove</param>
        /// <returns></returns>
        public async Task<FlowerItem> Remove(int id)
        {
            var item = context.Flowers.FirstOrDefault(f => f.Id == id);
            context.Flowers.Remove(item);
            await context.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// Updates the flower in the data base by its id
        /// </summary>
        /// <param name="flower"></param>
        /// <returns></returns>
        public async Task Update(FlowerItem flower)
        {
            context.Flowers.Update(flower);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates the flower in the data base by its id
        /// </summary>
        /// <param name="flower"></param>
        /// <returns></returns>
        public async Task Update(FlowerItem flower, int id)
        {
            flower.Id = id;
            context.Flowers.Update(flower);
            await context.SaveChangesAsync();
        }



    }
}
