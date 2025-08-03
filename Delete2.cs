@model MVC_project__curd_.Models.hotel

@{
    ViewBag.Title = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>hotel</h4>
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

    @using (Html.BeginForm()) {
        @Html.AntiForgeryToken()

        <div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    }
</div>
