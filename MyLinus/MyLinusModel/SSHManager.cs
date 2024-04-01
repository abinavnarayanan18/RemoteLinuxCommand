using Renci.SshNet;
using System;

namespace MyLinus
{
    public class SSHManager
    {
        private static SSHManager instance;
        private SshClient client;

        private SSHManager()
        {
        }

        // Singleton pattern to ensure only one instance of SSHManager exists
        public static SSHManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SSHManager();
                }
                return instance;
            }
        }

        // Method to connect to the SSH server
        public void Connect(string host, string username, string password, string pemFilePath = @"C:\Users\vigne\OneDrive\Desktop\EXE\MyLinus\MyLinus\MyLinus\mylinux.pem")
        {
            try
            {
                if (pemFilePath != null)
                {
                    // If PEM file path is provided, connect using private key authentication
                    var privateKeyFile = new PrivateKeyFile(pemFilePath);
                    var keyFiles = new[] { privateKeyFile };
                    var connectionInfo = new ConnectionInfo(host, username, new PrivateKeyAuthenticationMethod(username, keyFiles));
                    client = new SshClient(connectionInfo);
                }
                else
                {
                    // Connect using password authentication
                    client = new SshClient(host, username, password);
                }

                // Connect to the SSH server
                client.Connect();
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to SSH server: " + ex.Message);
            }
        }

        // Method to execute a command on the SSH server and return the output
        public string ExecuteCommand(string command)
        {
            try
            {
                var commandResult = client.RunCommand(command);
                return commandResult.Result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing command: " + ex.Message);
            }
        }

        // Method to disconnect from the SSH server
        public void Disconnect()
        {
            if (client != null)
            {
                client.Disconnect();
                client.Dispose();
            }
        }
    }
}
