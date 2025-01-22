using Review3;

namespace TestingReview3;

public class NUnitTestItem1
{
    private List<int> numbers;
    [SetUp]
    public void Setup()
    {
        numbers = new List<int>() { 68, 70, 12, 56, 34, 82, 27, 17 };
    }

    [Test]
    public void SortingListByDescendingOrder()
    {
        //Arrange
        var expected = new List<int>() { 82, 70, 68, 56, 34, 27, 17, 12 };
        //Act
        var result = numbers.OrderByDescending(x => x).ToList();

        // Assert
        Assert.AreEqual(expected, result, "The numbers are not sorted in descending order.");
    }

    [Test]
    public void FilteringPrimeNumbersFromList() {
        //Arrange
        var expectedResult = new List<int>() { 17 };

        //Act
        var primeNumbers = numbers.Where(x => ProblemNum4.isPrime(x)).ToList();

        //Assert
        Assert.AreEqual(expectedResult,primeNumbers);

    }

    [Test]
    public void FilterNubersGreaterThanThreshold() {
        //Arrange
        int threshold = 40;
        var expResult = new List<int>() { 68, 70, 56, 82 };
        //Act
        var numbersGreaterthanThreshold = numbers.Where(x => x > threshold).ToList();
        //Assert
        Assert.AreEqual(expResult,numbersGreaterthanThreshold);

    }
    [Test]
    public void checkifMethodReturnsTrueforPrimeNumber()
    {
        //Arrange
        int number = 7;
        bool expectedR = true;

        //Act
        bool actualOp = ProblemNum4.isPrime(number);

        //Assert
        Assert.AreEqual(expectedR, actualOp);



    }
    [Test]
    public void checkifMethodReturnsFalseforNonPrimeNumber() {
        //Arrange
        int number = 18;
        bool expectedR = false;

        //Act
        bool actualOp = ProblemNum4.isPrime(number);

        //Assert
        Assert.AreEqual(expectedR,actualOp);


    
    }

}
