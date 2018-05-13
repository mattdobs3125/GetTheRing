using DataLayer1.PRoviders;

namespace GetThyRing
{
    public class GameService
    {
        private GameProvider _GameP = new GameProvider();
        private int _itemiD { get; set; }
        private bool GamePlaying { get; set; }
        private bool Pausecc { get; set; } 
        public bool Runinng { get; private set; }
        private Menu GameMenu { get; set; }
    }
}