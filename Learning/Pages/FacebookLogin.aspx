<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacebookLogin.aspx.cs" Inherits="Learning.Pages.FacebookLogin" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>


<body>
    <form id="form1" runat="server">
        <script src="../Scripts/jquery-3.0.0.slim.min.js"></script>
        <script src="../Scripts/popper.min.js"></script>
        <script>
            (function (d, s, id) {
                var js, fjs = d.getElementsByTagName(s)[0];
                if (d.getElementById(id)) { return; }
                js = d.createElement(s); js.id = id;
                js.src = "https://connect.facebook.net/en_US/sdk.js";
                fjs.parentNode.insertBefore(js, fjs);
            }(document, 'script', 'facebook-jssdk'));
        </script>

        <fb:login-button
            scope="public_profile,email"
            onlogin="checkLoginState();">
        </fb:login-button>

       <div class="fb-login-button" data-width="" data-size="medium" data-button-type="login_with" data-auto-logout-link="true" data-use-continue-as="false" onlogin="checkLoginState();"></div>
    </form>
</body>

<script>
    window.fbAsyncInit = function () {
        FB.init({
            appId: '404646623593444',
            cookie: true,
            xfbml: true,
            version: 'v4.0'
        });

        FB.AppEvents.logPageView();

    };

    function checkLoginState() {
        FB.getLoginStatus(function (response) {
            statusChangeCallback(response);
        });
    }

    function statusChangeCallback(response) {
        alert(response.status);
    }
</script>

</html>
