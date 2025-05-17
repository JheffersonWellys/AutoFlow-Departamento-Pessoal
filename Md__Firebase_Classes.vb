Imports Firebase.Database

Module Md__Firebase_Classes

    Public Class Usuario

        Public Property Id As Integer
        Public Property Chapa As String
        Public Property Email As String
        Public Property NomeCompleto As String
        Public Property Token As String

    End Class

    Public Class FirebaseHelper

        Private Shared _firebaseClient As FirebaseClient

        Public Shared ReadOnly Property FirebaseClient As FirebaseClient

            Get
                If _firebaseClient Is Nothing Then

                    _firebaseClient = New FirebaseClient(Firebase__DatabaseURL)

                End If

                Return _firebaseClient

            End Get

        End Property

    End Class

    Public Class FirebaseAuthResponse

        Public Property idToken As String
        Public Property email As String
        Public Property refreshToken As String
        Public Property expiresIn As String
        Public Property localId As String

    End Class

    Public Class AuthResult

        Public Property IdToken As String
        Public Property LocalId As String

    End Class

End Module
