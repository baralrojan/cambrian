Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports School_Managment
Imports School_Managment.Data

Namespace Controllers
    Public Class StudentsController
        Inherits System.Web.Mvc.Controller

        Private db As New School_ManagmentContext

        ' GET: Students
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.Students.ToListAsync())
        End Function

        ' GET: Students/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim student As Student = Await db.Students.FindAsync(id)
            If IsNothing(student) Then
                Return HttpNotFound()
            End If
            Return View(student)
        End Function

        ' GET: Students/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Students/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="StudentID,LastName,FirstName,EnrollmentDate")> ByVal student As Student) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Students.Add(student)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(student)
        End Function

        ' GET: Students/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim student As Student = Await db.Students.FindAsync(id)
            If IsNothing(student) Then
                Return HttpNotFound()
            End If
            Return View(student)
        End Function

        ' POST: Students/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="StudentID,LastName,FirstName,EnrollmentDate")> ByVal student As Student) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(student).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(student)
        End Function

        ' GET: Students/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim student As Student = Await db.Students.FindAsync(id)
            If IsNothing(student) Then
                Return HttpNotFound()
            End If
            Return View(student)
        End Function

        ' POST: Students/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim student As Student = Await db.Students.FindAsync(id)
            db.Students.Remove(student)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
