﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(37, 55)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 30)
        Button1.TabIndex = 0
        Button1.Text = "Hintergrund Rot"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(177, 55)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 30)
        Button2.TabIndex = 1
        Button2.Text = "Hintergrund Blau"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(37, 233)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 31)
        Label1.TabIndex = 2
        Label1.Text = "Testtext"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(177, 115)
        Button3.Margin = New Padding(4, 3, 4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 30)
        Button3.TabIndex = 4
        Button3.Text = "Label Gelb"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(37, 115)
        Button4.Margin = New Padding(4, 3, 4, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(115, 30)
        Button4.TabIndex = 3
        Button4.Text = "Label Grün"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(37, 175)
        Button5.Name = "Button5"
        Button5.Size = New Size(115, 30)
        Button5.TabIndex = 5
        Button5.Text = "Text setzen"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(177, 175)
        Button6.Name = "Button6"
        Button6.Size = New Size(115, 30)
        Button6.TabIndex = 6
        Button6.Text = "Text löschen"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(331, 302)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Eigenschaften setzen"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
