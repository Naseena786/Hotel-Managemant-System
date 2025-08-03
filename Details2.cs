@model MVC_project__curd_.Models.hotel

@{
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>Details</h2>

<div>
    <h4>hotel registration</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(model => model.username)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.username)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Roomtype)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Roomtype)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Amenities)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Amenities)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", new { id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
