namespace Tutorial_LINQ;
internal class Sorting
{
    public void Run()
    {
        string[] words = { "the", "quick", "brown", "fox", "jumps"};

        // 1. 길이로 정렬
        //IOrderedEnumerable<string> query = from word in words
        //    orderby word.Length descending
        //    select word;

        // 1. 길이로 정렬
        // 2. 길이가 같으면 첫글자로 정렬
        IOrderedEnumerable<string> query = from word in words
            orderby word.Length, word.Substring(0, 1)
            select word;
        Console.WriteLine();
        Console.WriteLine("Sort 사용**************************");

        foreach (var word in query)
        {
            Console.Write($"{word}\n");
        }

        Console.ReadKey();
    }

}
