using HomeRunLeaders.Services;

namespace HomeRunLeaders.ViewModel
{
    public partial class LeadersViewModel : BaseViewModel
    {
        LeadersService leaderService;

        public ObservableCollection<HomeRuns> HrLeaders { get; } = new(); 

        public LeadersViewModel(LeadersService leaderService)
        {
            Title = "Home Run Leaders";
            this.leaderService = leaderService;
        }

        [RelayCommand]
        async Task GoToDetails(HomeRuns hrLeader)
        {
            if (hrLeader is null) 
            {
                return;
            }

            var player = leaderService.GetPlayer(hrLeader.Id);
            if (player is null) return;

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
                new Dictionary<string, object>
                {
                    {"Player", player }
                });
        }

        [RelayCommand]
        async Task GetLeadersAsync()
        {
            if(IsBusy) return;

            try
            {
                IsBusy = true;
                var hrLeaders = await leaderService.GetHrLeaders();

                if(hrLeaders.Count != 0) { HrLeaders.Clear(); }

                foreach(var hrLeader in hrLeaders)
                {
                    HrLeaders.Add(hrLeader);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error", $"Unable to get leader list", "OK");

            }
            finally { IsBusy = false; }
        }
    }
}
