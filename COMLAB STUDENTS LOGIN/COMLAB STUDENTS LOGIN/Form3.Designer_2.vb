<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YrsecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JimzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JimzDataSet1 = New COMLAB_STUDENTS_LOGIN.jimzDataSet1()
        Me.JimzTableAdapter = New COMLAB_STUDENTS_LOGIN.jimzDataSet1TableAdapters.jimzTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JimzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JimzDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.YrsecDataGridViewTextBoxColumn, Me.SnDataGridViewTextBoxColumn, Me.PcnumDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JimzBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 131)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(643, 288)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.VirtualMode = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black
        Me.DateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date Logged In"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "time"
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.LightGray
        Me.TimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle27
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time Logged In"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.LightGray
        Me.NameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle28
        Me.NameDataGridViewTextBoxColumn.HeaderText = "User's Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YrsecDataGridViewTextBoxColumn
        '
        Me.YrsecDataGridViewTextBoxColumn.DataPropertyName = "yrsec"
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.LightGray
        Me.YrsecDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle29
        Me.YrsecDataGridViewTextBoxColumn.HeaderText = "Year/Section"
        Me.YrsecDataGridViewTextBoxColumn.Name = "YrsecDataGridViewTextBoxColumn"
        Me.YrsecDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SnDataGridViewTextBoxColumn
        '
        Me.SnDataGridViewTextBoxColumn.DataPropertyName = "sn"
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.LightGray
        Me.SnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle30
        Me.SnDataGridViewTextBoxColumn.HeaderText = "Student Number"
        Me.SnDataGridViewTextBoxColumn.Name = "SnDataGridViewTextBoxColumn"
        Me.SnDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PcnumDataGridViewTextBoxColumn
        '
        Me.PcnumDataGridViewTextBoxColumn.DataPropertyName = "pcnum"
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.LightGray
        Me.PcnumDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle31
        Me.PcnumDataGridViewTextBoxColumn.HeaderText = "PC Number"
        Me.PcnumDataGridViewTextBoxColumn.Name = "PcnumDataGridViewTextBoxColumn"
        Me.PcnumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JimzBindingSource
        '
        Me.JimzBindingSource.DataMember = "jimz"
        Me.JimzBindingSource.DataSource = Me.JimzDataSet1
        '
        'JimzDataSet1
        '
        Me.JimzDataSet1.DataSetName = "jimzDataSet1"
        Me.JimzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JimzTableAdapter
        '
        Me.JimzTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(679, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 68)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "DELETE RECORDS"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(679, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(934, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(676, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JimzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JimzDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents JimzDataSet1 As COMLAB_STUDENTS_LOGIN.jimzDataSet1
    Friend WithEvents JimzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JimzTableAdapter As COMLAB_STUDENTS_LOGIN.jimzDataSet1TableAdapters.jimzTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YrsecDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PcnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
