Public Class Form1
    'Global Declarations
    Dim Width1, Height1, Depth1 As Decimal
    Const Litres As Integer = 1000
    Private Sub BTNCalcVolumne_Click(sender As Object, e As EventArgs) Handles BTNCalcVolumne.Click
        'Local Declarations
        Dim Volumne As Decimal

        'Store User Input
        Width1 = TBWidth.Text
        Height1 = TBHeight.Text
        Depth1 = TBDepth.Text

        'Calculate The Valumne Of The Aquarium
        Volumne = Width1 * Height1 * Depth1 / Litres

        'Output The Volumne To The Textbox
        TBVolumne.Text = Volumne
    End Sub
End Class
