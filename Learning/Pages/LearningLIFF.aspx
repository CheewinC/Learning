<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LearningLIFF.aspx.cs" Inherits="Learning.Pages.LearningLIFF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>LIFF Starter</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        Mobile:<asp:TextBox ID="txtMobileNo" runat="server" TextMode="Phone"></asp:TextBox>
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        
        <hr />
        browserLanguage :<h1><asp:Label ID="lblBrowserLanguage" runat="server"></asp:Label></h1>
        sdkVersion :<h1><asp:Label ID="lblSdkVersion" runat="server"></asp:Label></h1>
        isInClient :<h1><asp:Label ID="lblIsInClient" runat="server"></asp:Label></h1>
        isLoggedIn :<h1><asp:Label ID="lblIsLoggedIn" runat="server"></asp:Label></h1>
        deviceOS :<h1><asp:Label ID="lblDeviceOS" runat="server"></asp:Label></h1>
        <hr />
        userIdProfileField :<h1><asp:Label ID="lblUserIdProfileField" runat="server"></asp:Label></h1>
        displayNameField :<h1><asp:Label ID="lblDisplayNameField" runat="server"></asp:Label></h1>
        profilePictureDiv :<h1><asp:Label ID="lblProfilePictureDiv" runat="server"></asp:Label></h1>
        statusMessageField :<h1><asp:Label ID="lblStatusMessageField" runat="server"></asp:Label></h1>
        <asp:HiddenField ID="hdnUserIdProfileField" runat="server" />
        <asp:HiddenField ID="hdnDisplayNameField" runat="server" />
        <asp:HiddenField ID="hdnProfilePictureDiv" runat="server" />
        <asp:HiddenField ID="hdnStatusMessageField" runat="server" />
        <script src="https://res.wx.qq.com/mmbizwap/zh_CN/htmledition/js/vconsole/3.0.0/vconsole.min.js"></script>
        <script>var vConsole = new VConsole();</script>
        <script src="../Scripts/jquery-3.4.1.min.js"></script>
        <script src="https://static.line-scdn.net/liff/edge/2.1/sdk.js"></script>
        <script>
            window.onload = function (e) {
                console.log('onload');
                initializeLiff();
            }

            function initializeLiff() {
                console.log('initializeLiff');
                liff
                    .init({
                        liffId: "1614834775-a0mOA8vd"
                    })
                    .then(() => {
                        console.log('liff start');
                        //// start to use LIFF's api
                        //initializeApp();
                        displayLiffData();
                        getProfile();
                    })
                    .catch((err) => {
                        //document.getElementById("liffAppContent").classList.add('hidden');
                        //document.getElementById("liffInitErrorMessage").classList.remove('hidden');
                    });
            }

            function displayLiffData() {
                document.getElementById('<%=lblBrowserLanguage.ClientID %>').innerHTML = liff.getLanguage();
                document.getElementById('<%=lblSdkVersion.ClientID %>').innerHTML = liff.getVersion();
                document.getElementById('<%=lblIsInClient.ClientID %>').innerHTML = liff.isInClient();
                document.getElementById('<%=lblIsLoggedIn.ClientID %>').innerHTML = liff.isLoggedIn();
                document.getElementById('<%=lblDeviceOS.ClientID %>').innerHTML = liff.getOS();
            }

            function getProfile() {
                liff.getProfile().then(function (profile) {
                    document.getElementById('<%=hdnUserIdProfileField.ClientID %>').value = profile.userId;
                    document.getElementById('<%=hdnDisplayNameField.ClientID %>').value = profile.displayName;
                    document.getElementById('<%=hdnProfilePictureDiv.ClientID %>').value = profile.pictureUrl;
                    document.getElementById('<%=hdnStatusMessageField.ClientID %>').value = profile.statusMessage;

                    document.getElementById('<%=lblUserIdProfileField.ClientID %>').innerHTML = profile.userId;
                    document.getElementById('<%=lblDisplayNameField.ClientID %>').innerHTML = profile.displayName;

                    const profilePictureDiv = document.getElementById('<%=lblProfilePictureDiv.ClientID %>');
                    if (profilePictureDiv.firstElementChild) {
                        profilePictureDiv.removeChild(profilePictureDiv.firstElementChild);
                    }
                    const img = document.createElement('img');
                    img.src = profile.pictureUrl;
                    img.alt = 'Profile Picture';
                    img.height = 200;
                    img.width = 200;
                    profilePictureDiv.appendChild(img);

                    document.getElementById('<%=lblStatusMessageField.ClientID %>').innerHTML = profile.statusMessage;
                }).catch(function (error) {
                    window.alert('Error getting profile: ' + error);
                });
            }

        </script>
    </form>
</body>
</html>
