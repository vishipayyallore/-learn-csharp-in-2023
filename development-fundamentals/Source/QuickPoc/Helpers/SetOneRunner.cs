using QuickPoc.Set1;

namespace QuickPoc.Helpers
{
    public class SetOneRunner
    {
        private readonly ProgramRunner _programRunner;

        public SetOneRunner(ProgramRunner programRunner)
        {
            _programRunner = programRunner ?? throw new ArgumentNullException(nameof(programRunner));
        }

        public void Run()
        {
            _programRunner.Run(new EnvironmentDetials(), "Environment Details");
        }

    }

}
