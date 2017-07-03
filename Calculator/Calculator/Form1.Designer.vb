<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.dis2 = New System.Windows.Forms.Label
        Me.one = New System.Windows.Forms.Button
        Me.two = New System.Windows.Forms.Button
        Me.three = New System.Windows.Forms.Button
        Me.mul = New System.Windows.Forms.Button
        Me.div = New System.Windows.Forms.Button
        Me.six = New System.Windows.Forms.Button
        Me.five = New System.Windows.Forms.Button
        Me.four = New System.Windows.Forms.Button
        Me.minus = New System.Windows.Forms.Button
        Me.dot = New System.Windows.Forms.Button
        Me.zero = New System.Windows.Forms.Button
        Me.add = New System.Windows.Forms.Button
        Me.nine = New System.Windows.Forms.Button
        Me.eight = New System.Windows.Forms.Button
        Me.seven = New System.Windows.Forms.Button
        Me.equal = New System.Windows.Forms.Button
        Me.dis1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.histry = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dis2
        '
        Me.dis2.AutoSize = True
        Me.dis2.BackColor = System.Drawing.Color.Silver
        Me.dis2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dis2.ForeColor = System.Drawing.Color.Black
        Me.dis2.Location = New System.Drawing.Point(3, 42)
        Me.dis2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dis2.MinimumSize = New System.Drawing.Size(300, 20)
        Me.dis2.Name = "dis2"
        Me.dis2.Size = New System.Drawing.Size(300, 20)
        Me.dis2.TabIndex = 3
        Me.dis2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'one
        '
        Me.one.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.one.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.one.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.one.Location = New System.Drawing.Point(164, 250)
        Me.one.Margin = New System.Windows.Forms.Padding(4)
        Me.one.Name = "one"
        Me.one.Size = New System.Drawing.Size(76, 45)
        Me.one.TabIndex = 4
        Me.one.Text = "1"
        Me.one.UseVisualStyleBackColor = False
        '
        'two
        '
        Me.two.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.two.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.two.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.two.Location = New System.Drawing.Point(90, 250)
        Me.two.Margin = New System.Windows.Forms.Padding(4)
        Me.two.Name = "two"
        Me.two.Size = New System.Drawing.Size(76, 45)
        Me.two.TabIndex = 5
        Me.two.Text = "2"
        Me.two.UseVisualStyleBackColor = False
        '
        'three
        '
        Me.three.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.three.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.three.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.three.Location = New System.Drawing.Point(15, 250)
        Me.three.Margin = New System.Windows.Forms.Padding(4)
        Me.three.Name = "three"
        Me.three.Size = New System.Drawing.Size(76, 45)
        Me.three.TabIndex = 6
        Me.three.Text = "3"
        Me.three.UseVisualStyleBackColor = False
        '
        'mul
        '
        Me.mul.BackColor = System.Drawing.SystemColors.HotTrack
        Me.mul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mul.Location = New System.Drawing.Point(239, 163)
        Me.mul.Margin = New System.Windows.Forms.Padding(4)
        Me.mul.Name = "mul"
        Me.mul.Size = New System.Drawing.Size(76, 45)
        Me.mul.TabIndex = 7
        Me.mul.Text = "MUL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*"
        Me.mul.UseVisualStyleBackColor = False
        '
        'div
        '
        Me.div.BackColor = System.Drawing.SystemColors.HotTrack
        Me.div.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.div.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.div.Location = New System.Drawing.Point(164, 120)
        Me.div.Margin = New System.Windows.Forms.Padding(4)
        Me.div.Name = "div"
        Me.div.Size = New System.Drawing.Size(76, 45)
        Me.div.TabIndex = 11
        Me.div.Text = "DIV" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/"
        Me.div.UseVisualStyleBackColor = False
        '
        'six
        '
        Me.six.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.six.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.six.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.six.Location = New System.Drawing.Point(164, 207)
        Me.six.Margin = New System.Windows.Forms.Padding(4)
        Me.six.Name = "six"
        Me.six.Size = New System.Drawing.Size(76, 45)
        Me.six.TabIndex = 10
        Me.six.Text = "6"
        Me.six.UseVisualStyleBackColor = False
        '
        'five
        '
        Me.five.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.five.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.five.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.five.Location = New System.Drawing.Point(90, 207)
        Me.five.Margin = New System.Windows.Forms.Padding(4)
        Me.five.Name = "five"
        Me.five.Size = New System.Drawing.Size(76, 45)
        Me.five.TabIndex = 9
        Me.five.Text = "5"
        Me.five.UseVisualStyleBackColor = False
        '
        'four
        '
        Me.four.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.four.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.four.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.four.Location = New System.Drawing.Point(15, 207)
        Me.four.Margin = New System.Windows.Forms.Padding(4)
        Me.four.Name = "four"
        Me.four.Size = New System.Drawing.Size(76, 45)
        Me.four.TabIndex = 8
        Me.four.Text = "4"
        Me.four.UseVisualStyleBackColor = False
        '
        'minus
        '
        Me.minus.BackColor = System.Drawing.SystemColors.HotTrack
        Me.minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.minus.Location = New System.Drawing.Point(238, 207)
        Me.minus.Margin = New System.Windows.Forms.Padding(4)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(76, 45)
        Me.minus.TabIndex = 19
        Me.minus.Text = "SUB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-"
        Me.minus.UseVisualStyleBackColor = False
        '
        'dot
        '
        Me.dot.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dot.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.dot.Location = New System.Drawing.Point(164, 293)
        Me.dot.Margin = New System.Windows.Forms.Padding(4)
        Me.dot.Name = "dot"
        Me.dot.Size = New System.Drawing.Size(76, 45)
        Me.dot.TabIndex = 17
        Me.dot.Text = "DOT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "."
        Me.dot.UseVisualStyleBackColor = False
        '
        'zero
        '
        Me.zero.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zero.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.zero.Location = New System.Drawing.Point(90, 293)
        Me.zero.Margin = New System.Windows.Forms.Padding(4)
        Me.zero.Name = "zero"
        Me.zero.Size = New System.Drawing.Size(76, 45)
        Me.zero.TabIndex = 16
        Me.zero.Text = "0"
        Me.zero.UseVisualStyleBackColor = False
        '
        'add
        '
        Me.add.BackColor = System.Drawing.SystemColors.HotTrack
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.add.Location = New System.Drawing.Point(239, 250)
        Me.add.Margin = New System.Windows.Forms.Padding(4)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(76, 45)
        Me.add.TabIndex = 15
        Me.add.Text = "ADD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+"
        Me.add.UseVisualStyleBackColor = False
        '
        'nine
        '
        Me.nine.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nine.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.nine.Location = New System.Drawing.Point(164, 163)
        Me.nine.Margin = New System.Windows.Forms.Padding(4)
        Me.nine.Name = "nine"
        Me.nine.Size = New System.Drawing.Size(76, 45)
        Me.nine.TabIndex = 14
        Me.nine.Text = "9"
        Me.nine.UseVisualStyleBackColor = False
        '
        'eight
        '
        Me.eight.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.eight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eight.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.eight.Location = New System.Drawing.Point(90, 163)
        Me.eight.Margin = New System.Windows.Forms.Padding(4)
        Me.eight.Name = "eight"
        Me.eight.Size = New System.Drawing.Size(76, 45)
        Me.eight.TabIndex = 13
        Me.eight.Text = "8"
        Me.eight.UseVisualStyleBackColor = False
        '
        'seven
        '
        Me.seven.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.seven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seven.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.seven.Location = New System.Drawing.Point(15, 163)
        Me.seven.Margin = New System.Windows.Forms.Padding(4)
        Me.seven.Name = "seven"
        Me.seven.Size = New System.Drawing.Size(76, 45)
        Me.seven.TabIndex = 12
        Me.seven.Text = "7"
        Me.seven.UseVisualStyleBackColor = False
        '
        'equal
        '
        Me.equal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.equal.Location = New System.Drawing.Point(239, 293)
        Me.equal.Margin = New System.Windows.Forms.Padding(4)
        Me.equal.Name = "equal"
        Me.equal.Size = New System.Drawing.Size(76, 45)
        Me.equal.TabIndex = 18
        Me.equal.Text = "ANS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "="
        Me.equal.UseVisualStyleBackColor = False
        '
        'dis1
        '
        Me.dis1.AutoSize = True
        Me.dis1.BackColor = System.Drawing.Color.Silver
        Me.dis1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dis1.ForeColor = System.Drawing.Color.Red
        Me.dis1.Location = New System.Drawing.Point(3, 77)
        Me.dis1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dis1.MinimumSize = New System.Drawing.Size(300, 40)
        Me.dis1.Name = "dis1"
        Me.dis1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dis1.Size = New System.Drawing.Size(300, 40)
        Me.dis1.TabIndex = 20
        Me.dis1.Text = "0"
        Me.dis1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(241, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 45)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(15, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 45)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "C"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(15, 293)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 45)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "-/+"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(90, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 45)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "CE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'histry
        '
        Me.histry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.histry.FlatAppearance.BorderSize = 0
        Me.histry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.histry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.histry.Image = CType(resources.GetObject("histry.Image"), System.Drawing.Image)
        Me.histry.Location = New System.Drawing.Point(270, 0)
        Me.histry.Name = "histry"
        Me.histry.Size = New System.Drawing.Size(44, 28)
        Me.histry.TabIndex = 25
        Me.histry.Tag = "Histry"
        Me.histry.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 260)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(214, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Clear"
        Me.Label2.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(4, 11)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(303, 217)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(262, 225)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 35)
        Me.Button5.TabIndex = 0
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(271, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Histry"
        Me.Label1.Visible = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(319, 376)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.histry)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dis1)
        Me.Controls.Add(Me.minus)
        Me.Controls.Add(Me.equal)
        Me.Controls.Add(Me.dot)
        Me.Controls.Add(Me.zero)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.nine)
        Me.Controls.Add(Me.eight)
        Me.Controls.Add(Me.seven)
        Me.Controls.Add(Me.div)
        Me.Controls.Add(Me.six)
        Me.Controls.Add(Me.five)
        Me.Controls.Add(Me.four)
        Me.Controls.Add(Me.mul)
        Me.Controls.Add(Me.three)
        Me.Controls.Add(Me.two)
        Me.Controls.Add(Me.one)
        Me.Controls.Add(Me.dis2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Calculator"
        Me.Text = "Standard Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Digits As System.Windows.Forms.Button
    Friend WithEvents dis2 As System.Windows.Forms.Label
    Friend WithEvents one As System.Windows.Forms.Button
    Friend WithEvents two As System.Windows.Forms.Button
    Friend WithEvents three As System.Windows.Forms.Button
    Friend WithEvents mul As System.Windows.Forms.Button
    Friend WithEvents div As System.Windows.Forms.Button
    Friend WithEvents six As System.Windows.Forms.Button
    Friend WithEvents five As System.Windows.Forms.Button
    Friend WithEvents four As System.Windows.Forms.Button
    Friend WithEvents minus As System.Windows.Forms.Button
    Friend WithEvents dot As System.Windows.Forms.Button
    Friend WithEvents zero As System.Windows.Forms.Button
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents nine As System.Windows.Forms.Button
    Friend WithEvents eight As System.Windows.Forms.Button
    Friend WithEvents seven As System.Windows.Forms.Button
    Friend WithEvents equal As System.Windows.Forms.Button
    Friend WithEvents dis1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents histry As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
