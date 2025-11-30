using homework_cs_30_11.models;
using homework_cs_30_11.interfaces;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        FilterService<int> numberFilterService = new FilterService<int>(numbers);
        EvenNumberFilter evenFilter = new EvenNumberFilter();
        numberFilterService.Filter(evenFilter);
        Console.WriteLine("Filtered Even Numbers: " + string.Join(", ", numbers));

        List<string> strings = new List<string> { "apple", "banana", "kiwi", "cherry", "blueberry" };
        FilterService<string> stringFilterService = new FilterService<string>(strings);
        LongStringFilter longStringFilter = new LongStringFilter(5);
        stringFilterService.Filter(longStringFilter);
        Console.WriteLine("Filtered Long Strings: " + string.Join(", ", strings));
    }
}