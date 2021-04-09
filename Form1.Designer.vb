<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.decks_dir = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnconvert = New System.Windows.Forms.Button()
        Me.txlog = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.iscommander = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.decks_dir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Select XMage Decks Folder"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(695, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Bronwse"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'decks_dir
        '
        Me.decks_dir.Location = New System.Drawing.Point(18, 35)
        Me.decks_dir.Name = "decks_dir"
        Me.decks_dir.Size = New System.Drawing.Size(671, 22)
        Me.decks_dir.TabIndex = 0
        '
        'btnconvert
        '
        Me.btnconvert.Location = New System.Drawing.Point(247, 110)
        Me.btnconvert.Name = "btnconvert"
        Me.btnconvert.Size = New System.Drawing.Size(300, 43)
        Me.btnconvert.TabIndex = 2
        Me.btnconvert.Text = "Convert XMage .dck to Forge .dck"
        Me.btnconvert.UseVisualStyleBackColor = true
        '
        'txlog
        '
        Me.txlog.Location = New System.Drawing.Point(12, 168)
        Me.txlog.Multiline = true
        Me.txlog.Name = "txlog"
        Me.txlog.ReadOnly = true
        Me.txlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txlog.Size = New System.Drawing.Size(788, 329)
        Me.txlog.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.Location = New System.Drawing.Point(729, 500)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 17)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "My Github"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'iscommander
        '
        Me.iscommander.AutoSize = true
        Me.iscommander.Location = New System.Drawing.Point(572, 121)
        Me.iscommander.Name = "iscommander"
        Me.iscommander.Size = New System.Drawing.Size(149, 21)
        Me.iscommander.TabIndex = 5
        Me.iscommander.Text = "Commander Decks"
        Me.iscommander.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 523)
        Me.Controls.Add(Me.iscommander)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txlog)
        Me.Controls.Add(Me.btnconvert)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = false
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XMageDeckstoForge"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents decks_dir As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnconvert As Button
    Friend WithEvents txlog As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents iscommander As CheckBox
End Class
