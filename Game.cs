using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<AssistantReferee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee, List<AssistantReferee> assistantReferees)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferees = assistantReferees;
            Goals = new List<Goal>();
            Result = "";
            Winner = null;
        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            Goal goal = new Goal(minute, player);
            Goals.Add(goal);
        }

        public void SetResult(string result, Team winner)
        {
            Result = result;
            Winner = winner;
        }
    }
}
