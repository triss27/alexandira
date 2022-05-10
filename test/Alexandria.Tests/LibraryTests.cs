using Xunit;

namespace Alexandria.Tests;

public class LibraryTests
{
    [Fact]
    public void LibraryNameCorrectlySetsName()
    {
        var name = "Alexandria";
        Library library = new Library(name);
        Assert.Equal(library.name, name);
        
    }
}