using System.Reflection;

namespace APIHelper
{
    public static class Helper
    {
        public static string GetCurrentWorkingDirectory()
        {
            string workingDirectory = Environment.CurrentDirectory;
            return Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        }
    }
}
