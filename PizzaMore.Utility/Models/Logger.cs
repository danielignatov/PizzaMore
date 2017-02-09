namespace PizzaMore.Utility.Models
{
    using System;
    using System.IO;

    public class Logger
    {
        #region Fields
        private string logFilePath = "log.txt";
        #endregion

        #region Methods
        public void Log(string message)
        {
            File.AppendAllText(this.logFilePath, message + Environment.NewLine);
        }
        #endregion
    }
}