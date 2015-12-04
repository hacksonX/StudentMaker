using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    sendAndReceiveDataContext toDb = new sendAndReceiveDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private bool saveMyMarksOnClass()
    {
        if (english.Checked == true)
        {
            //Stores value after conversion
            dataStore.engFLMark = Int32.Parse(myEnglishMark.Value);
        }
        if (endlishFAL.Checked)
        {
            dataStore.engFALMark = Int32.Parse(myEnglishMark.Value);
        }
        if (endlish2ndLang.Checked)
        {
            dataStore.eng2ndMark = Int32.Parse(myEnglishMark.Value);
        }
        //Store maths Mark
        //Check the type of maths first
        if (mathematics.Checked)
        {
            dataStore.pureMathMark = Int32.Parse(myMathsMark.Value);
        }
        if (mathsLiteracy.Checked)
        {
            dataStore.mathLitMark = Int32.Parse(myMathsMark.Value);
        }
        //Store LO
        dataStore.lOMark = Int32.Parse(myLOMark.Value);

        //Store Vernecular
        if (vernec.Checked)
        {
            dataStore.verFLMark = Int32.Parse(myVernechMark.Value);
        }
        if (vernectFAL.Checked)
        {
            dataStore.vernFALMark = Int32.Parse(myVernechMark.Value);
        }
        if (vernec2ndLang.Checked)
        {
            dataStore.ver2ndMark = Int32.Parse(myVernechMark.Value);
        }
        //Store Optional 1
        if (accounting.Checked)
        {
            dataStore.accMark = Int32.Parse(myOptional1.Value);
        }
        if (history.Checked)
        {
            dataStore.histMark = Int32.Parse(myOptional1.Value);
        }
        if (physical.Checked)
        {
            dataStore.PSMark = Int32.Parse(myOptional1.Value);
        }
        //Store Optional 2
        if (business.Checked)
        {
            dataStore.bSMark = Int32.Parse(myOptional2.Value);
        }
        if (lifesciences.Checked)
        {
            dataStore.LSMark = Int32.Parse(myOptional2.Value);
        }
        if (tourism.Checked)
        {
            dataStore.tourMark = Int32.Parse(myOptional2.Value);
        }
        //Store Optional 3
        if (geo.Checked)
        {
            dataStore.geoMark = Int32.Parse(myOptional3.Value);
        }
        if (ecos.Checked)
        {
            dataStore.econMark = Int32.Parse(myOptional3.Value);
        }
        return true;
    }

    protected void Unnamed_ServerClick(object sender, EventArgs e)
    {
        if(Session["myID"] == null)
        {
            Response.Redirect("signin.aspx");
        }
        else
        {
            if (saveMyMarksOnClass())
            {
                //Create the object for the database
                studentResult myRes = new studentResult();
                int theSetID = Int32.Parse(Session["myID"].ToString());
                myRes.myID = theSetID;
                myRes.accountingMark = dataStore.accMark;
                myRes.businessStudiesMark = dataStore.bSMark;
                myRes.economicsMark = dataStore.econMark;
                myRes.endlish2ndLMark = dataStore.eng2ndMark;
                myRes.endlishFALMark = dataStore.engFALMark;
                myRes.englishFLMark = dataStore.engFLMark;
                myRes.geographyMark = dataStore.geoMark;
                myRes.physicalSciencesMark = dataStore.PSMark;
                myRes.lifeSciencesMark = dataStore.LSMark;
                myRes.lifeOrientationMark = dataStore.lOMark;
                myRes.mathematicsMark = dataStore.pureMathMark;
                myRes.mathsLiteracyMark = dataStore.mathLitMark;
                myRes.historyMark = dataStore.histMark;
                myRes.tourismMark = dataStore.tourMark;
                myRes.vernecular2ndLMark = dataStore.ver2ndMark;
                myRes.vernecularFALMark = dataStore.vernFALMark;
                myRes.vernercularFLMark = dataStore.verFLMark;
                //Saving on db
                toDb.studentResults.InsertOnSubmit(myRes);
                toDb.SubmitChanges();
                Response.Redirect("myAPS.aspx");
            }
            
        }
    }
}