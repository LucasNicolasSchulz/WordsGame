namespace WordsGame.Test;

public class UtilsTest
{
    [Fact]
    public void Scramble_EmptyString()
    {
        var result = Utils.Scramble("");
        Assert.Equal("", result);
    }

        
}