namespace CompilerProject.Controllers
{
    public class CompilerManager
    {
        public static CompilerManager instance;

        public int state;
        public void Awake()
        {
            instance = this;
        }
        public void resetState()
        {
            this.state = 0;
        }
        public void setState(int stateNumber)
        {
            this.state = stateNumber;
        }
    }
}
