using System;
using WinSCP;

namespace iMultiBoot
{
    public class SecureShell
    {
        public SessionOptions sessionOptions;
        public Session session;
        public SecureShell()
        {
            try
            {
                sessionOptions = new SessionOptions
                {
                    Protocol = Protocol.Sftp,
                    HostName = "",
                    UserName = "",
                    Password = ""
                };

                sessionOptions.GiveUpSecurityAndAcceptAnySshHostKey = true;

                session = new Session();
                session.Open(sessionOptions);

                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                return;
            }
        }

        public void ExecuteRemoteCommand(string CommandToExecute)
        {
            session.ExecuteCommand(CommandToExecute).Check();
        }

        public string ExecuteRemoteCommandWithOutput(string CommandToExecute)
        {
            return session.ExecuteCommand(CommandToExecute).Output;
        }
    }
}