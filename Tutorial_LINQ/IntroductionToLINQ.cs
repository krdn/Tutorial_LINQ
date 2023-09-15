namespace Tutorial_LINQ;

/// <summary>
/// 1. Introduction to LINQ
/// </summary>
internal class IntroductionToLINQ
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // LINQ with Query Expression
        // Query expression syntax is the preferred way to write LINQ queries.
        // https://learn.microsoft.com/en-us/dotnet/csharp/linq/query-expression-basics

        // 쿼리 변수: 쿼리 결과 대신 쿼릴ㄹ 저장함.
        IEnumerable<int> numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

        Console.WriteLine("쿼리 변수사용*************************************");
        // 쿼리변수는 값이 필요시 퀴리를 실행한다.
        // 쿼리 변수는 IEnumerable<T>를 구현하는 개체이다.
        foreach (var num in numQuery)
        {
            Console.Write($"{num} ");
        }


        Console.WriteLine("");

        Console.WriteLine("쿼리 결과값**************************************");
        // LINQ with Lambda
        //결과 값을 저장한다.
        List<int> numQuery2 =
            (from num in numbers
             where (num % 2) == 0
             select num).ToList();

        foreach (var num in numQuery2)
        {
            Console.Write($"{num} ");
        }
    }
}
