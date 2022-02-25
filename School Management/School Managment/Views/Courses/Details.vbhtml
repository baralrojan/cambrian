@ModelType School_Managment.Course
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.CourseId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
