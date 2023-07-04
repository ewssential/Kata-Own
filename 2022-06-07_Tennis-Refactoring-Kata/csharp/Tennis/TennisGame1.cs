namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private const string Player1 = "player1";
        private int _score1;
        private int _score2;

        public void WonPoint(string playerName)
        {
            if (playerName == Player1)
                _score1 += 1;
            else
                _score2 += 1;
        }

        public string GetScore()
        {
            string score = "";
            if (_score1 == _score2)
            {
                return Foo();
            }

            if (_score1 >= 4 || _score2 >= 4)
            {
                return Score();
            }

            for (var i = 1; i < 3; i++)
            {
                int tempScore;
                if (i == 1) tempScore = _score1;
                else { score += "-"; tempScore = _score2; }

                score += MapPointToTennisPoint(tempScore);
            }
            return score;
        }

        private static string MapPointToTennisPoint(int tempScore)
        {
            return tempScore switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                _ => "Forty",
            };
        }

        private string Score()
        {
            string score;
            var minusResult = _score1 - _score2;
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";
            else if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }

        private string Foo()
        {
            string score = _score1 switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };

            return score;
        }
    }
}

