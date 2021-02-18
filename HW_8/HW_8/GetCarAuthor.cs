using System;
using System.Collections.Generic;
using System.Text;
using HW_8;
using Microsoft.EntityFrameworkCore;

namespace HW_8
{
    public static class GetData
    {
        public static void GetDataCarAuthor()
        {
            var dbContext = new CarAdvancedContext();
            var car = dbContext.Cars.Include(x => x.Author);

            foreach (var c in car)
            {
                Console.WriteLine($"CarName: {c.CarName}  \tmodelname: {c.ModelName}  \tColor: {c.Color} \tyear: {c.Year} \tFirstName: {c.Author.FirstName} \tLastName: {c.Author.LastName} \tDescription: {c.Author.Description}");
            }

        }
        
    }
}
