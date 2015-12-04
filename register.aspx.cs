using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    public sendAndReceiveDataContext regMe = new sendAndReceiveDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private int checkFilled()
    {
        if (myName.Value != null)
        {
            return 9;
        }
        if (surname.Value != null)
        {
            return 8;
            
        }
        if (addressLine1.Value != null)
        {
            return 7;
        }
        if (addressLine2.Value != null)
        {
            return 6;
        }
        if (postalCode.Value != null)
        {
            return 5;
        }
        if (usrEmailAdd.Value == null && cellnum.Value == null)
        {
            return 1;
        }
        return 0;
    }


    protected void saveDatas_ServerClick(object sender, EventArgs e)
    {

        userDetail myDetails = new userDetail();
        myDetails.name = myName.Value;
        myDetails.surname = surname.Value;
        myDetails.addressLine1 = addressLine1.Value;
        myDetails.addressLine2 = addressLine2.Value;
        myDetails.postCode = postalCode.Value;
        myDetails.emailAddress = usrEmailAdd.Value;
        myDetails.cellphoneNumber = cellnum.Value;
        if(pswd1.Value == Password1.Value)
        {
            myDetails.password = pswd1.Value; // Must hash for securty!!!
            regMe.userDetails.InsertOnSubmit(myDetails);
            regMe.SubmitChanges();
            string myNameIs = myDetails.name;
            //showScript.InnerHtml = "<script>localStorage.setItem('theUsersName','" + myNameIs + "');</script>";
            //showScript.InnerHtml = "<script> alert('Hello: " + myNameIs.ToString() + "');</script>";
            //Response.Redirect("signin.aspx");
        }
        else
        {
            
            showScript.InnerHtml = "<script> alert('Check the details you provided');</script>";
        }
        
    }
}