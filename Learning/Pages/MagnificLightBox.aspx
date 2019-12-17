<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MagnificLightBox.aspx.cs" Inherits="Learning.Pages.MagnificLightBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/magnific-popup.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/jquery.magnific-popup.js"></script>
    <style>

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="parent-container">
                <a href="../images/InformationTPA.png">Open popup 1</a>
                <a href="../images/BgHome.jpg">Open popup 2</a>
                <a href="../images/AgentDefault.jpg">Open popup 3</a>
            </div>
            <div class="zoom-gallery">
                <!-- Width/height ratio of thumbnail and the main image must match to avoid glitches.

	If ratios are different, you may add CSS3 opacity transition to the main image to make the change less noticable.

	 -->
                <a href="../images/BgHome.jpg" data-source="http://500px.com/photo/32736307" title="Into The Blue" style="width: 200px; height: 200px;">
                    <img src="../images/BgHome.jpg" width="200" height="200">
                </a>
                <a href="../images/InformationTPA.png" title="Light Sabre" style="width: 200px; height: 200px;">
                    <img src="../images/InformationTPA.png" width="200" height="200">
                </a>
            </div>
        </div>
        <script>
            $(document).ready(function () {
                $('.zoom-gallery').magnificPopup({
                    delegate: 'a',
                    type: 'image',
                    closeOnContentClick: false,
                    closeBtnInside: false,
                    mainClass: 'mfp-with-zoom mfp-img-mobile',
                    image: {
                        verticalFit: true,
                        //titleSrc: function (item) {
                        //    return item.el.attr('title') + ' &middot; <a class="image-source-link" href="' + item.el.attr('data-source') + '" target="_blank">image source</a>';
                        //}
                    },
                    gallery: {
                        enabled: true
                    },
                    zoom: {
                        enabled: true,
                        duration: 300, // don't foget to change the duration also in CSS
                        opener: function (element) {
                            return element.find('img');
                        }
                    }
                });
            });
        </script>
    </form>
</body>
</html>
