<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
		Register
	</title>
	<link rel="stylesheet" href="https://storage.googleapis.com/code.getmdl.io/1.0.5/material.indigo-pink.min.css" />
	<script src="dataStore.js"></script>
	<script src="https://storage.googleapis.com/code.getmdl.io/1.0.5/material.min.js"></script>
	<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />

	<style>
		.svg-ic_menu_24px-dims {
			width: 24px;
			height: 24px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="myDatas" class="mdl-layout mdl-js-layout mdl-layout--fixed-header" style="width:inherit">
		<header class="mdl-layout__header">
			<div class="mdl-layout__header-row">
				<span class="mdl-layout-title">APS System</span>
				<div class="mdl-layout-spacer"></div>
			</div>
		</header>
		<div class="mdl-layout__drawer">
			<span class="mdl-layout-title">Links</span>
			<nav class="mdl-navigation">
				<a class="mdl-navigation__link" href="home.aspx">Home</a>
				<a class="mdl-navigation__link" href="login.aspx">Sign In</a>
				<a class="mdl-navigation__link mdl-color--deep-orange" href="registration.aspx">Registration</a>
				<a class="mdl-navigation__link linkColor" href="myAPS.aspx">My APS</a>
			</nav>
		</div>
		<main class="mdl-layout__content">
			<div style="margin-left:25%;margin-top:2%;" class="mdl-card mdl-shadow--6dp">
				<div class="mdl-card__title" style="color:white;background-color:#ff4081;">
					<h3 class="mdl-card__title-text">Registration Details</h3></div>
				<div class="mdl-card__supporting-text">
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">First Names</label>
						<input class="mdl-textfield__input" type="text" id="myName" runat="server"/>
                        
					</div>
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Last Name</label>
						<input class="mdl-textfield__input" type="text" id="surname" runat="server"/>
					</div>
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">ID Number</label>
						<input class="mdl-textfield__input" type="number" id="idNumber" runat="server" />
					</div>
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Address line 1</label>
						<input class="mdl-textfield__input" type="text" id="addressLine1" runat="server"/>
					</div>
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Address line 2</label>
						<input class="mdl-textfield__input" type="text" id="addressLine2" runat="server"/>
					</div>
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Postal Code</label>
						<input class="mdl-textfield__input" type="number" id="postalCode" runat="server"/>
					</div>
					
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Email address</label>
						<input class="mdl-textfield__input" type="email" id="usrEmailAdd" runat="server"/>
					</div>
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Password</label>
						<input class="mdl-textfield__input" type="password" id="pswd1" runat="server"/>
					</div>
                    <div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Repeat Password</label>
						<input class="mdl-textfield__input" type="password" id="Password1" runat="server"/>
					</div>
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Cellphone number</label>
						<input class="mdl-textfield__input" type="text" id="cellnum" runat="server"/>
					</div>
				</div>

                <label id="showScript" runat="server" />

				<div class="mdl-card__actions">
					<button runat="server" onserverclick="saveDatas_ServerClick" id="saveDatas" class="mdl-button mdl-button--accent mdl-js-button mdl-js-ripple-effect mdl-button--raised" style="margin-left:25%;width:60%">Register</button>

				</div>
			</div>
			<br />
			<footer class="mdl-mini-footer">
				<div class="mdl-mini-footer__left-section">
					<div class="mdl-logo">Social Connect</div>
					<ul class="mdl-mini-footer--link-list">
						<li><a href="www.facebook.com/ourpage">Facebook</a></li>
						<li><a href="www.twitter.com/ourpage">Twitter</a></li>
						<li><a href="www.googleplus.com/ourpage">Google+</a></li>
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
