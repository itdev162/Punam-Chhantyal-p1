using System.Collections.Generic;
using System.Linq;

using Domain;

namespace Persistence
{
    public class Seed
    {
        
        public static void SeedData(DataContext context)
        {
            if(context.Facebook.Count() == 0)
            {
                List<Facebook> seedPosts = new List<Facebook>
                {
                new Facebook() { Tittle = "Facebook" , Synopsis = "Facebook is the one of the unique app that connects you with your friends, family." },
                new Facebook() { Tittle = "Mark Zuckerberg" , Synopsis = "He is the guy who first use the facebook" },
                new Facebook() { Tittle = "Messenger" , Synopsis = "Messenger is the app that connects with facebook and messenger has video call which you can call your family,friends" },
                };

                context.Facebook.AddRange(seedPosts);
                context.SaveChanges();
            }
        }
    }
}