@model IEnumerable<MVC_project__curd_.Models.hotel>

@{
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(model => model.username)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Roomtype)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Amenities)
        </th>
        <th></th>
    </tr>

@foreach (var item in Model) {
    <tr>
        <td>
            @Html.DisplayFor(modelItem => item.username)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.Roomtype)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.Amenities)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", new { id=item.id }) |
            @Html.ActionLink("Details", "Details", new { id=item.id}) |
            @Html.ActionLink("Delete", "Delete", new {  id=item.id})
        </td>
    </tr>
}

</table>
