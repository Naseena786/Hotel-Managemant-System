
@model MVC_project__curd_.Models.reg

@{
    ViewBag.Title = "Login";
}
<h2 style="color:brown">Login Page</h2>


@if (ViewBag.Message != null)
{
    <div class="alert alert-info">
        @ViewBag.Message
    </div>
}
    @using (Html.BeginForm("login", "hotel", FormMethod.Post))
    {
    <div class="form-group">
        @Html.LabelFor(model => model.username)
        @Html.TextBox("username", null, new { @class = "form-control" })
        @Html.ValidationMessage("username", "", new { @class = "text-danger" })
    </div>

    <div class="form-group">
        @Html.LabelFor(model => model.password)
        @Html.Password("password", null, new { @class = "form-control" })
        @Html.ValidationMessage("password", "", new { @class = "text-danger" })
    </div>

    <button id="centerButton" type="button" class="btn btn-primary"
            onclick="window.location.href='@Url.Action("Create", "hotel2")'"
            style="background-color: #4CAF50; color: white; padding: 10px 20px; border-radius: 5px;">
        Login
    </button>
  

}
