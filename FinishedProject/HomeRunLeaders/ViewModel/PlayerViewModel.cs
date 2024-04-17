namespace HomeRunLeaders.ViewModel
{
    [QueryProperty(nameof(Player),"Player")]
    public partial class PlayerViewModel : BaseViewModel
    {
        public PlayerViewModel() 
        { 

        }
        
        [ObservableProperty]
        Player player;
    }
}
