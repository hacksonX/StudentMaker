<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
		Sign In
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
			<div runat="server" style="margin-left:25%;margin-top:2%;" class="mdl-card mdl-shadow--8dp">
				<div class="mdl-card__title" style="color:white;background-color:#ff4081;">
					<h3 id="usrnamed" class="mdl-card__title-text">Sign In Details</h3></div>
				<div class="mdl-card__supporting-text">
                    <div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Email or Phone number</label>
						<input class="mdl-textfield__input" type="text" id="myUsername" runat="server"/>
                    </div>
					<div class="mdl-textfield mdl-js-textfield">
						<label class="mdl-textfield__label">Password</label>
						<input class="mdl-textfield__input" type="password" id="myPswd" runat="server"/>
					</div>
                 </div>
                <div class="mdl-card__actions">
					<button onserverclick="signMeIn_ServerClick" runat="server" id="signMeIn" class="mdl-button mdl-button--accent mdl-js-button mdl-js-ripple-effect mdl-button--raised mdl-shadow--2dp" style="margin-left:25%;width:60%">Sign In</button>
                </div>
                </div>
         </main>
      </div>
        <div runat="server" id="mySignInData">
            
        </div>
    </form>
</body>
</html>
