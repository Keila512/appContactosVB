Namespace My
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.tbNombre = New System.Windows.Forms.TextBox()
            Me.btnRegistro = New System.Windows.Forms.Button()
            Me.tbfecha = New System.Windows.Forms.TextBox()
            Me.tbTelefono = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.tbCantidad = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.listaContactos = New System.Windows.Forms.ListBox()
            Me.SuspendLayout()
            Me.tbNombre.Location = New System.Drawing.Point(187, 145)
            Me.tbNombre.Name = "tbNombre"
            Me.tbNombre.Size = New System.Drawing.Size(339, 22)
            Me.tbNombre.TabIndex = 0
            Me.btnRegistro.BackColor = System.Drawing.SystemColors.Control
            Me.btnRegistro.Font = New System.Drawing.Font("Microsoft YaHei", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.btnRegistro.Location = New System.Drawing.Point(288, 288)
            Me.btnRegistro.Name = "btnRegistro"
            Me.btnRegistro.Size = New System.Drawing.Size(148, 35)
            Me.btnRegistro.TabIndex = 1
            Me.btnRegistro.Text = "GUARDAR"
            Me.btnRegistro.UseVisualStyleBackColor = False
            AddHandler Me.btnRegistro.Click, AddressOf Me.btnRegistro_ClicK
            Me.tbfecha.Location = New System.Drawing.Point(410, 197)
            Me.tbfecha.Name = "tbfecha"
            Me.tbfecha.Size = New System.Drawing.Size(161, 22)
            Me.tbfecha.TabIndex = 2
            Me.tbTelefono.Location = New System.Drawing.Point(189, 246)
            Me.tbTelefono.Name = "tbTelefono"
            Me.tbTelefono.Size = New System.Drawing.Size(193, 22)
            Me.tbTelefono.TabIndex = 3
            Me.label1.AutoSize = True
            Me.label1.Enabled = False
            Me.label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.label1.Location = New System.Drawing.Point(279, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(233, 49)
            Me.label1.TabIndex = 4
            Me.label1.Text = "REGISTRO"
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.label2.Location = New System.Drawing.Point(64, 140)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(106, 27)
            Me.label2.TabIndex = 5
            Me.label2.Text = "NOMBRE:"
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.label3.Location = New System.Drawing.Point(64, 192)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(326, 27)
            Me.label3.TabIndex = 6
            Me.label3.Text = "FECHA DE NAC (MM/DD/AAAA):"
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.label4.Location = New System.Drawing.Point(64, 241)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(119, 27)
            Me.label4.TabIndex = 7
            Me.label4.Text = "TELÉFONO:"
            Me.tbCantidad.Location = New System.Drawing.Point(288, 95)
            Me.tbCantidad.Name = "tbCantidad"
            Me.tbCantidad.Size = New System.Drawing.Size(238, 22)
            Me.tbCantidad.TabIndex = 8
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(66, 101)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(197, 16)
            Me.label5.TabIndex = 9
            Me.label5.Text = "Numero de contactos a agregar"
            Me.btnAceptar.Location = New System.Drawing.Point(542, 94)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnAceptar.TabIndex = 10
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.UseVisualStyleBackColor = True
            AddHandler Me.btnAceptar.Click, AddressOf Me.btnAceptar_Click
            Me.listaContactos.FormattingEnabled = True
            Me.listaContactos.ItemHeight = 16
            Me.listaContactos.Location = New System.Drawing.Point(50, 353)
            Me.listaContactos.Name = "listaContactos"
            Me.listaContactos.Size = New System.Drawing.Size(683, 196)
            Me.listaContactos.TabIndex = 11
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 16.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(808, 570)
            Me.Controls.Add(Me.listaContactos)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.tbCantidad)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.tbTelefono)
            Me.Controls.Add(Me.tbfecha)
            Me.Controls.Add(Me.btnRegistro)
            Me.Controls.Add(Me.tbNombre)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private tbNombre As System.Windows.Forms.TextBox
        Private btnRegistro As System.Windows.Forms.Button
        Private tbfecha As System.Windows.Forms.TextBox
        Private tbTelefono As System.Windows.Forms.TextBox
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private tbCantidad As System.Windows.Forms.TextBox
        Private label5 As System.Windows.Forms.Label
        Private btnAceptar As System.Windows.Forms.Button
        Private listaContactos As System.Windows.Forms.ListBox
        Friend WithEvents btnajksdna As Button
    End Class
End Namespace
