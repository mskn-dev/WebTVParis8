Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Services

Public Class Utilisateurs
    Public Property IdUser As Integer
    Public Property Nom As String
    Public Property Prenom As String
    Public Property Email As String
    Public Property Password As String
    Public Property IdRole As Integer = 2

    Public Sub New()

    End Sub

    Public Sub New(User As Utilisateurs)
        Me.Prenom = User.Prenom
        Me.Nom = User.Nom
        Me.Email = User.Email
        Me.Password = User.Password
        Me.IdRole = User.IdRole
    End Sub

    Public Function CreateUser() As Boolean
        Dim sql As New SqlCommand
        sql.CommandText = "sp_create_user"
        sql.CommandType = CommandType.StoredProcedure
        sql.Connection = New SqlConnection(ConfigurationManager.ConnectionStrings("WebTVParis8").ConnectionString)
        sql.Parameters.AddWithValue("PRENOM", Me.Prenom)
        sql.Parameters.AddWithValue("NOM", Me.Nom)
        sql.Parameters.AddWithValue("EMAIL", Me.Email)
        sql.Parameters.AddWithValue("PASSWORD", Me.Password)
        sql.Parameters.AddWithValue("ID_ROLE", Me.IdRole)
        sql.Connection.Open()
        Dim reader As SqlDataReader = sql.ExecuteReader
        If reader.Read Then
            Me.IdUser = IIf(reader("ID_USER") IsNot DBNull.Value, reader("ID_USER"), 0)
        End If
        If Me.IdUser <> 0 Then
            Return True
        Else
            Return False
        End If
        sql.Connection.Close()
    End Function

    Public Shared Function GetUsersByCriteres(Optional IdUser As Integer = Nothing, Optional Prenom As String = Nothing, Optional Nom As String = Nothing, Optional Email As String = Nothing) As Utilisateurs()
        Dim Users As List(Of Utilisateurs) = New List(Of Utilisateurs)

        Dim sql As New SqlCommand
        sql.CommandText = "sp_select_user_by_criteres"
        sql.CommandType = CommandType.StoredProcedure
        sql.Connection = New SqlConnection(ConfigurationManager.ConnectionStrings("WebTVParis8").ConnectionString)
        sql.Parameters.AddWithValue("ID_USER", IdUser)
        sql.Parameters.AddWithValue("PRENOM", Prenom)
        sql.Parameters.AddWithValue("NOM", Nom)
        sql.Parameters.AddWithValue("EMAIL", Email)
        sql.Connection.Open()
        Dim reader As SqlDataReader = sql.ExecuteReader()
        While reader.Read
            Users.Add(Utilisateurs.GetDataByRow(reader))
        End While
        Return Users.ToArray
    End Function

    Private Shared Function GetDataByRow(ligne As SqlDataReader) As Utilisateurs
        Dim User As Utilisateurs = New Utilisateurs()
        User.IdUser = ligne("USER_ID")
        User.IdRole = ligne("ID_ROLE")
        User.Prenom = ligne("PRENOM")
        User.Nom = ligne("NOM")
        User.Email = ligne("EMAIL")
        User.Password = ligne("PASWORD")
        Return User
    End Function

    Public Function GetUserByID(IdUser As Integer) As Utilisateurs
        Return Utilisateurs.GetUsersByCriteres(IdUser)(0)
    End Function

End Class

' Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante.
<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class UtilisateursWebService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function CreateUser(User As Utilisateurs) As Boolean
        Return New Utilisateurs(User).CreateUser()
    End Function

    <WebMethod()> _
    Public Function GetUsersByCriteres(IdUser As Integer?, Prenom As String, Nom As String, Email As String) As Utilisateurs()
        Return Utilisateurs.GetUsersByCriteres(IdUser, Prenom, Nom, Email)
    End Function
End Class