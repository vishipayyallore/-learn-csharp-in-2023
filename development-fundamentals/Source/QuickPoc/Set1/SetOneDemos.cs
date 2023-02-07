using QuickPoc.Helpers;

namespace QuickPoc.Set1
{
    public class SetOneDemos
    {
        private readonly ProgramRunner _programRunner;

        public SetOneDemos(ProgramRunner programRunner)
        {
            _programRunner = programRunner ?? throw new ArgumentNullException(nameof(programRunner));
        }

        public void Run()
        {
            _programRunner.Run(new EnvironmentDetials(), "Environment Details");
        }

    }

}
