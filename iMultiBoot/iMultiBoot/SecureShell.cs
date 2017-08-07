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

        }

        public void Connect(string DeviceHostName, string UserName, string UserPassword)
        {
            try
            {
                sessionOptions = new SessionOptions
                {
                    Protocol = Protocol.Sftp,
                    HostName = DeviceHostName,
                    UserName = UserName,
                    Password = UserPassword
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

        public void UploadFile(string pLocalFilePath, string pRemoteFilePath)
        {
            TransferOptions transferOptions = new TransferOptions();
            transferOptions.TransferMode = TransferMode.Binary;
            TransferOperationResult transferResult;
            transferResult = session.PutFiles(pLocalFilePath, pRemoteFilePath, false, transferOptions);
        }
    }
}