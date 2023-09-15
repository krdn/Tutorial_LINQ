namespace Tutorial_LINQ;
internal class Sorting
{
    public void Run()
    {
        string[] words = { "the", "quick", "brown", "fox", "jumps"};

        //IOrderedEnumerable<string> query = from word in words
        //    orderby word.Length descending
        //    select word;

        IOrderedEnumerable<string> query = from word in words
            orderby word.Length, word.Substring(0, 1)
            select word;


        Console.WriteLine();
        Console.WriteLine("Sort 사용**************************");

        foreach (var word in query)
        {
            Console.Write($"{word} ");
        }

        Console.ReadKey();
    }

}
