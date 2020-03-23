namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private static readonly string[] Points = { "Love", "Fifteen", "Thirty", "Forty" };
        private readonly string _player1Name;
        private readonly string _player2Name;
        private int _player1Score = 0;
        private int _player2Score = 0;

        public TennisGame1(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1Name)
                _player1Score += 1;
            else
                _player2Score += 1;
        }

        /*public void Player1WonPoint()
        {
            _player1Score++;
        }

        public void Player2WonPoint()
        {
            _player2Score;
        }*/

        public string GetScore()
        {

            string score = "";
            if (_player1Score == _player2Score)
            {
                return _player1Score < 3 ? $"{Points[_player1Score]}-All" : "Deuce";
 
            }

            
            else if (_player1Score >= 4 || _player2Score >= 4)
            {
                var minusResult = _player1Score - _player2Score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                score = $"{Points[_player1Score]}-{Points[_player2Score]}";

            }
            return score;
        }
    }
}

