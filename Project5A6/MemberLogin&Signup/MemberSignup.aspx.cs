using Microsoft.Web.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemberLoginPages
{
    public partial class MemberSignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Signup button when clicked, uses the newMember service to check if the username already exists
        //and also checks if the passwords are the same or not
        //if the captcha is not checked however the signup will not work, until you verify the captcha
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text;
            string newPassword = txtPassword.Text;
            string confirmPassword = txtConfirm.Text;


            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            string recaptchaResponse = Request.Form["g-recaptcha-response"];

            //call the captcha service, to see if the user verified
            //if yes then call the service, else give an error message
            bool isCaptchaValid = Captcha(recaptchaResponse);
            if (isCaptchaValid)
            {
                string memberAdded = service.newMember(newUsername, newPassword, confirmPassword);
                lblTrue.Text = memberAdded;

            }
            else
            {
                // Display an error message when reCAPTCHA is not valid
                lblTrue.Text = "reCAPTCHA validation failed. Please try again.";
            }


        }

        //Button on the top right to redirect user back to login page
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberLogin.aspx");
        }
        
        //Captcha method that takes the secretkey from the google recaptcha created
        //goes through the webclient to confirm and create the captcha for the user, if the checkmarkis pressed then return a success
        private bool Captcha(string response)
        {
            string secretKey = "6LfydQwpAAAAAD66HXA3-qMkWTcZ-kvZU-JRdngf"; // Replace with your actual secret key
            string apiUrl = $"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={response}";

            using (WebClient client = new WebClient())
            {
                string jsonResult = client.DownloadString(apiUrl);
                var result = JsonConvert.DeserializeObject<Recaptcha>(jsonResult);

                return result.Success;
            }
        }

        private class Recaptcha
        {
            public bool Success { get; set; }
        }
    }
}