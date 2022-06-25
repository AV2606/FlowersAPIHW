using FlowersAPIHW.Controllers.Model;
using FlowersAPIHW.DB.Models;
using System.Collections.Generic;

namespace FlowersAPIHW.Extensions.cs
{
    public static class Extensions
    {
        /// <summary>
        /// Convert <see cref="FlowerModel"/> to <see cref="FlowerItem"/>
        /// </summary>
        /// <param name="me">The flower to convert</param>
        /// <returns></returns>
        public static FlowerModel ToFlowerModel(this FlowerItem me)
        {
            return new FlowerModel
            {
                Id = me.Id,
                Name = me.Name,
                Price = me.Price,
                Description = me.Description,
                Size=me.Size,
                Colors=me.Colors
            };
        }

        /// <summary>
        /// Convert <see cref="IEnumerable{FlowerItem}"/> to <see cref="List{FlowerModel}"/>
        /// </summary>
        /// <param name="me">The flower to convert</param>
        /// <returns></returns>
        public static List<FlowerModel> ToFlowerModelList(this IEnumerable<FlowerItem> me)
        {
            List<FlowerModel> r = new List<FlowerModel>();
            foreach (var item in me)
            {
                r.Add(item.ToFlowerModel());
            }
            return r;
        }

        /// <summary>
        /// Convert <see cref="FlowerItem"/> to <see cref="FlowerModel"/>
        /// </summary>
        /// <param name="me">The flower to convert</param>
        /// <returns></returns>
        public static FlowerItem ToFlowerItem(this FlowerModel me)
        {
            return new FlowerItem
            {
                Id = me.Id,
                Name = me.Name,
                Price = me.Price,
                Description = me.Description,
                Size = me.Size,
                Colors = me.Colors
            };
        }

        /// <summary>
        /// Convert  <see cref="IEnumerable{FlowerModel}"/> <see cref="List{FlowerItem}"/> to
        /// </summary>
        /// <param name="me">The flower to convert</param>
        /// <returns></returns>
        public static List<FlowerItem> ToFlowerItemList(this IEnumerable<FlowerModel> me)
        {
            List<FlowerItem> r = new List<FlowerItem>();
            foreach (var item in me)
            {
                r.Add(item.ToFlowerItem());
            }
            return r;
        }
    }
}
