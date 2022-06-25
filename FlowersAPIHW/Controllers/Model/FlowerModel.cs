using FlowersAPIHW.DB.Models;
using System.ComponentModel.DataAnnotations;

namespace FlowersAPIHW.Controllers.Model
{
    //A model of FlowerItem
    public class FlowerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Colors { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }

        //public static implicit operator FlowerModel(FlowerItem flower)
        //{
        //    return new FlowerModel
        //    {
        //        Id = flower.Id,
        //        Name = flower.Name,
        //        Description = flower.Description,
        //        Colors = flower.Colors,
        //        Size = flower.Size,
        //        Price = flower.Price
        //    };
        //}
        
        //public static FlowerItem ToFlowerItem(FlowerModel flower)
        //{
        //    return new FlowerItem
        //    {
        //        Id = flower.Id,
        //        Name = flower.Name,
        //        Description = flower.Description,
        //        Colors = flower.Colors,
        //        Size = flower.Size,
        //        Price = flower.Price
        //    };
        //}

    }
}
