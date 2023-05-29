using System;
using System.Collections.Generic;

namespace Football
{
    public class Program
    {
        public static void Main()
        {
            FootballPlayer player1 = new FootballPlayer("FootballPlayer 1", 25, 1, 180);
            FootballPlayer player2 = new FootballPlayer("FootballPlayer 2", 26, 2, 185);
            FootballPlayer player3 = new FootballPlayer("FootballPlayer 3", 27, 3, 175);

            Coach coach1 = new Coach("Coach 1", 40);
            List<FootballPlayer> team1Players = new List<FootballPlayer> { player1, player2, player3 };
            Team team1 = new Team(coach1, team1Players);

            Coach coach2 = new Coach("Coach 2", 45);
            List<FootballPlayer> team2Players = new List<FootballPlayer> { /* други играчи */ };
            Team team2 = new Team(coach2, team2Players);

            Referee referee = new Referee("Referee 1", 35);
            List<AssistantReferee> assistantReferees = new List<AssistantReferee>
        {
            new AssistantReferee("AssistantReferee 1", 30),
            new AssistantReferee("AssistantReferee 2", 32)
        };

            Game game = new Game(team1, team2, referee, assistantReferees);

            game.AddGoal(10, player1);
            game.AddGoal(30, player2);

            game.SetResult("3-1", team1);

            Console.WriteLine("Result: " + game.Result);
            Console.WriteLine("Winner: " + game.Winner.Coach.Name);
        }
    }
}
