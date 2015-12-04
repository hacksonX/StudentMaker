using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for calculateAPS
/// </summary>
public class calculateAPS
{
    sendAndReceiveDataContext savingdatas = new sendAndReceiveDataContext();
    public calculateAPS()
    {
        
        //
        // TODO: Add constructor logic here
        //
    }

    public void storeResultsinDB()
    {
        //Store a users results on the database
        //sendAndReceiveDataContext savingdatas = new sendAndReceiveDataContext();

        studentResult myResults = new studentResult();
        myResults.myID = dataStore.thisIsMyID;
        myResults.englishFLMark = dataStore.engFLMark;
        myResults.endlishFALMark = dataStore.engFALMark;
        myResults.endlish2ndLMark = dataStore.eng2ndMark;

        savingdatas.studentResults.InsertOnSubmit(myResults);
        savingdatas.SubmitChanges();

    }

    public bool calAPS() {
        var getMyResultsAndCal = from myMarks in savingdatas.studentResults where myMarks.id == dataStore.thisIsMyID select myMarks;
        if (getMyResultsAndCal.Count() > 0)
        {
            int forWits = witsAPS();
        }
        return false;
        
    }

    public int witsAPS()
    {
        var getMyResultsAndCal = from myMarks in savingdatas.studentResults where myMarks.id == dataStore.thisIsMyID select myMarks;
        int toRet = 0;
        int theMathsTemp = Int32.Parse(getMyResultsAndCal.First().mathematicsMark.ToString());
        if(theMathsTemp == 0)
        {
            toRet += 0;
        }
        else if(theMathsTemp >= 1 && theMathsTemp <= 49)
        {
            toRet += 0;
        }
        else if (theMathsTemp >= 50 && theMathsTemp <= 59)
        {
            toRet += 5;
        }
        else if (theMathsTemp >= 60 && theMathsTemp <= 69)
        {
            toRet += 6;
        }
        else if (theMathsTemp >= 70 && theMathsTemp <= 79)
        {
            toRet += 7;
        }
        else if (theMathsTemp >= 80 && theMathsTemp <= 89)
        {
            toRet += 9;
        }
        else if (theMathsTemp >= 90 && theMathsTemp <= 100)
        {
            toRet += 10;
        }
        return toRet;
    }

}