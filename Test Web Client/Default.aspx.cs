using System;
using System.Web.UI;
using Test_Web_Client.ServiceReference1;

namespace Test_Web_Client
{
    public partial class _Default : Page
    {
        private DateTime endDt;
        private DateTime startDT;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                startDT = DateTime.Now;
                GetServiceAsync();
            }
        }

        private async void GetServiceAsync()
        {
            using (var sc = new Service1Client())
            {
                string s = await sc.GetNameAsync();
                endDt = DateTime.Now;
                lblService.Text = startDT + "/" + s + "/" + endDt;
            }
        }
    }
}