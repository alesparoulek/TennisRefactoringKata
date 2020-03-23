namespace Tennis
{
    public interface ITennisGame
    {
        void WonPoint(string playerName); // I don't think this is too good
        // since there are allways only 2 players (or 2 teams) it should be enough to give the function just two choices.
        // I would recommend splitting it into two functions like Player1WonPoint() and Player2WonPoint()
        // so there would be no need to compare strings.

        string GetScore();
    }
}

