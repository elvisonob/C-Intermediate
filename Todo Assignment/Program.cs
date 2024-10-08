// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Tracing;

var numbers1 = new[] { 5, 10, 15, 20, -8, -2, -30};

 List<int> onlyPositive(int[] numbers, out int countPositiveNumbers){
    countPositiveNumbers = 0;
    var result = new List<int>();
    // bring out all the negative numbers and get the total count of the positive
    foreach(int number in numbers){
        if (number > 0)
        {
            result.Add(number);
        } else
        {
            countPositiveNumbers++;
        }
    }
    return result;
};

int positive;

var tentativeResult = onlyPositive(numbers1, out positive);

Console.WriteLine(positive);
foreach(var number in tentativeResult)
{
    Console.WriteLine(number);
 
}















