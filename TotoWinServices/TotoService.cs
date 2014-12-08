using System.ServiceModel;
using System.ServiceProcess;

namespace TotoWinServices
{
    public partial class TotoService : ServiceBase
    {
        internal static ServiceHost myServiceHost = null;

        public TotoService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (myServiceHost != null)
            {
                myServiceHost.Close();
            }
            myServiceHost = new ServiceHost(typeof (TotoService));
            myServiceHost.Open();
        }

        protected override void OnStop()
        {
            if (myServiceHost != null)
            {
                myServiceHost.Close();
                myServiceHost = null;
            }
        }
    }
}