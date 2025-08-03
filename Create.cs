@model MVC_project__curd_.Models.hotel

@{
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>Create</h2>

@using (Html.BeginForm()) 
{
    @Html.AntiForgeryToken()
    
<div class="form-horizontal">
    <h4>hotel</h4>
    <hr />
    @Html.ValidationSummary(true, "", new { @class = "text-danger" })
    <div class="form-group">
        @Html.LabelFor(model => model.username, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(model => model.username, new { htmlAttributes = new { @class = "form-control" } })
            @Html.ValidationMessageFor(model => model.username, "", new { @class = "text-danger" })
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(model => model.Roomtype, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            <div class="radio">
                @Html.RadioButtonFor(model => model.Roomtype, "Deluxe")
                @Html.LabelFor(model => model.Roomtype, "Deluxe", new { @class = "control-label" })
            </div>
            <div class="radio">
                @Html.RadioButtonFor(model => model.Roomtype, "Luxury")
                @Html.LabelFor(model => model.Roomtype, "Luxury", new { @class = "control-label" })
            </div>
            @Html.ValidationMessageFor(model => model.Roomtype, "", new { @class = "text-danger" })
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(model => model.Amenities, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @foreach (var item in TempData["values"] as List<MVC_project__curd_.Models.hotel>)
            {
                <div>
                    @Html.CheckBox("Amenities_" + item.Amenities)
                    @Html.Label("Amenities_" + item.Amenities, item.Amenities)
                </div>
            }
        </div>
    </div>




    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Create" class="btn btn-default" />
        </div>
    </div>
</div>
}

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
