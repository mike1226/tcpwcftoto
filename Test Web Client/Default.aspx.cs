using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_Web_Client
{
    public partial class _Default : Page
    {
        private DateTime startDT;
        private DateTime endDt;
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
            using (ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client())
            {
                string s = await sc.GetNameAsync();
                endDt = DateTime.Now;
                this.lblService.Text = startDT.ToString() + "/" + s.ToString() + "/" + endDt.ToString();
            }
        }

    }
}