namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private static readonly string[] Points = { "Love", "Fifteen", "Thirty", "Forty" };
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
            if (_player1Score == _player2Score)
                return _player1Score < 3 ? $"{Points[_player1Score]}-All" : "Deuce";

            if (_player1Score < 4 && _player2Score < 4)
                return $"{Points[_player1Score]}-{Points[_player2Score]}";




            score = _player1Score > _player2Score ? _player1Name : _player2Name;
            return ((_player1Score - _player2Score) * (_player1Score - _player2Score) == 1) ? "Advantage " + score : "Win for " + score;
            
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

