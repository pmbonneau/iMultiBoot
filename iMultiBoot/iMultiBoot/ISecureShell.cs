namespace iMultiBoot
{
    interface ISecureShell
    {
        void ExecuteRemoteCommand(string CommandToExecute);
        string ExecuteRemoteCommandWithOutput(string CommandToExecute);
    }
}
