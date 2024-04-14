using HomeRunLeaders.Model;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace HomeRunLeaders.Services
{
    public class LeadersService
    {
        HttpClient httpClient;
        public LeadersService()
        {
            httpClient = new HttpClient();
        }

        Leaders leaders = new();
        List<Player> players = new();
        List<HomeRuns> homeRunLeaders = new();

        public async Task<List<HomeRuns>> GetHrLeaders()
        {
            if (homeRunLeaders.Count > 0)
                return homeRunLeaders;


            var leadersUrl = "https://sports.core.api.espn.com/v2/sports/baseball/leagues/mlb/seasons/2024/types/2/leaders?lang=en&region=us";
            
            var response = await httpClient.GetAsync(leadersUrl);
            var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);


            if (response.IsSuccessStatusCode)
            {
                try
                {
                    leaders = await response.Content.ReadFromJsonAsync<Leaders>(options);
                    foreach (var item in leaders.categories) 
                    {
                        if(item.name == "homeRuns")
                        {
                            foreach (var hrLeader in item.leaders)
                            {
                                HomeRuns homeRunLeader = new();
                                homeRunLeader.HomeRunsCount = (int)hrLeader.value;
                                // Get the player record
                                var hrResponse = await httpClient.GetAsync(hrLeader.athlete._ref);
                                var athlete = await hrResponse.Content.ReadFromJsonAsync<Player>(options);
                                homeRunLeader.Id = athlete.id;
                                homeRunLeader.Jersey = athlete.jersey;
                                homeRunLeader.Position = athlete.position.name;
                                homeRunLeader.Name = athlete.fullName;
                                homeRunLeader.HeadShot = athlete.headshot.href;

                                // Get the Teams
                                //var teamResponse = await httpClient.GetAsync(homeRunLeader.Team);

                                homeRunLeaders.Add(homeRunLeader);
                                players.Add(athlete);
                                
                            }
                        }
                    }

                }
                catch (Exception ex)
                {

                    leaders = new();
                }
            }

            return homeRunLeaders;
        }
    }
}
