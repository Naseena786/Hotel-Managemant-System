@model IEnumerable<MVC_project__curd_.Models.reg>

@{
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2 style="color:brown">Registration Details</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(model => model.Firstname)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Lastname)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.username)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.gender)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.password)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Confirmpassword)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Email)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.phone)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Address)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Age)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Langknown)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Country)
        </th>
        <th></th>
    </tr>

    @foreach (var item in Model)
    {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.Firstname)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Lastname)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.username)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.gender)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.password)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Confirmpassword)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Email)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.phone)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Address)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Age)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Langknown)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Country)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", new { id = item.id }) |
                @Html.ActionLink("Details", "Details", new { id = item.id }) |
                @Html.ActionLink("Delete", "Delete", new { id = item.id })
            </td>
        </tr>
    }

</table>
<button id="centerButton" type="button" class="btn btn-primary"
        onclick="window.location.href='@Url.Action("login", "hotel")'"
        style="background-color: #4CAF50; color: white; padding: 10px 20px; border-radius: 5px;">
    Login 
</button>