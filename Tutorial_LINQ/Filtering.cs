using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_LINQ;
internal class Filtering
{
    // LINQ 필터링 사용 예제
    public void Run()
    {
        string[] words = { "the", "quick", "brown", "fox", "jumps" };

        // 1. 길이가 3보다 큰 단어만 선택
        IEnumerable<string> query = from word in words
            where word.Length > 3 && word.Contains("o")
            select word;

        Console.WriteLine("Where 사용**************************************");
        foreach (var word in query)
        {
            Console.Write($"{word} ");
        }

        // 1. Where
        // 2. OfType
        // 3. Take
        // 4. Skip
        // 5. TakeWhile
        // 6. SkipWhile
        // 7. Distinct
        // 8. Except
        // 9. Intersect
        // 10. Union
        // 11. Concat
        // 12. DefaultIfEmpty
        // 13. First
        // 14. FirstOrDefault
        // 15. Last
        // 16. LastOrDefault
        // 17. Single
        // 18. SingleOrDefault
        // 19. ElementAt
        // 20. ElementAtOrDefault
        // 21. Range
        // 22. Repeat
        // 23. Empty
        // 24. Any
        // 25. All
        // 26. Contains
        // 27. SequenceEqual
        // 28. Count
        // 29. LongCount
        // 30. Min
        // 31. Max
        // 32. Sum
        // 33. Average
        // 34. Aggregate
        // 35. Aggregate with seed
        // 36. Aggregate with seed and result selector
        // 37. Min with selector
        // 38. Max with selector
        // 39. Sum with selector
        // 40. Average with selector
        // 41. Aggregate with selector
        // 42. Aggregate with seed and selector
        // 43. Aggregate with seed, selector and result selector
        // 44. Min with comparer
        // 45. Max with comparer
        // 46. Min with comparer and selector
        // 47. Max with comparer and selector
        // 48. OrderBy
        // 49. OrderBy with comparer
        // 50. OrderByDescending
        // 51. OrderByDescending with comparer
        // 52. ThenBy
        // 53. ThenBy with comparer
        // 54. ThenByDescending
        // 55. ThenByDescending with comparer
        // 56. Reverse
        // 57. GroupBy
        // 58. GroupBy with element selector
        // 59. Group
        // 60. Group with comparer
        // 61. Group with element selector
        // 62. Group with element selector and comparer
        // 63. ToLookup
        // 64. ToLookup with element selector
        // 65. ToLookup with comparer
        // 66. ToLookup with element selector and comparer
        // 67. Join
        // 68. Join with comparer
        // 69. Join with result selector
        // 70. Join with comparer and result selector
        // 71. GroupJoin
        // 72. GroupJoin with comparer
        // 73. GroupJoin with result selector
        // 74. GroupJoin with comparer and result selector
        // 75. SelectMany
        // 76. SelectMany with result selector
        // 77. SelectMany with collection selector
        // 78. SelectMany with collection selector and result selector
        // 79. SelectMany with collection selector and index
        // 80. SelectMany with collection selector, index and result selector
        // 81. SelectMany with index
        // 82. SelectMany with index and result selector
        // 83. SelectMany with index and collection selector
        // 84. SelectMany with index, collection selector and result selector
        // 85. SelectMany with index, collection selector and index
        // 86. SelectMany with index, collection selector, index and result selector
        // 87. SelectMany with result selector and index
        // 88. SelectMany with result selector and collection selector
        // 89. SelectMany with result selector, collection selector and index
        // 90. SelectMany with result selector, collection selector, index and result selector
        // 91. SelectMany with result selector, index and collection selector
        // 92. SelectMany with result selector, index, collection selector and index
        // 93. SelectMany with result selector, index, collection selector, index and result selector
        // 94. SelectMany with collection selector and index
        // 95. SelectMany with collection selector, index and result selector
        // 96. SelectMany with collection selector, index and collection selector
        // 97. SelectMany with collection selector, index, collection selector and result selector
        // 98. SelectMany with collection selector, index, collection selector and index
        // 99. SelectMany with collection selector, index, collection selector, index and result selector
        // 100. SelectMany with collection selector, index, result selector and index
        // 101. SelectMany with collection selector, index, result selector and collection selector







    }

  
}
