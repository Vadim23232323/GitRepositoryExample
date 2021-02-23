using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using HW_9.Json;
using HW_9.models;

namespace HW_9
{
    public static class SimpleJsonSerizalization
    {
        public static async void ShowJsonSerialization()
        {
            Car car = new Car();
            
            car.Id = 1;
            car.CarName = "Audi";
            car.ModelName = "80";
            car.Color = "blue";
            car.Age = 1998;

            
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

                using (FileStream stream = new FileStream(@"d:\courses\GitRepositoryExample\HW_9\Car.txt", FileMode.OpenOrCreate))
                {
                   JsonSerializer.SerializeAsync<Car>(stream, car, options);
                }

                using (FileStream stream = new FileStream(@"d:\courses\GitRepositoryExample\HW_9\Car.txt", FileMode.Open))
                {
                    car = await JsonSerializer.DeserializeAsync<Car>(stream);
                }

                Console.WriteLine(car.Id + " " + car.CarName + " " + car.ModelName + " " + car.Color + " " + car.Age);

        }

    }
}
