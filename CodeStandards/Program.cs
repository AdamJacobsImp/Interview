using System.Diagnostics;
using Bogus;

namespace Interview.CodeStandards;

public static class Program
{
    public static void Main()
    {
        var numRuns = 25;

        var longArray = new string[10_000_000];
        var faker = new Faker();

        for (int i = 0; i < longArray.Length; i++)
        {
            longArray[i] = faker.Lorem.Word();
        }
        longArray[0] = "Improveasy";
        longArray[1] = "improveasy";
        longArray[2] = "IMPROVEASY";

        var sw = Stopwatch.StartNew();
        for (int i = 0; i < numRuns; i++)
        {
            var result = StringMatch.CaseInsensitiveMatches(longArray);
            if (result != 3)
                throw new Exception($"Invalid result obtained. Returned {result}");
        }

        sw.Stop();
        Console.WriteLine($"Finished {numRuns} runs in {sw.ElapsedMilliseconds}ms. Avg: {sw.ElapsedMilliseconds / numRuns}ms");
    }


    public static class Conditionals
    {
        public record User;

        public static void ProcessList(List<string> items)
        {
            foreach (var item in items)
            {
                if (item.Contains("test") && items.Count > 2)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void Authorise(User user, bool isAdmin)
        {
            if (UserHasPermissions(user) || isAdmin)
            {
                //Authorised
            }
            else
            {
                //Not authorised
            }
        }

        public static bool UserHasPermissions(User user)
        {
            //Mimicking a database call and returning value
            Thread.Sleep(500);
            return true;
        }
    }

    public static class StringMatch
    {
        static string matchString = "Improveasy";

        public static int CaseInsensitiveMatches(IEnumerable<string> searchStrings)
        {
            int count = 0;
            foreach (string str in searchStrings) 
            { 
                if(str.ToLower() == matchString.ToLower())
                {
                    count++;
                }
            }

            return count;
        }


    }
}