using DebtBuddy.Forms.UWP;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using DebtBuddy.Forms.Interfaces;

[assembly: Dependency(typeof(FileHelper))]
namespace DebtBuddy.Forms.UWP
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
