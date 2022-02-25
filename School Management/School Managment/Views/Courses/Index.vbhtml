@ModelType IEnumerable(Of School_Managment.Course)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Title_)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Credit_)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Title_)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Credit_)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.CourseId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.CourseId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.CourseId })
        </td>
    </tr>
Next

</table>
