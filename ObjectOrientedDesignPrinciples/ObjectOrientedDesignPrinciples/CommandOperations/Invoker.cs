namespace ObjectOrientedDesignPrinciples.CommandOperations
{
    /// <summary>
    /// Class that defines invoker
    /// </summary>
    public class Invoker
    {
        private ICommand _command;

        /// <summary>
        /// Method which activates ICommand commands
        /// </summary>
        /// <param name="command">Command</param>
        public void ExecuteCommand(ICommand command)
        {
            if (command == null)
            {
                return;
            }

            _command = command;
            _command.Execute();
        }
    }
}
