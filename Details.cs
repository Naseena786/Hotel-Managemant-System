@model MVC_project__curd_.Models.reg

@{
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>Details</h2>

<div>
    <h4>reg</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(model => model.Firstname)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Firstname)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Lastname)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Lastname)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.username)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.username)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.gender)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.gender)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.password)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.password)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Confirmpassword)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Confirmpassword)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Email)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.phone)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.phone)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Address)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Address)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Age)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Age)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Langknown)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Langknown)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Country)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Country)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", new { id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
