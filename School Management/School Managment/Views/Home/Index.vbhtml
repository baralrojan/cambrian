@Code
    ViewData("Title") = "Home Page"
End Code

<div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
    <!-- Indicators -->
    <ol class="carousel-indicators">
        <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
        <li data-target="#carousel-example-generic" data-slide-to="1"></li>
        <li data-target="#carousel-example-generic" data-slide-to="2"></li>
    </ol>

    <!-- Wrapper for slides -->
    <div class="carousel-inner" role="listbox">
        <div class="item active">
            <img src="~/Content/Images/Slide1.png" alt="We Learn">
            <div class="carousel-caption">
                <span> We Learn !!</span>
                ...
            </div>
        </div>
        <div class="item">
            <img src="~/Content/Images/Slide2.jpg" alt="Never Stop Learning">
            <div class="carousel-caption">
                <span> Never Stop learn</span>
            </div>
        </div>
        <div class="item">
            <img src="~/Content/Images/school.jpg" alt="Come and Study with us">
            <div class="carousel-caption">
                <span> Come to us </span>
            </div>
        </div>
        ...
    </div>

    <!-- Controls -->
    <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
    </a>
</div>

<div class="row">
    <div class="col-md-6">
        <h2>Courses</h2>
        <p>
           Uses this option to veiw all the courses offering from the College.
        </p>
        <p>@Html.ActionLink("Learn More", "Index", "Courses", New With {.Class = "btn btn-primary"})</p>
    </div>
    <div class="col-md-6">
        <h2>Students</h2>
        <p> View all the students that are enrolled in the college.</p>
        <p>@Html.ActionLink("All Students", "Index", "Students", New With {.Class = "btn btn-info"})</p>
    </div>
   
</div>
