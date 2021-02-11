using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HW_6.task1
{
    public static class AnonymousTypes
    {
        public static void ShowAnonymousTypes()
        {
            var characters = CharactersRepository.GetCharacters();

            var PersonDescription = characters.Select(character => 
                new { character.FirstName, character.LastName, character.Gender ,character.Age });

            foreach (var person in PersonDescription)
                Console.WriteLine($"FirstName: {person.FirstName},\tLastName: {person.LastName} ,\tGener: {person.Gender}, \tAge: {person.Age}");
        }

    }
}
