Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports System.ComponentModel

Namespace ComplexDialogSample.Module.BusinessObjects

    <NavigationItem("Resources")>
    Public Class Team
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Property Name As String
            Get
                Return GetPropertyValue(Of String)("Name")
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", value)
            End Set
        End Property
    End Class

    <NavigationItem("Process")>
    <DefaultProperty("Index")>
    Public Class Office
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Property Index As String
            Get
                Return GetPropertyValue(Of String)("Index")
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Index", value)
            End Set
        End Property

        Public Property OccupiedBy As String
            Get
                Return GetPropertyValue(Of String)("OccupiedBy")
            End Get

            Set(ByVal value As String)
                SetPropertyValue("OccupiedBy", value)
            End Set
        End Property
    End Class

    <NavigationItem("Process")>
    Public Class Order
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Property Team As Team
            Get
                Return GetPropertyValue(Of Team)("Team")
            End Get

            Set(ByVal value As Team)
                SetPropertyValue("Team", value)
            End Set
        End Property

        Public Property Office As Office
            Get
                Return GetPropertyValue(Of Office)("Office")
            End Get

            Set(ByVal value As Office)
                SetPropertyValue("Office", value)
            End Set
        End Property

        Public Property Service As Service
            Get
                Return GetPropertyValue(Of Service)("Service")
            End Get

            Set(ByVal value As Service)
                SetPropertyValue("Service", value)
            End Set
        End Property

        Public Property DueDate As Date
            Get
                Return GetPropertyValue(Of Date)("DueDate")
            End Get

            Set(ByVal value As Date)
                SetPropertyValue("DueDate", value)
            End Set
        End Property
    End Class

    <NavigationItem("Resources")>
    <DefaultProperty("Description")>
    Public Class Service
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Property Description As String
            Get
                Return GetPropertyValue(Of String)("Description")
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Description", value)
            End Set
        End Property
    End Class
End Namespace
