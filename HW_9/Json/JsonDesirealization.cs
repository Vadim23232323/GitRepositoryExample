using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;
using HW_9.models;

namespace HW_9.Json
{
    public static class JsonDesirealization
    {
        public static async void ShowJsonDesirealization()
        {
            Car car;

            using (FileStream stream = new FileStream(@"d:\courses\GitRepositoryExample\HW_9\Car.txt", FileMode.Open))
            {
                car = await JsonSerializer.DeserializeAsync<Car>(stream);
            }

            Console.WriteLine(car.Id + " " + car.CarName + " " + car.ModelName + " " + car.Color + " " + car.Age);
        }
    }
}
