namespace WordsGame.Test;

public class UtilsTest
{
    [Fact]
    public void Scramble_EmptyString()
    {
        var result = Utils.Scramble("");
        Assert.Equal("", result);
    }

    [Fact]
    public void Scramble_SingleCharacter(){
        var result = Utils.Scramble("A");
        Assert.Equal("A", result);
    }

    [Fact]
    public void Scramble_TwoCharacters(){
        var input = "AB";
        var result = Utils.Scramble(input);
        Assert.True(result == "AB" || result == "BA");
        Assert.Contains("A", result);
        Assert.Contains("B", result);
    }
}