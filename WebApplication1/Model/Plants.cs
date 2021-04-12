using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Plants
    {
        [Key]
        public int Id { get; set; }
        public string PlantName { get; set; }
        public DateTime LastWatered { get; set; }
        public string ImageUrl { get; set; }
        public string WaterStatus { get; set; }
    }

    public class PlantsData
    {
        public Plants[] GetPlants()
        {
            Plants[] PlantsList = new Plants[] {
        new Plants{
            Id=1,
        LastWatered=DateTime.Now.ToUniversalTime(),
        PlantName="Hibiscus",
        ImageUrl="/Images/plant1.jpg",
         WaterStatus=""
        },
         new Plants{
            Id=2,
        LastWatered=DateTime.Now.ToUniversalTime(),
        PlantName="Rose",
         ImageUrl="/Images/plant2.jpg",
          WaterStatus=""
        },
          new Plants{
            Id=3,
        LastWatered=DateTime.Now.ToUniversalTime(),
        PlantName="Jasmine",
         ImageUrl="/Images/plant3.jpg",
          WaterStatus=""
        },
           new Plants{
            Id=4,
        LastWatered=DateTime.Now.ToUniversalTime(),
        PlantName="Sunflower",
         ImageUrl="/Images/plant1.jpg",
          WaterStatus=""
        },
            new Plants{
            Id=5,
        LastWatered=DateTime.Now.ToUniversalTime(),
        PlantName="Chrysanthimum",
         ImageUrl="/Images/plant3.jpg",
         WaterStatus=""
        }
        };
            return PlantsList;
        }
        
    }
}
