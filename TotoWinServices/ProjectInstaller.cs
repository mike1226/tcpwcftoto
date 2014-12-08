using System.ComponentModel;
using System.Configuration.Install;

namespace TotoWinServices
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}