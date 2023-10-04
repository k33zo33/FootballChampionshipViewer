using System.IO;

namespace DataAccessLayer.Constants
{
    public static class ApiConstants
    {
        //File
        public static string FemaleGroupResultsLocation = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Json/women_group_results.json");
        public static string FemaleMatchesLocation = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Json/women_matches.json");
        public static string FemaleResultsLocation = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Json/women_results.json");
        public static string FemaleTeamsLocation = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Json/women_teams.json");

        public static string MaleGroupResultsLocation = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Json/men_group_results.json");
        public static string MaleMatchesLocation = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Json/men_matches.json");
        public static string MaleResultsLocation = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Json/men_results.json");
        public static string MaleTeamsLocation = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Json/men_teams.json");


        //Web
        public const string FemaleTeamsWebLocation = "https://worldcup-vua.nullbit.hr/women/teams/results";
        public const string FemaleMatchesWebLocation = "https://worldcup-vua.nullbit.hr/men/matches";
        public const string FemaleDetailedMatchesWebLocation = "https://worldcup-vua.nullbit.hr/women/matches/country?fifa_code=ENG";

        public const string MaleTeamsWebLocation = "https://worldcup-vua.nullbit.hr/men/teams/results";
        public const string MaleMatchesWebLocation = "https://worldcup-vua.nullbit.hr/men/matches";
        public const string MaleDetailedMatchesWebLocation = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=ENG";

    }
}
