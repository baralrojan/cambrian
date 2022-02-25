@ModelType School_Managment.Course
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3 class="alret alert-danger">Are you sure you want to delete this?</h3>
<div>
    <h4>Course</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Title_)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Title_)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Credit_)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Credit_)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-danger" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
