Imports Microsoft.Win32
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics.Contracts
Imports System.Drawing
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace My
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private registro As Contacto()
        Private i As Integer = 0

        Private Sub btnRegistro_ClicK(ByVal sender As Object, ByVal e As EventArgs)
            If i < registro.Length Then
                Dim x As Contacto = New Contacto()
                x.NombreP = tbNombre.Text
                x.FechaNacimientoP = DateTime.Parse(tbfecha.Text)
                x.TelefonoP = tbTelefono.Text
                registro(i) = x
                listaContactos.Items.Add(x.ToString())
                i += 1
            End If
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs)
            registro = New Contacto(Integer.Parse(tbCantidad.Text) - 1) {}
        End Sub

        Private Sub btnajksdna_Click(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
