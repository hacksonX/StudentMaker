function saveReg() {
	localStorage.setItem("myName", document.getElementById("name").innerText);
	localStorage.setItem("myUserName", document.getElementById("usrName").innerText);
	localStorage.setItem("mySurname", document.getElementById("surname").innerText);
	localStorage.setItem("idNumber", document.getElementById("idNumber").innerText);
	localStorage.setItem("addressLine1", document.getElementById("addressLine1").innerText);
	localStorage.setItem("addressLine2", document.getElementById("addressLine2").innerText);
	localStorage.setItem("postalCode", document.getElementById("postalCode").innerText);
	var paswd1 = document.getElementById("pswd1").innerText;
	var paswd2 = document.getElementById("pswd2").innerText;
	if (paswd1.toString() == paswd2.toString()) {
		localStorage.setItem("myPassword", document.getElementById("pswd1").value);
		window.location.href = "login.html";
	} else {
		alert("Passwords do not match!");
	}

}

function showPwd(){
	alert("My Password is: "+ localStorage.getItem("myPassword"));
}

function signMeIn() {
	var myUsrName = document.getElementById('username').innerText;
	var myPswd = document.getElementById("passwrd").innerText;
	if (myUsrName == localStorage.getItem("myUserName")) {
		if (myPswd == localStorage.getItem("myPassword")) {
			window.location.href = "myProfile.html";
		}
		else {
			alert("Wrong password");
		}
	}
	else {
		alert("Wrong Username");
	}
}
function createWitsAPS() {
	var myAPSScore = 0;
	var mySub1 = parseInt(document.getElementById("sub1").value);
	myAPSScore = myAPSScore + mySub1; //First Language
	var mySub2 = parseInt(document.getElementById("sub2").value);
	myAPSScore = myAPSScore + mySub2; //First Additional language
	var mySub3 = parseInt(document.getElementById("sub3").value);
	myAPSScore = myAPSScore + mySub3; //Maths
	var mySub4 = parseInt(document.getElementById("sub4").value);
	mySub4 = mySub4 / 2;
	myAPSScore = myAPSScore + mySub4; //LO
	var mySub5 = parseInt(document.getElementById("sub5").value);
	myAPSScore = myAPSScore + mySub5; //Choice sub 1
	var mySub6 = parseInt(document.getElementById("sub6").value);
	myAPSScore = myAPSScore + mySub6; //Choice sub 2
	var mySub7 = parseInt(document.getElementById("sub7").value);
	myAPSScore = myAPSScore + mySub7; //Maths
	localStorage.setItem("myWitsAPS", myAPSScore.toString());
	window.location.href = "Register.html";
}

function setName() {
	if (localStorage.getItem("myName") != null) {
		document.getElementById("pageInfor").innerText = localStorage.getItem("myName") + "'s Applications Point Scores are:";
	}
	if (localStorage.getItem("myWitsAPS") != null) {
		document.getElementById("myAPSWits").innerText = localStorage.getItem("myAPSWits");
	}
}

function showTheName() {
    //document.getElementById("usrnamed").innerText = localStorage.getItem('theUsersName');
    alert("My name is: " + localStorage.getItem('theUsersName').toString());
}

function storeMyMarksTemp() {
    localStorage.setItem("forMaths", document.getElementById("myMathsMark").innerText);
    localStorage.setItem("forEng", document.getElementById("myEnglishMark").innerText);
    localStorage.setItem("forVern", document.getElementById("myVernechMark").innerText);
    localStorage.setItem("forLO", document.getElementById("myLOMark").innerText);
    localStorage.setItem("forLS", document.getElementById("myOptional2").innerText);
    localStorage.setItem("forPS", document.getElementById("myOptional1").innerText);
    localStorage.setItem("forGeo", document.getElementById("myOptional3").innerText);
    
}

function restoreResults() {
    document.getElementById("myMathsMark").innerText = localStorage.getItem("forMaths");
    document.getElementById("myEnglishMark").innerText = localStorage.getItem("forEng");
    document.getElementById("myVernechMark").innerText = localStorage.getItem("forVern");
    document.getElementById("myLOMark").innerText = localStorage.getItem("forLO");
    document.getElementById("myOptional2").innerText = localStorage.getItem("forLS");
    document.getElementById("myOptional1").innerText = localStorage.getItem("forPS");
    document.getElementById("myOptional3").innerText = localStorage.getItem("forGeo");

}

function checkExists() {
    if (localStorage.getItem("forLO").toString() == null) {
        return;
    }
    else {
        restoreResults();
    }
}


//ID Store
var theUsrIDs;

function storeMyID() {
    theUsrIDs = localStorage.setItem("myIDis", document.getElementById("storingID").innerText);
}