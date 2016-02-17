using System.Collections.Generic;
using Xunit;
namespace Palindromes.Objects
{
  public class PalindromeFinderTest
  {
    [Fact]
    public void Test1_IfInputIsPalindrome_ReturnTrue()
    {
      //Arrange
      string input1 = "deed";
      PalindromeFinder testWord = new PalindromeFinder(input1);

      //Act
      bool result = testWord.GetResults();

      //Assert
      Assert.Equal(true, result);
    }
    [Fact]
    public void Test2_IfInputIsNotPalindrome_ReturnFalse()
    {
      //Arrange
      string input1 = "Hello";
      PalindromeFinder testWord = new PalindromeFinder(input1);

      //Act
      bool result = testWord.GetResults();

      //Assert
      Assert.Equal(false, result);
    }
    [Fact]
    public void Test3_IFaibohphobiaIsPalindrome_ReturnTrue()
    {
      //Arrange
      string input1 = "aibohphobia";
      PalindromeFinder testWord = new PalindromeFinder(input1);

      //Act
      bool result = testWord.GetResults();

      //Assert
      Assert.Equal(true, result);
    }
  }
}
