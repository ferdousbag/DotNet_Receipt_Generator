Public Class Form1
    Dim t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, totalammount As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Generating Date and Memo
        TxtDate.Text = Now.ToLongDateString
        Txtmemo.Text = Today.Year & Today.Month & Today.Day & "-" & Now.Hour & Now.Minute & Now.Second & "-" & Int(1 + Rnd() * 9)
        t1 = 0
        t2 = 0
        t3 = 0
        t4 = 0
        t5 = 0
        t6 = 0
        t7 = 0
        t8 = 0
        t9 = 0
        t10 = 0
        totalammount = 0

    End Sub


    'exit button
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    'Control user not to have any empty field when generation receipt

    Private Sub TxtCustomerName_Leave(sender As Object, e As EventArgs) Handles TxtCustomerName.Leave
        If TxtCustomerName.Text = "" Then
            TxtCustomerName.BackColor = Color.Red
        End If
    End Sub

    Private Sub item10_TextChanged(sender As Object, e As EventArgs) Handles item10.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtMobile_Leave(sender As Object, e As EventArgs) Handles TxtMobile.Leave
        If TxtMobile.Text = "" Then
            TxtMobile.BackColor = Color.Red
        End If
    End Sub


    'Handles print option 
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        BtnClear.Visible = False
        BtnExit.Visible = False
        BtnPrint.Visible = False
        Dim bit As New Bitmap(Me.Width, Me.Height)
        Dim rct As New Rectangle(New Point(0, 0), Me.Size)
        Me.DrawToBitmap(bit, rct)
        e.Graphics.DrawImage(bit, New Point(0, 0))
    End Sub
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintDocument1.Print()
    End Sub
    Private Sub BtnPrint_LostFocus(sender As Object, e As EventArgs) Handles BtnPrint.LostFocus
        BtnClear.Visible = True
        BtnExit.Visible = True
        BtnPrint.Visible = True
    End Sub
    'Print opthion ended. 


    Private Sub TxtAddress_Leave(sender As Object, e As EventArgs) Handles TxtAddress.Leave
        If TxtAddress.Text = "" Then TxtAddress.BackColor = Color.Red
    End Sub
    Private Sub TxtCustomerName_GotFocus(sender As Object, e As EventArgs) Handles TxtCustomerName.GotFocus
        TxtCustomerName.BackColor = Color.Khaki
    End Sub
    Private Sub TxtAddress_GotFocus(sender As Object, e As EventArgs) Handles TxtAddress.GotFocus
        TxtAddress.BackColor = Color.Khaki
    End Sub

    Private Sub TxtMobile_GotFocus(sender As Object, e As EventArgs) Handles TxtMobile.GotFocus
        TxtMobile.BackColor = Color.Khaki
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try : If price1.Text <> "" And no1.Text <> "" Then
                total1.Text = price1.Text * Int(no1.Text)
            End If
            If price2.Text <> "" And no2.Text <> "" Then
                total2.Text = price2.Text * Int(no2.Text)
            End If
            If price3.Text <> "" And no3.Text <> "" Then
                total3.Text = price3.Text * Int(no3.Text)
            End If
            If price4.Text <> "" And no4.Text <> "" Then
                total4.Text = price4.Text * Int(no4.Text)
            End If
            If price5.Text <> "" And no5.Text <> "" Then
                total5.Text = price5.Text * Int(no5.Text)
            End If
            If price6.Text <> "" And no6.Text <> "" Then
                total6.Text = price6.Text * Int(no6.Text)
            End If
            If price7.Text <> "" And no7.Text <> "" Then
                total7.Text = price7.Text * Int(no7.Text)
            End If
            If price8.Text <> "" And no8.Text <> "" Then
                total8.Text = price8.Text * Int(no8.Text)
            End If
            If price9.Text <> "" And no9.Text <> "" Then
                total9.Text = price9.Text * Int(no9.Text)
            End If
            If price10.Text <> "" And no10.Text <> "" Then
                total10.Text = price10.Text * Int(no10.Text)
            End If

        Catch ex As Exception
        End Try
        Try
            If total1.Text <> "" Then t1 = total1.Text
            If total2.Text <> "" Then t2 = total2.Text
            If total3.Text <> "" Then t3 = total3.Text
            If total4.Text <> "" Then t4 = total4.Text
            If total5.Text <> "" Then t5 = total5.Text
            If total6.Text <> "" Then t6 = total6.Text
            If total7.Text <> "" Then t7 = total7.Text
            If total8.Text <> "" Then t8 = total8.Text
            If total9.Text <> "" Then t9 = total9.Text
            If total10.Text <> "" Then t10 = total10.Text
            txttotal.Text = (t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10)
            Dim totala As Double
            totala = txttotal.Text
            Dim commission As Double
            If txtcom.Text = "" Then
                txtcom.Text = 0
                commission = 0
            Else
                commission = txtcom.Text
            End If

            txtendtotal.Text = totala - commission

        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtAddress.Clear()
        TxtCustomerName.Clear()
        'Generating Date and Memo
        TxtDate.Text = Now.ToLongDateString
        Txtmemo.Text = Today.Year & Today.Month & Today.Day & "-" & Now.Hour & Now.Minute & Now.Second & "-" & Int(1 + Rnd() * 9)

        TxtMobile.Clear()
        item1.Clear()
        item10.Clear()
        item2.Clear()
        item3.Clear()
        item4.Clear()
        item6.Clear()
        item7.Clear()
        item8.Clear()
        item9.Clear()
        price1.Clear()
        price10.Clear()
        price2.Clear()
        price3.Clear()
        price4.Clear()
        price5.Clear()
        price6.Clear()
        price7.Clear()
        price8.Clear()
        price9.Clear()
        no1.Clear()
        no2.Clear()
        no3.Clear()
        no4.Clear()
        no5.Clear()
        no6.Clear()
        no8.Clear()
        no9.Clear()
        no10.Clear()
        total1.Clear()
        total10.Clear()
        total2.Clear()
        total3.Clear()
        total4.Clear()
        total5.Clear()
        total6.Clear()
        total7.Clear()
        total8.Clear()
        total9.Clear()
        txttotal.Clear()
        txtendtotal.Clear()
        txtcom.Clear()

        t1 = 0
        t2 = 0
        t3 = 0
        t4 = 0
        t5 = 0
        t6 = 0
        t7 = 0
        t8 = 0
        t9 = 0
        t10 = 0
        totalammount = 0

    End Sub

End Class
