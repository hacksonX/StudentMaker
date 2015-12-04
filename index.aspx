<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
		Applications Project
	</title>
    <link rel="stylesheet" href="https://storage.googleapis.com/code.getmdl.io/1.0.5/material.indigo-pink.min.css" />
	<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="javascript/dataStore.js"></script>
	<script src="https://storage.googleapis.com/code.getmdl.io/1.0.5/material.min.js"></script>
    <style>
		.svg-ic_menu_24px-dims {
			width: 24px;
			height: 24px;
		}
	</style>

</head>

<body onload="checkExists()">
    <form id="form1" runat="server">
    <div id="mainData" class="mdl-layout mdl-js-layout mdl-layout--fixed-header" style="width:inherit">
		<header class="mdl-layout__header">
			<div class="mdl-layout__header-row">
				<span class="mdl-layout-title">APS System</span>
				<div class="mdl-layout-spacer"></div>
               
			</div>
		</header>
		<div class="mdl-layout__drawer">
			<span class="mdl-layout-title">Links</span>
			<nav class="mdl-navigation">
				<a class="mdl-navigation__link mdl-color--deep-orange" href="myProfile.html">Home</a>
				<a class="mdl-navigation__link " href="login.html">Sign In</a>
				<a class="mdl-navigation__link linkColor" href="register.html">Registration</a>
				<a class="mdl-navigation__link linkColor" href="myResults.html">My APS</a>
			</nav>
		</div>
		<main class="mdl-layout__content">
			<div class="mdl-card mdl-shadow--8dp" style="margin-left:1%;margin-top:1%;margin-right:1%;width:inherit">
				<div class="mdl-card__title mdl-color--deep-orange-400" style="background-color:#3f51b5;color:white;">Enter the levels you obtained for the following subjects</div>
				<div class="mdl-card__supporting-text">
					<!-- Maths starts -->
                    <div class="mdl-card mdl-shadow--4dp" style="margin-left:8px;margin-top:5px;margin-bottom:1px;float:left;min-height:250px;width:270px">
                        <div class="mdl-card__title mdl-color--deep-orange-100">Mathematics</div>
                        <div runat="server" class="mdl-card__supporting-text">
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="mathematics">
                              <input runat="server" type="radio" id="mathematics" class="mdl-radio__button" name="myMaths" value="0" />
                              <span class="mdl-radio__label">Mathematics</span>
                            </label><br /><br />
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="mathsLiteracy">
                              <input runat="server" type="radio" id="mathsLiteracy" class="mdl-radio__button" name="myMaths" value="1" />
                              <span class="mdl-radio__label">Maths Literacy</span>
                            </label>
                            <div class="mdl-textfield mdl-js-textfield">
						        <label class="mdl-textfield__label">Percentage Obtained</label>
						        <input runat="server" class="mdl-textfield__input" type="number" id="myMathsMark" />
					        </div>
                        </div>
                    </div>
                    <!-- Maths end -->
                    <!-- English starts -->
                    <div class="mdl-card mdl-shadow--4dp" style="margin-left:8px;margin-top:5px;margin-bottom:1px;float:left;height:250px;width:270px">
                        <div class="mdl-card__title mdl-color--deep-orange-200">English</div>
                        <div class="mdl-card__supporting-text">
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="english">
                              <input runat="server" type="radio" id="english" class="mdl-radio__button" name="myEnglish" value="0" />
                              <span class="mdl-radio__label">English First Language</span>
                            </label>
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="endlishFAL">
                              <input runat="server" type="radio" id="endlishFAL" class="mdl-radio__button" name="myEnglish" value="1" />
                              <span class="mdl-radio__label">English First Additional Language</span>
                            </label>
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="endlish2ndLang">
                              <input runat="server" type="radio" id="endlish2ndLang" class="mdl-radio__button" name="myEnglish" value="2" />
                              <span class="mdl-radio__label">English second Language</span>
                            </label>
                            <div class="mdl-textfield mdl-js-textfield">
						        <label class="mdl-textfield__label">Percentage Obtained</label>
						        <input runat="server" class="mdl-textfield__input" type="number" id="myEnglishMark" />
					        </div>
                        </div>
                    </div>
                    <!-- English end -->
                    <!-- English starts -->
                    <div class="mdl-card mdl-shadow--4dp" style="margin-left:8px;margin-top:5px;margin-bottom:1px;float:left;width:270px;min-height:250px">
                        <div class="mdl-card__title mdl-color--deep-orange-300">Vernecular</div>
                        <div class="mdl-card__supporting-text">
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="vernec">
                              <input runat="server" type="radio" id="vernec" class="mdl-radio__button" name="myVernec" value="0"  />
                              <span class="mdl-radio__label">Vernecular First Language</span>
                            </label>
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="vernectFAL">
                              <input runat="server" type="radio" id="vernectFAL" class="mdl-radio__button" name="myVernec" value="1" />
                              <span class="mdl-radio__label">Vernecular First Additional Language</span>
                            </label>
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="vernec2ndLang">
                              <input runat="server" type="radio" id="vernec2ndLang" class="mdl-radio__button" name="myEnglish" value="2" />
                              <span class="mdl-radio__label">Vernecular second Language</span>
                            </label>
                            <div class="mdl-textfield mdl-js-textfield">
						        <label class="mdl-textfield__label">Percentage Obtained</label>
						        <input runat="server" class="mdl-textfield__input" type="number" id="myVernechMark" />
					        </div>
                        </div>
                    </div>
                    <!-- English end -->
                    <!-- Life Orientation starts -->
                    <div class="mdl-card mdl-shadow--4dp" style="margin-left:8px;margin-top:5px;margin-bottom:1px;float:left;width:270px;min-height:250px">
                        <div class="mdl-card__title mdl-color--deep-orange-400">Life Orientation</div>
                        <div class="mdl-card__supporting-text">
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="liOr">
                              <input runat="server" type="radio" id="liOr" class="mdl-radio__button" name="myLO" value="0"  />
                              <span class="mdl-radio__label">Life Orientation</span>
                            </label><br /><br /><br /><br />
                            
                            <div class="mdl-textfield mdl-js-textfield">
						        <label class="mdl-textfield__label">Percentage Obtained</label>
						        <input runat="server" class="mdl-textfield__input" type="number" id="myLOMark" />
					        </div>
                        </div>
                    </div>
                    <!-- Life Orientation end -->
                    <!-- Optional 1 starts -->
                    <div class="mdl-card mdl-shadow--4dp" style="margin-left:8px;margin-top:5px;margin-bottom:1px;float:left;width:270px;min-height:250px">
                        <div class="mdl-card__title mdl-color--deep-orange-500">Optional Subject 1</div>
                        <div class="mdl-card__supporting-text">
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="accounting">
                              <input runat="server" type="radio" id="accounting" class="mdl-radio__button" name="myOp1" value="0"  />
                              <span class="mdl-radio__label">Accounting</span>
                            </label><br />
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="physical">
                              <input runat="server" type="radio" id="physical" class="mdl-radio__button" name="myOp1" value="1" />
                              <span class="mdl-radio__label">Physical Sciences</span>
                            </label><br />
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="history">
                              <input runat="server" type="radio" id="history" class="mdl-radio__button" name="myOp1" value="2" />
                              <span class="mdl-radio__label">History</span>
                            </label>
                            <div class="mdl-textfield mdl-js-textfield">
						        <label class="mdl-textfield__label">Percentage Obtained</label>
						        <input runat="server" class="mdl-textfield__input" type="number" id="myOptional1" />
					        </div>
                        </div>
                    </div>
                    <!-- Optional 1 end -->
                    <!-- Optional 2 starts -->
                    <div class="mdl-card mdl-shadow--4dp" style="margin-left:8px;margin-top:5px;margin-bottom:1px;float:left;width:270px;min-height:250px">
                        <div class="mdl-card__title mdl-color--deep-orange-600">Optional Subject 2</div>
                        <div class="mdl-card__supporting-text">
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="business">
                              <input runat="server" type="radio" id="business" class="mdl-radio__button" name="myOp2" value="0" />
                              <span class="mdl-radio__label">Business Studies</span>
                            </label><br />
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="lifesciences">
                              <input runat="server" type="radio" id="lifesciences" class="mdl-radio__button" name="myOp2" value="1" />
                              <span class="mdl-radio__label">Life Sciences</span>
                            </label><br />
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="tourism">
                              <input runat="server" type="radio" id="tourism" class="mdl-radio__button" name="myOp2" value="2" />
                              <span class="mdl-radio__label">Tourism</span>
                            </label>
                            <div class="mdl-textfield mdl-js-textfield">
						        <label class="mdl-textfield__label">Percentage Obtained</label>
						        <input runat="server" class="mdl-textfield__input" type="number" id="myOptional2" />
					        </div>
                        </div>
                    </div>
                    <!-- Optional 2 end -->
                    <!-- Optional 3 starts -->
                    <div class="mdl-card mdl-shadow--4dp" style="margin-left:8px;margin-top:5px;margin-bottom:1px;float:left;width:270px;min-height:250px">
                        <div class="mdl-card__title mdl-color--deep-orange-600">Optional Subject 2</div>
                        <div class="mdl-card__supporting-text">
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="business">
                              <input runat="server" type="radio" id="geo" class="mdl-radio__button" name="myOp2" value="0" />
                              <span class="mdl-radio__label">Geography</span>
                            </label><br />
                            <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="lifesciences">
                              <input runat="server" type="radio" id="ecos" class="mdl-radio__button" name="myOp2" value="1" />
                              <span class="mdl-radio__label">Economics</span>
                            </label><br />
                            <div class="mdl-textfield mdl-js-textfield">
						        <label class="mdl-textfield__label">Percentage Obtained</label>
						        <input runat="server" class="mdl-textfield__input" type="number" id="myOptional3" />
					        </div>
                        </div>
                    </div>
                    <!-- Optional 3 end -->
				</div>
                <div class="mdl-card__actions">
				    <button onclick="storeMyMarksTemp()" runat="server" onserverclick="Unnamed_ServerClick" class="mdl-button mdl-button--accent mdl-js-button mdl-js-ripple-effect mdl-button--raised">Calculate aps</button>
                </div>

			</div>
			<br />
			<footer class="mdl-mini-footer">
				<div class="mdl-mini-footer__left-section">
					<div class="mdl-logo">Social Connect</div>
					<ul class="mdl-mini-footer--link-list">
						<li><a href="http://www.facebook.com/ourpage">Facebook</a></li>
						<li><a href="http://www.twitter.com/ourpage">Twitter</a></li>
						<li><a href="http://www.googleplus.com/ourpage">Google+</a></li>
					</ul>
				</div>

				<div class="mdl-mini-footer--right-section">
					<div class="mdl-logo">Administration</div>
					<ul class="mdl-mini-footer--link-list">
						<li><a href="detailspages/privacystatement.aspx">Privacy Statement</a></li>
						<li><a href="detailspages/contactus.aspx">Contact Us</a></li>
						<li><a href="detailspages/aboutus.aspx">About Us</a></li>
					</ul>
				</div>
			</footer>
		</main>
	</div>

    </form>
</body>

   
	
</html>
