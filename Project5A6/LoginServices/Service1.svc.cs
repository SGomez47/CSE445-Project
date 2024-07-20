using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;
using System.Xml;

namespace MemberLoginService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //verifyMember reads the xml file within App_Data to verify if a login username and password are true
        public Boolean verifyMember(string username, string password)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string filepath = HostingEnvironment.MapPath("~/App_Data/Members.xml");
            xmlDoc.Load(filepath);
            XmlNodeList element = xmlDoc.GetElementsByTagName("Member");

            //Encryt and compare the password given to the one on the xml file
            string hashed_password;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));

                hashed_password = builder.ToString();
            }

            //First checking if the username exist within the file then checking the password
            //if exist return true if not return false
            if (element.Count > 0)
            {
                foreach (XmlNode member in element)
                {
                    if (member.SelectSingleNode("Username").InnerText == username)
                    {
                        if (member.SelectSingleNode("Password").InnerText == hashed_password)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //newMember linked to the signup page, creates a member account by username and password
        //read from an xml file then write to it
        public string newMember(string username, string password, string confirmPassword)
        {
            string filepath = HostingEnvironment.MapPath("~/App_Data/Members.xml");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filepath);

            //Encrypt the password given from user and add it to the xml file for security measures
            string hashed_password;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));

                hashed_password = builder.ToString();
            }

            //Check to see if username already exist within the xml file
            //returns the string Username already exists
            XmlNodeList element = xmlDocument.GetElementsByTagName("Member");
            if (element.Count > 0)
            {
                foreach (XmlNode member in element)
                {
                    if (member.SelectSingleNode("Username").InnerText == username)
                    {
                        return "Username already exists";
                    }
                }
            }

            //Checks to see if both password and confirm password are the same to add the user
            //if not the service returns Passwords are not the same
            if (password.Equals(confirmPassword))
            {
                XmlElement newMember = xmlDocument.CreateElement("Member");

                XmlElement usernameElement = xmlDocument.CreateElement("Username");
                usernameElement.InnerText = username;
                newMember.AppendChild(usernameElement);

                XmlElement passwordElement = xmlDocument.CreateElement("Password");
                passwordElement.InnerText = hashed_password;
                newMember.AppendChild(passwordElement);

                XmlNode parksRoot = xmlDocument.SelectSingleNode("/Members");
                parksRoot.AppendChild(newMember);
                xmlDocument.Save(filepath);

                return "Account was created";
            }
            else
            {
                return "Passwords are not the same";
            }

        }
    }
}
