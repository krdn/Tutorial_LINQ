namespace Tutorial_LINQ;
internal class SetOperations
{
    int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
    int[] numbersB = { 1, 3, 5, 7, 8 };

    public void Run()
    {
        // 1. Union(합집합)
        Console.WriteLine("Union 사용**************************************");
        IEnumerable<int> union = numbersA.Union(numbersB);
        foreach (var num in union)
        {
            Console.Write($"{num} ");
        }

        // 2. Intersect(교집합)
        Console.WriteLine("");
        Console.WriteLine("Intersect 사용***********************************");
        IEnumerable<int> intersect = numbersA.Intersect(numbersB);
        foreach (var num in intersect)
        {
            Console.Write($"{num} ");
        }

        // 3. Except(차집합)
        Console.WriteLine("");
        Console.WriteLine("Except 사용**************************************");
        IEnumerable<int> except = numbersA.Except(numbersB);
        foreach (var num in except)
        {
            Console.Write($"{num} ");
        }

        // 4. Distinct(중복제거)
        Console.WriteLine("");
        Console.WriteLine("Distinct 사용************************************");
        int[] numbers = { 5, 4, 1, 1, 3, 9, 8, 6, 6, 7, 2, 0 };
        IEnumerable<int> distinct = numbers.Distinct();
        foreach (var num in distinct)
        {
            Console.Write($"{num} ");
        }
    }

}
