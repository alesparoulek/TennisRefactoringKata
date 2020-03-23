namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private string _player1Name;
        private string _player2Name;
        private int _player1Score = 0;
        private int _player2Score = 0;

        public TennisGame3(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GetScore()
        {
            string score;
            if ((_player1Score < 4 && _player2Score < 4) && (_player1Score + _player2Score < 6))
            {
                string[] points = { "Love", "Fifteen", "Thirty", "Forty" };
                score = points[_player1Score];
                return (_player1Score == _player2Score) ? score + "-All" : score + "-" + points[_player2Score];
            }
            else
            {
                if (_player1Score == _player2Score)
                    return "Deuce";
                score = _player1Score > _player2Score ? _player1Name : _player2Name;
                return ((_player1Score - _player2Score) * (_player1Score - _player2Score) == 1) ? "Advantage " + score : "Win for " + score;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName.Equals(_player1Name))
                _player1Score++;
            else
                _player2Score++;
        }

    }
}

