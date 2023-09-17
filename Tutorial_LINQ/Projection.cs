namespace Tutorial_LINQ;
internal class Projection
{
    // Projection(분출, 방출) Operations
    // https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/linq/projection-operations
    // Select, SelectMany, Zip
    public void Run()
    {
        Console.WriteLine("Select 사용**************************************");
        // 다음 예제에서는 select 절을 사용하여 문자열 목록의 각 문자열에서 첫 글자를 프로젝션합니다.
        List<string> words = new() { "an", "apple", "a", "day"};

        var query = from word in words
                    select word.Substring(0, 1);
        Print(query);

        /* This code produces the following output:

            a
            a
            a
            d
        */

        Console.WriteLine("SelectMany 사용**************************************");
        // 다음 예제에서는 여러 from 절을 사용하여 문자열 목록의 각 문자열에서 각 단어를 프로젝션합니다.
        List<string> phrases = new() { "an apple a day", "the quick brown fox" };

        query = from phrase in phrases
                from word in phrase.Split(' ')
            select word;
        Print(query);

        /* This code produces the following output:

            an
            apple
            a
            day
            the
            quick
            brown
            fox
        */


        Console.WriteLine("Zip 사용**************************************");
        // Zip 프로젝션 연산자에 대한 오버로드가 여러 개 있습니다.
        // 모든 Zip 메서드는 둘 이상의 이종 형식의 시퀀스에 대해 작동합니다.
        // 처음 두 오버로드는 지정된 시퀀스의 해당 위치 형식과 함께 튜플을 반환합니다.

        // An int array with 7 elements.
        IEnumerable<int> numbers = new[]
        {
            1, 2, 3, 4, 5, 6, 7
        };
        // A char array with 6 elements.
        IEnumerable<char> letters = new[]
        {
            'A', 'B', 'C', 'D', 'E', 'F'
        };

        foreach ((int number, char letter) in numbers.Zip(letters))
        {
            Console.WriteLine($"Number: {number} zipped with letter: '{letter}'");
        }
        // This code produces the following output:
        //     Number: 1 zipped with letter: 'A'
        //     Number: 2 zipped with letter: 'B'
        //     Number: 3 zipped with letter: 'C'
        //     Number: 4 zipped with letter: 'D'
        //     Number: 5 zipped with letter: 'E'
        //     Number: 6 zipped with letter: 'F'
        // 7번째 요소는 무시됩니다.

        Console.ReadKey();
    }

    private void Print(IEnumerable<string> query)
    {
        foreach (var market in query)
            Console.WriteLine(market);

        Console.WriteLine();
    }
}
