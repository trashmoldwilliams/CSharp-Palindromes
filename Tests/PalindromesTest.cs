using System.Collections.Generic;
using Xunit;
namespace Palindromes.Objects
{
  public class PalindromeFinderTest
  {
    [Fact]
    public void Test1_IfEvenInputIsPalindrome_ReturnTrue()
    {
      //Arrange
      string input1 = "deed";
      PalindromeFinder testWord = new PalindromeFinder(input1);

      //Act
      string result = testWord.GetResults();

      //Assert
      Assert.Equal("Yes", result);
    }

    [Fact]
    public void Test1_IfOddInputIsPalindrome_ReturnTrue()
    {
      //Arrange
      string input1 = "deeeeeeeeeeeeeeeeeeeeeeeeeeed";
      PalindromeFinder testWord = new PalindromeFinder(input1);

      //Act
      string result = testWord.GetResults();

      //Assert
      Assert.Equal("Yes", result);
    }
    // [Fact]
    // public void Test2_IfInputIsNotPalindrome_ReturnFalse()
    // {
    //   //Arrange
    //   string input1 = "Hello";
    //   PalindromeFinder testWord = new PalindromeFinder(input1);
    //
    //   //Act
    //   string result = testWord.GetResults();
    //
    //   //Assert
    //   Assert.Equal("No", result);
    // }
    // [Fact]
    // public void Test3_IFaibohphobiaIsPalindrome_ReturnTrue()
    // {
    //   //Arrange
    //   string input1 = "aibohphobia";
    //   PalindromeFinder testWord = new PalindromeFinder(input1);
    //
    //   //Act
    //   string result = testWord.GetResults();
    //
    //   //Assert
    //   Assert.Equal("Yes", result);
    // }
  }
}
