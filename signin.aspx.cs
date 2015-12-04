using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class signin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void signMeIn_ServerClick(object sender, EventArgs e)
    {
        sendAndReceiveDataContext signMeIn = new sendAndReceiveDataContext();
        var logViaEmail = (from mydetails in signMeIn.userDetails where mydetails.emailAddress == myUsername.Value && mydetails.password == myPswd.Value select mydetails);
        var logViaCell = (from mydetails in signMeIn.userDetails where mydetails.cellphoneNumber == myUsername.Value && mydetails.password == myPswd.Value select mydetails);
        if(logViaCell.Count()>0 || logViaEmail.Count() > 0)
        {
            if(logViaCell.Count()> 0)
            {
                Session.Add("myID", logViaCell.First().id);
                dataStore.thisIsMyID = logViaCell.First().id;
                Response.Redirect("index.aspx");
            }
            else
            {
                Session.Add("myID", logViaEmail.First().id);
                dataStore.thisIsMyID = logViaCell.First().id;
                Response.Redirect("index.aspx");
            }
        }
        else
        {
            //Show not loged in message
        }
    }
}