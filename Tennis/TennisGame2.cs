namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private static readonly string[] Points = { "Love", "Fifteen", "Thirty", "Forty" };
        private readonly string _player1Name;
        private readonly string _player2Name;
        private int _player1Score = 0;
        private int _player2Score = 0;

        private string p1res = "";
        private string p2res = "";
        

        public TennisGame2(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GetScore()
        {
            string score = "";
            if (_player1Score == _player2Score)
            {
                if (_player1Score < 3)
                    return $"{Points[_player1Score]}-All";
                else
                    return "Deuce";
            }


            if (_player1Score < 4 && _player2Score < 4)
            {
                p1res = Points[_player1Score];
                p2res = Points[_player2Score];
                return p1res + "-" + p2res;
            }



            if (_player2Score > _player1Score && _player2Score < 4)
            {
                if (_player2Score == 2)
                    p2res = "Thirty";
                if (_player2Score == 3)
                    p2res = "Forty";
                if (_player1Score == 1)
                    p1res = "Fifteen";
                if (_player1Score == 2)
                    p1res = "Thirty";
                score = p1res + "-" + p2res;
            }

            if (_player1Score > _player2Score && _player2Score >= 3)
            {
                score = "Advantage player1";
            }

            if (_player2Score > _player1Score && _player1Score >= 3)
            {
                score = "Advantage player2";
            }

            if (_player1Score >= 4 && _player2Score >= 0 && (_player1Score - _player2Score) >= 2)
            {
                score = "Win for player1";
            }
            if (_player2Score >= 4 && _player1Score >= 0 && (_player2Score - _player1Score) >= 2)
            {
                score = "Win for player2";
            }
            return score;
        }

        public void SetP1Score(int number)
        {
            _player1Score += number;
        }

        public void SetP2Score(int number)
        {
            _player2Score += number;
        }

        private void P1Score()
        {
            _player1Score++;
        }

        private void P2Score()
        {
            _player2Score++;
        }

        public void WonPoint(string player)
        {
            if (player.Equals(_player1Name))
                P1Score();
            else
                P2Score();
        }

    }
}

