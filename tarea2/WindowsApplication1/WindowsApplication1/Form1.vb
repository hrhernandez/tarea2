

Public Class Form1

    Const parroz As Double = 2.0
    Const pfrijol As Double = 1.75
    Const pazucar As Double = 2.5
    Const iva As Double = 0.12
    Const des As Double = 0.025

    Dim subt As Double
    Dim piva As Double
    Dim pagop As Double
    Dim d As Double
    Dim totalt As Double

    Private Sub txtarroz_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtarroz.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "AVISO") = vbYes Then
            End
        End If
    End Sub


    Private Sub txtfrijol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfrijol.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtazucar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtazucar.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtarroz.Clear()
        txtfrijol.Clear()
        txtazucar.Clear()
        txtsub.Clear()
        txtiva.Clear()
        txtparcial.Clear()
        txtdesc.Clear()
        txttotal.Clear()
    End Sub



    Private Sub txtsub_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsub.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        subt = (Val(txtarroz.Text) * parroz) + (Val(txtfrijol.Text) * pfrijol) + (Val(txtazucar.Text) * pazucar)
        piva = subt * iva
        pagop = subt + iva
        d = pagop * des
        totalt = pagop - d

        txtsub.Text = subt
        txtiva.Text = piva
        txtparcial.Text = pagop
        txtdesc.Text = d
        txttotal.Text = totalt

    End Sub
End Class