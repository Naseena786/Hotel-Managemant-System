
@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
  
</head>
<body>
    <div>
        <p style="text-align:center; font-style:revert-layer; font-size:large; color: palevioletred;">Registration Successful!!</p>
        <p>
            <button id="centerButton" type="button" class="btn btn-primary"
                    onclick="window.location.href='@Url.Action("login", "hotel")'"
                    style="background-color: #4CAF50; color: white; padding: 10px 20px; border-radius: 5px;">
                Click
            </button>
        </p>

        <script>
            function centerButton() {
                var button = document.getElementById('centerButton');

                var buttonWidth = button.offsetWidth;
                var buttonHeight = button.offsetHeight;

                var windowWidth = window.innerWidth;
                var windowHeight = window.innerHeight;

                var leftPosition = (windowWidth - buttonWidth) / 2;
                var topPosition = (windowHeight - buttonHeight) / 2;

                button.style.position = 'absolute';
                button.style.left = leftPosition + 'px';
                button.style.top = topPosition + 'px';
            }

            window.onload = centerButton;
            window.onresize = centerButton;
        </script>
    </div>
</body>
</html>




























