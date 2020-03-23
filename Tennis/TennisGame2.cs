using System;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private static readonly string[] Points = { "Love", "Fifteen", "Thirty", "Forty" };
        private readonly string _player1Name;
        private readonly string _player2Name;
        private int _player1Score = 0;
        private int _player2Score = 0;      

        public TennisGame2(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GetScore()
        {
            if (_player1Score == _player2Score)
                return _player1Score < 3 ? $"{Points[_player1Score]}-All" : "Deuce";

            if (_player1Score < 4 && _player2Score < 4)
                return $"{Points[_player1Score]}-{Points[_player2Score]}";

            int difference = Math.Abs(_player1Score - _player2Score);
            if (difference == 1)
                return $"Advantage {(_player1Score > _player2Score ? _player1Name : _player2Name)}";

            return $"Win for {(_player1Score > _player2Score ? _player1Name : _player2Name)}";
        }

        public void IncrementPlayer1Score(int number)
        {
            _player1Score += number;
        }

        public void IncrementPlayer2Score(int number)
        {
            _player2Score += number;
        }

        private void IncrementPlayer1Score()
        {
            _player1Score++;
        }

        private void IncrementPlayer2Score()
        {
            _player2Score++;
        }

        public void WonPoint(string playerName)
        {
            if (playerName.Equals(_player1Name))
                IncrementPlayer1Score();
            else
                IncrementPlayer2Score();
        }

    }
}

