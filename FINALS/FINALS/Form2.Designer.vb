<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.total1 = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.Label()
        Me.cash = New System.Windows.Forms.Label()
        Me.cash1 = New System.Windows.Forms.TextBox()
        Me.change = New System.Windows.Forms.Label()
        Me.change1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.answer = New System.Windows.Forms.TextBox()
        Me.equal = New System.Windows.Forms.Button()
        Me.dot = New System.Windows.Forms.Button()
        Me.eight = New System.Windows.Forms.Button()
        Me.five = New System.Windows.Forms.Button()
        Me.two = New System.Windows.Forms.Button()
        Me.zero = New System.Windows.Forms.Button()
        Me.seven = New System.Windows.Forms.Button()
        Me.four = New System.Windows.Forms.Button()
        Me.one = New System.Windows.Forms.Button()
        Me.divide = New System.Windows.Forms.Button()
        Me.c = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.nine = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.six = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.three = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'total1
        '
        Me.total1.Enabled = False
        Me.total1.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total1.ForeColor = System.Drawing.Color.Black
        Me.total1.Location = New System.Drawing.Point(111, 19)
        Me.total1.MaxLength = 2
        Me.total1.Name = "total1"
        Me.total1.Size = New System.Drawing.Size(241, 31)
        Me.total1.TabIndex = 17
        Me.total1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.Color.White
        Me.total.Location = New System.Drawing.Point(52, 22)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(53, 24)
        Me.total.TabIndex = 16
        Me.total.Text = "Total:"
        '
        'cash
        '
        Me.cash.AutoSize = True
        Me.cash.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cash.ForeColor = System.Drawing.Color.White
        Me.cash.Location = New System.Drawing.Point(52, 62)
        Me.cash.Name = "cash"
        Me.cash.Size = New System.Drawing.Size(52, 24)
        Me.cash.TabIndex = 16
        Me.cash.Text = "Cash:"
        '
        'cash1
        '
        Me.cash1.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cash1.ForeColor = System.Drawing.Color.Black
        Me.cash1.Location = New System.Drawing.Point(111, 58)
        Me.cash1.MaxLength = 5
        Me.cash1.Name = "cash1"
        Me.cash1.Size = New System.Drawing.Size(241, 31)
        Me.cash1.TabIndex = 17
        Me.cash1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.ForeColor = System.Drawing.Color.White
        Me.change.Location = New System.Drawing.Point(32, 102)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(75, 24)
        Me.change.TabIndex = 16
        Me.change.Text = "Change:"
        '
        'change1
        '
        Me.change1.Enabled = False
        Me.change1.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change1.ForeColor = System.Drawing.Color.Black
        Me.change1.Location = New System.Drawing.Point(111, 97)
        Me.change1.MaxLength = 2
        Me.change1.Name = "change1"
        Me.change1.Size = New System.Drawing.Size(241, 31)
        Me.change1.TabIndex = 17
        Me.change1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(195, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.answer)
        Me.GroupBox1.Controls.Add(Me.equal)
        Me.GroupBox1.Controls.Add(Me.dot)
        Me.GroupBox1.Controls.Add(Me.eight)
        Me.GroupBox1.Controls.Add(Me.five)
        Me.GroupBox1.Controls.Add(Me.two)
        Me.GroupBox1.Controls.Add(Me.zero)
        Me.GroupBox1.Controls.Add(Me.seven)
        Me.GroupBox1.Controls.Add(Me.four)
        Me.GroupBox1.Controls.Add(Me.one)
        Me.GroupBox1.Controls.Add(Me.divide)
        Me.GroupBox1.Controls.Add(Me.c)
        Me.GroupBox1.Controls.Add(Me.multiply)
        Me.GroupBox1.Controls.Add(Me.nine)
        Me.GroupBox1.Controls.Add(Me.minus)
        Me.GroupBox1.Controls.Add(Me.six)
        Me.GroupBox1.Controls.Add(Me.add)
        Me.GroupBox1.Controls.Add(Me.three)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 296)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'answer
        '
        Me.answer.BackColor = System.Drawing.Color.White
        Me.answer.Font = New System.Drawing.Font("Poor Richard", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer.ForeColor = System.Drawing.Color.Black
        Me.answer.Location = New System.Drawing.Point(6, 19)
        Me.answer.MaxLength = 20
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(310, 49)
        Me.answer.TabIndex = 1
        Me.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'equal
        '
        Me.equal.BackColor = System.Drawing.Color.White
        Me.equal.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equal.Location = New System.Drawing.Point(6, 245)
        Me.equal.Name = "equal"
        Me.equal.Size = New System.Drawing.Size(310, 43)
        Me.equal.TabIndex = 20
        Me.equal.Text = "="
        Me.equal.UseVisualStyleBackColor = False
        '
        'dot
        '
        Me.dot.BackColor = System.Drawing.Color.White
        Me.dot.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dot.Location = New System.Drawing.Point(83, 202)
        Me.dot.Name = "dot"
        Me.dot.Size = New System.Drawing.Size(79, 43)
        Me.dot.TabIndex = 19
        Me.dot.Text = "."
        Me.dot.UseVisualStyleBackColor = False
        '
        'eight
        '
        Me.eight.BackColor = System.Drawing.Color.White
        Me.eight.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eight.Location = New System.Drawing.Point(83, 159)
        Me.eight.Name = "eight"
        Me.eight.Size = New System.Drawing.Size(79, 43)
        Me.eight.TabIndex = 19
        Me.eight.Text = "8"
        Me.eight.UseVisualStyleBackColor = False
        '
        'five
        '
        Me.five.BackColor = System.Drawing.Color.White
        Me.five.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.five.Location = New System.Drawing.Point(83, 116)
        Me.five.Name = "five"
        Me.five.Size = New System.Drawing.Size(79, 43)
        Me.five.TabIndex = 19
        Me.five.Text = "5"
        Me.five.UseVisualStyleBackColor = False
        '
        'two
        '
        Me.two.BackColor = System.Drawing.Color.White
        Me.two.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.two.Location = New System.Drawing.Point(83, 74)
        Me.two.Name = "two"
        Me.two.Size = New System.Drawing.Size(79, 43)
        Me.two.TabIndex = 19
        Me.two.Text = "2"
        Me.two.UseVisualStyleBackColor = False
        '
        'zero
        '
        Me.zero.BackColor = System.Drawing.Color.White
        Me.zero.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zero.Location = New System.Drawing.Point(6, 202)
        Me.zero.Name = "zero"
        Me.zero.Size = New System.Drawing.Size(79, 43)
        Me.zero.TabIndex = 19
        Me.zero.Text = "0"
        Me.zero.UseVisualStyleBackColor = False
        '
        'seven
        '
        Me.seven.BackColor = System.Drawing.Color.White
        Me.seven.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seven.Location = New System.Drawing.Point(6, 160)
        Me.seven.Name = "seven"
        Me.seven.Size = New System.Drawing.Size(79, 43)
        Me.seven.TabIndex = 19
        Me.seven.Text = "7"
        Me.seven.UseVisualStyleBackColor = False
        '
        'four
        '
        Me.four.BackColor = System.Drawing.Color.White
        Me.four.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.four.Location = New System.Drawing.Point(6, 116)
        Me.four.Name = "four"
        Me.four.Size = New System.Drawing.Size(79, 43)
        Me.four.TabIndex = 19
        Me.four.Text = "4"
        Me.four.UseVisualStyleBackColor = False
        '
        'one
        '
        Me.one.BackColor = System.Drawing.Color.White
        Me.one.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.one.Location = New System.Drawing.Point(6, 74)
        Me.one.Name = "one"
        Me.one.Size = New System.Drawing.Size(79, 43)
        Me.one.TabIndex = 19
        Me.one.Text = "1"
        Me.one.UseVisualStyleBackColor = False
        '
        'divide
        '
        Me.divide.BackColor = System.Drawing.Color.White
        Me.divide.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divide.Location = New System.Drawing.Point(237, 202)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(79, 43)
        Me.divide.TabIndex = 19
        Me.divide.Text = "/"
        Me.divide.UseVisualStyleBackColor = False
        '
        'c
        '
        Me.c.BackColor = System.Drawing.Color.White
        Me.c.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.Location = New System.Drawing.Point(160, 202)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(79, 43)
        Me.c.TabIndex = 19
        Me.c.Text = "C"
        Me.c.UseVisualStyleBackColor = False
        '
        'multiply
        '
        Me.multiply.BackColor = System.Drawing.Color.White
        Me.multiply.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiply.Location = New System.Drawing.Point(237, 159)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(79, 43)
        Me.multiply.TabIndex = 19
        Me.multiply.Text = "*"
        Me.multiply.UseVisualStyleBackColor = False
        '
        'nine
        '
        Me.nine.BackColor = System.Drawing.Color.White
        Me.nine.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nine.Location = New System.Drawing.Point(160, 159)
        Me.nine.Name = "nine"
        Me.nine.Size = New System.Drawing.Size(79, 43)
        Me.nine.TabIndex = 19
        Me.nine.Text = "9"
        Me.nine.UseVisualStyleBackColor = False
        '
        'minus
        '
        Me.minus.BackColor = System.Drawing.Color.White
        Me.minus.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minus.Location = New System.Drawing.Point(237, 116)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(79, 43)
        Me.minus.TabIndex = 19
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = False
        '
        'six
        '
        Me.six.BackColor = System.Drawing.Color.White
        Me.six.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.six.Location = New System.Drawing.Point(160, 116)
        Me.six.Name = "six"
        Me.six.Size = New System.Drawing.Size(79, 43)
        Me.six.TabIndex = 19
        Me.six.Text = "6"
        Me.six.UseVisualStyleBackColor = False
        '
        'add
        '
        Me.add.BackColor = System.Drawing.Color.White
        Me.add.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(237, 74)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(79, 43)
        Me.add.TabIndex = 19
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = False
        '
        'three
        '
        Me.three.BackColor = System.Drawing.Color.White
        Me.three.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.three.Location = New System.Drawing.Point(160, 74)
        Me.three.Name = "three"
        Me.three.Size = New System.Drawing.Size(79, 43)
        Me.three.TabIndex = 19
        Me.three.Text = "3"
        Me.three.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(280, 450)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 43)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Ok"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 497)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.change1)
        Me.Controls.Add(Me.change)
        Me.Controls.Add(Me.cash1)
        Me.Controls.Add(Me.cash)
        Me.Controls.Add(Me.total1)
        Me.Controls.Add(Me.total)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents total1 As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents cash As System.Windows.Forms.Label
    Friend WithEvents cash1 As System.Windows.Forms.TextBox
    Friend WithEvents change As System.Windows.Forms.Label
    Friend WithEvents change1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents answer As System.Windows.Forms.TextBox
    Friend WithEvents equal As System.Windows.Forms.Button
    Friend WithEvents dot As System.Windows.Forms.Button
    Friend WithEvents eight As System.Windows.Forms.Button
    Friend WithEvents five As System.Windows.Forms.Button
    Friend WithEvents two As System.Windows.Forms.Button
    Friend WithEvents zero As System.Windows.Forms.Button
    Friend WithEvents seven As System.Windows.Forms.Button
    Friend WithEvents four As System.Windows.Forms.Button
    Friend WithEvents one As System.Windows.Forms.Button
    Friend WithEvents divide As System.Windows.Forms.Button
    Friend WithEvents c As System.Windows.Forms.Button
    Friend WithEvents multiply As System.Windows.Forms.Button
    Friend WithEvents nine As System.Windows.Forms.Button
    Friend WithEvents minus As System.Windows.Forms.Button
    Friend WithEvents six As System.Windows.Forms.Button
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents three As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
