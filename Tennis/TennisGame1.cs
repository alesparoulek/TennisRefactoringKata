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
            var tempScore = 0;
            if (_player1Score == _player2Score)
            {
                switch (_player1Score)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
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
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = _player1Score;
                    else { score += "-"; tempScore = _player2Score; }

                    score += Points[tempScore];
                    
                }
            }
            return score;
        }
    }
}

