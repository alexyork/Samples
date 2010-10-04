﻿using System;

namespace CleanCode
{
    public class Tennis
    {
        private int pointsForPlayer1;
        private int pointsForPlayer2;

        public string PrintScore()
        {
            if (OnePlayerLeadsFortyToLove())
                return LeadingPlayer() + " wins";

            if (BothPlayersHaveFortyOrMore() && BothPlayersHaveTheSameScore())
                return "deuce";

            if (BothPlayersHaveFortyOrMore() && APlayerLeadsByOnePoint())
                return "advantage " + LeadingPlayer();

            return string.Format("{0} - {1}", GetScore(pointsForPlayer1), GetScore(pointsForPlayer2));
        }

        private string GetScore(int points)
        {
            if (points == 1) return "fifteen";
            if (points == 2) return "thirty";
            if (points == 3) return "forty";
            return "love";
        }

        private bool APlayerLeadsByOnePoint()
        {
            return Math.Abs(pointsForPlayer1 - pointsForPlayer2) == 1;
        }

        private bool BothPlayersHaveTheSameScore()
        {
            return pointsForPlayer1 == pointsForPlayer2;
        }

        private bool BothPlayersHaveFortyOrMore()
        {
            return pointsForPlayer1 > 2 && pointsForPlayer2 > 2;
        }

        private string LeadingPlayer()
        {
            return (pointsForPlayer1 > pointsForPlayer2) ? "Player1" : "Player2";
        }

        private bool OnePlayerLeadsFortyToLove()
        {
            return Math.Abs(pointsForPlayer1 - pointsForPlayer2) >= 3;
        }

        public void AwardPointToPlayer1()
        {
            pointsForPlayer1++;
        }

        public void AwardPointToPlayer2()
        {
            pointsForPlayer2++;
        }
    }











    //public class Tennis
    //{
    //    private int winsPlayer1, winsPlayer2;

    //    public string PrintScore()
    //    {
    //        if (OnePlayerLeadFortyToLove())
    //            return LeadingPlayer() + " wins";

    //        if (BothPlayersHasWonMoreThanThreeBalls() && ScoreIsEqual())
    //            return "deuce";

    //        if (BothPlayersHasWonMoreThanThreeBalls() && APlayerLeadByOneBall())
    //            return "advantage " + LeadingPlayer();

    //        return string.Format("{0} - {1}", Score(winsPlayer1), Score(winsPlayer2));
    //    }

    //    private bool OnePlayerLeadFortyToLove()
    //    {
    //        return OnePlayerHasForty() && OnePlayerHasLove();
    //    }

    //    private bool OnePlayerHasLove()
    //    {
    //        return winsPlayer1 == 0 || winsPlayer2 == 0;
    //    }

    //    private bool OnePlayerHasForty()
    //    {
    //        return winsPlayer1 == 3 || winsPlayer2 == 3;
    //    }

    //    private string LeadingPlayer()
    //    {
    //        return winsPlayer1 > winsPlayer2 ? "Player1" : "Player2";
    //    }

    //    private bool BothPlayersHasWonMoreThanThreeBalls()
    //    {
    //        return winsPlayer1 > 2 && winsPlayer2 > 2;
    //    }

    //    private bool ScoreIsEqual()
    //    {
    //        return winsPlayer1 == winsPlayer2;
    //    }

    //    private bool APlayerLeadByOneBall()
    //    {
    //        return winsPlayer1 == winsPlayer2 + 1 || winsPlayer2 == winsPlayer1 + 1;
    //    }

    //    private static string Score(int balls)
    //    {
    //        if (balls == 1) return "fifteen";
    //        if (balls == 2) return "thirty";
    //        if (balls == 3) return "forty";

    //        return "love";
    //    }

    //    public void Player1WinsTheBall()
    //    {
    //        winsPlayer1++;
    //    }

    //    public void Player2WinsTheBall()
    //    {
    //        winsPlayer2++;
    //    }
    //}
}