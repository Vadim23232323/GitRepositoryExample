using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW_6.task1;

namespace HW_6.task2
{
    public static class leftjoin
    {
        public static void ShowLeftJoin()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var leftjoinResult = from character in characters
                join story in stories
                    on character.StoryId equals story.Id
                select new
                {
                    character.FirstName,
                    character.LastName,
                    character.Gender,
                    character.Age,
                    StoryID = story.Id
                };

            Console.WriteLine("linq left join character,story");

            foreach (var item in leftjoinResult)
            {
                Console.WriteLine(
                    $"FirstName:{item.FirstName}, LastName: {item.LastName}, Gender: {item.Gender}, ID: {item.StoryID}");
            }
        }
    }
}
