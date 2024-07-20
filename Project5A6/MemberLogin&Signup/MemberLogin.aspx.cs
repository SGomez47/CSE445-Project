using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemberLoginPages
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Check to see if the user already has cookies for the site
            //if not say welcome user, else redirect them to the member pages
            HttpCookie userCookies = Request.Cookies["userCookieId"];
            if ((userCookies == null) || (userCookies["Username"] == ""))
            {
                lblNewUser.Text = "Welcome, new user";
            }
            else
            {
                //Member pages in webstrar page4
                Response.Redirect("http://webstrar28.fulton.asu.edu/page4/Member_Menu.aspx");
            }
        }
        
        //Login button when the user inputs a username and password that exist within the xml file in the services
        //Redirect them to the member page
        //if member doesn't exist within the xml file gice error message
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            //Call the service reference from page6
            //if statement checking if the user exists
            //if they do create cookies for the website so next time user enters login they
            //automatically enter member page
            Boolean memberExist = service.verifyMember(username, password);
            if (memberExist)
            {
                HttpCookie userCookies = new HttpCookie("userCookieID");
                userCookies["Username"] = txtUsername.Text;
                userCookies["Password"] = txtPassword.Text;
                userCookies.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Add(userCookies);

                Session["test"] = txtUsername.Text;
                Response.Redirect("http://webstrar28.fulton.asu.edu/page4/Member_Menu.aspx");
            }
            else
            {
                lblTrue.Text = "Username or Password is incorrect";
            }
        }

        //button on the top right of the web app to redirect to the signup page
        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberSignup.aspx");
        }
    }
}