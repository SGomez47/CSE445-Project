using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4CSE445
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            //grab url and element key from text boxes
            string url = txtBoxXmlInp.Text;
            string key = txtBoxKey.Text;
            //grab the output from our service and display it in a label
            string output = service.search(url, key);
            lblOutput.Text = output.ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            //grab the new park info from textboxes
            string type = txtType.Text;
            string name = txtName.Text;
            string owner = txtOwner.Text;
            string address = txtAddress.Text;
            string url = txtUrl.Text;
            string states = txtStates.Text;
            string date = txtDate.Text;
            string founder = txtFounder.Text;

            //if all the required infromation except founder is within the textboxes then proceed to the service
            if(type!=null && name!=null && owner != null
                && address!=null && states != null && date != null)
            {
                service.addPark(type, name, owner, address, url, states, date, founder);
                lblNum10.Text = "Park was added";
            }
            //Otherwise if not all is within the textboxes display that we are missing informaton
            else
            {
                lblNum10.Text = "You are missing infromation";
            }


        }
    }
}