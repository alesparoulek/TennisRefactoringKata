namespace Tennis
{
    public interface ITennisGame
    {
        // since there are allways only 2 players (or 2 teams), using the following two functions
        // is better than comparing strings in "void WonPoint(string playerName)"
        void Player1WonPoint();
        void Player2WonPoint();

        string GetScore();
    }
}

