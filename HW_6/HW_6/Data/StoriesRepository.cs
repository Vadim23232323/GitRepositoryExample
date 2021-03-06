﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6.task1
{
    public static class StoriesRepository
    {
        public static IEnumerable<Story> GetStories()
        {
            var stories = new List<Story>();

            stories.Add(new Story(1, "Fairytail of the lost needle", "None"));
            stories.Add(new Story(2, "Foundation", "None"));
            stories.Add(new Story(3, "Cool story, Bob", "None"));

            return stories;
        }
    }
}
