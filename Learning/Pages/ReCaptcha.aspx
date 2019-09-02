<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReCaptcha.aspx.cs" Inherits="Learning.Pages.ReCaptcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ReCaptCha</h1>
        </div>
        <script src="https://www.google.com/recaptcha/api.js?render=reCAPTCHA_site_key"></script>
        <script>
            grecaptcha.ready(function () {
                grecaptcha.execute('6Lcxb6kUAAAAACDJiUL8LVriCArsVJwmFmUK-917', { action: 'homepage' }).then(function (token) {
                });
            });
        </script>
    </form>
</body>
</html>
