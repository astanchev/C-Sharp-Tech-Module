using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    class Team
    {
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeamsToRegister = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            CreateTeam(numberOfTeamsToRegister, teams);

            JoinTeam(teams);

            List<Team> teamsWithMembers = teams
                                           .Where(t => t.Members.Count > 0)
                                           .OrderByDescending(t => t.Members.Count)
                                           .ThenBy(t => t.Name)
                                           .ToList();


            List<Team> teamsToDisband = teams
                                          .Where(t => t.Members.Count == 0)
                                          .OrderBy(t => t.Name)
                                          .ToList();

            PrintTeamsWithMembers(teamsWithMembers);

            PrintTeamsToDisband(teamsToDisband);

        }

        private static void CreateTeam(int numberOfTeamsToRegister, List<Team> teams)
        {
            for (int i = 0; i < numberOfTeamsToRegister; i++)
            {
                string[] createTeams = Console.ReadLine().Split('-').ToArray();
                string creator = createTeams[0];
                string teamName = createTeams[1];

                bool isTeamCreated = GetIsTeamCreated(teams, teamName);

                bool isAcreator = GetIsAcreator(teams, creator);

                if (isTeamCreated)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (isAcreator)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }

        private static void JoinTeam(List<Team> teams)
        {
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "end of assignment")
                {
                    break;
                }
                string[] teamJoining = inputLine.Split("->").ToArray();
                string member = teamJoining[0];
                string teamToJoin = teamJoining[1];

                bool isTeamExists = GetIsTeamExists(teams, teamToJoin);
                bool isAMember = IsAMember(teams, member);

                if (!isTeamExists)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }
                else if (isAMember)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                    continue;
                }
                else
                {
                    int indexOfTeamToJoin = teams.FindIndex(t => t.Name == teamToJoin);
                    teams[indexOfTeamToJoin].Members.Add(member);
                }

            }
        }

        private static bool GetIsAcreator(List<Team> teams, string creator)
        {
            bool isAcreator = false;
            foreach (var team in teams)
            {
                if (team.Creator==creator)
                {
                    isAcreator = true;
                }
            }

            return isAcreator;
        }

        private static bool GetIsTeamCreated(List<Team> teams, string teamName)
        {
            bool isTeamCreated = false;
            foreach (var team in teams)
            {
                if (team.Name == teamName)
                {
                    isTeamCreated = true;
                }
            }
            return isTeamCreated;
        }

        private static bool IsAMember(List<Team> teams, string member)
        {
            bool isAmember = false;

            foreach (var team in teams)
            {
                if (team.Creator == member)
                {
                    isAmember = true;
                }
                if (team.Members.Contains(member))
                {
                    isAmember = true;
                }
            }

            return isAmember;
        }

        private static bool GetIsTeamExists(List<Team> teams, string teamToJoin)
        {
            bool isTeamExists = false;
            foreach (var team in teams)
            {
                if (team.Name == teamToJoin)
                {
                    isTeamExists = true;
                }
            }
            return isTeamExists;
        }

        private static void PrintTeamsToDisband(List<Team> teamsToDisband)
        {
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine($"{team.Name}");
            }
        }

        private static void PrintTeamsWithMembers(List<Team> teamsWithMembers)
        {
            if (teamsWithMembers.Count == 0)
            {
                return;
            }
            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(t => t))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }
}
