'Dynamic Salting Proof of Concept and Demonstration
'dchow[AT]xtecsystems.com 20150615
'References:
'http://www.codeproject.com/Questions/147676/Convert-a-string-to-md
'https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx

'Grab the appropriate .NET libraries
Imports System
Imports System.Security.Cryptography
Imports System.Text

Public Class MainForm

    'Define global variables
    Dim usernameStr As String
    Dim passwordStr As String
    Dim passwordStaticSalt As String
    Dim passwordDynSalt As String
    Dim saltStr As String
    Dim accountdateStr As String
    Dim hashStr As String
    Dim saltedhashStr As String
    Dim dynsaltedhashStr As String

    'Function taken verbatim from http://stackoverflow.com/questions/23513831/hash-with-md5-in-vb-net
    Shared Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

        Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
            Application.Exit()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
            MessageBox.Show("Single example PoC of more secure Salting. dchow[AT]xtecsystems.com")
        End Sub

    Private Sub PasswordHashButton_Click(sender As Object, e As EventArgs) Handles PasswordHashButton.Click
        passwordStr = PasswordTextBox.Text
        hashStr = GetHash(passwordStr)
        ResultsRichTextBox.Text = hashStr
    End Sub

    Private Sub UserNameTextbox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextbox.TextChanged
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
    End Sub

    Private Sub AccountCreationDateTextbox_TextChanged(sender As Object, e As EventArgs) Handles AccountCreationDateTextbox.TextChanged
    End Sub

    Private Sub StaticSaltTextBox_TextChanged(sender As Object, e As EventArgs) Handles StaticSaltTextBox.TextChanged
    End Sub

    Private Sub PasswordSaltedHashButton_Click(sender As Object, e As EventArgs) Handles PasswordSaltedHashButton.Click
        'Use hashing function to create hash and display
        passwordStr = (PasswordTextBox.Text)
        hashStr = GetHash(passwordStr)
        ResultsRichTextBox.Text = hashStr

        'Add the static salt variable from box and repeat
        passwordStaticSalt = (PasswordTextBox.Text & StaticSaltTextBox.Text)
        saltedhashStr = GetHash(passwordStaticSalt)
        SaltedRichTextBox.Text = saltedhashStr

    End Sub

    Private Sub DynSaltedPasswordHashButton_Click(sender As Object, e As EventArgs) Handles DynSaltedPasswordHashButton.Click
        'Dynamic salting takes metadata info from the entire user record
        'In our simple example the salt is no longer statically assigned
        'The salt is now dynamic because it is based on items that are unique per user record
        'Password + Username + Account Creation Date + Length of Password

        Dim passLength As String
        passLength = passwordStr.Length.ToString
        passwordStr = (PasswordTextBox.Text & UserNameTextbox.Text & AccountCreationDateTextbox.Text & passLength)
        dynsaltedhashStr = GetHash(passwordStr)
        DynSaltRichTextBox.Text = dynsaltedhashStr

        'Use hashing function to create hash and display
        passwordStr = (PasswordTextBox.Text)
        hashStr = GetHash(passwordStr)
        ResultsRichTextBox.Text = hashStr

        'Add the static salt variable from box and repeat
        passwordStaticSalt = (PasswordTextBox.Text & StaticSaltTextBox.Text)
        saltedhashStr = GetHash(passwordStaticSalt)
        SaltedRichTextBox.Text = saltedhashStr

    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseToolStripMenuItem.Click
        MessageBox.Show("Change the values in the username, password, date, and salt fields." & " Click the various hashing buttons to generate MD5 hashes." & " Notice the differences between the hashes.")
    End Sub
End Class
