using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL2;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.IO;

namespace ECOMMERCEAPPASP2.ADMIN
{
    public partial class FeedBackAdm : System.Web.UI.Page
    {
        SelectCls Sel = new SelectCls();
        UpdateCls Upd = new UpdateCls();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet Ds = Sel.FeedSel();
                GridView1.DataSource = Ds;
                GridView1.DataBind();

            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pn1.Visible = true;
            GRIDPANEL.Visible = false;
            Button btn = (Button)sender;
            string value = btn.CommandArgument;
            Session["MID"] = value;
            //LB1.Text = value;
        }

        protected void SndMail_Click(object sender, EventArgs e)
        {
            
            string Email = Sel.FeedBackGet(Session["MID"].ToString());
            string Name = "Essense";
            string Reply = RMSG.Text;
            SendEmail3("Essense ECOM Corp", "jaisonjeswin63@gmail.com", "mblu czen xqqy hhyg", "USER", Email, "FEEDBACK REPLY", Reply);
            Upd.FeedUpdate(Session["MID"].ToString());
            if (!IsPostBack)
            {
                
                DataSet Ds = Sel.FeedSel();
                GridView1.DataSource = Ds;
                GridView1.DataBind();

            }
            Pn1.Visible = false;
            GRIDPANEL.Visible = true;



        }
        public static void SendEmail3(string yourName, string yourGmailUserName,string yourGmailPassword, string toName, string toEmail, string subject, string body)

        {
            string to = toEmail; //To address
            string from = yourGmailUserName; //From address
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmailsmtp
            System.Net.NetworkCredential basicCredential1 = new System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}