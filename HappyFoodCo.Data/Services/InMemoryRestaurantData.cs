using System;
using System.Collections.Generic;
using System.Linq;
using HappyFoodCo.Data.Models;

namespace HappyFoodCo.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        // create the var privately
        private List<Restaurant> restaurants;

        // constructor
        public InMemoryRestaurantData()
        {
            // use the var made above, to make a list type 
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Cuisine = CuisineType.French, Name = "The French"},
                new Restaurant {Id = 2, Cuisine = CuisineType.Indian, Name = "Tamarind Table"},
                new Restaurant {Id = 3, Cuisine = CuisineType.Italian, Name = "Jamie's Italian"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}