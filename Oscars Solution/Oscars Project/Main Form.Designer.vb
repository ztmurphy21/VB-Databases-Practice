<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.OscarsDataSet = New Oscars_Project.OscarsDataSet()
        Me.TblOscarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblOscarsTableAdapter = New Oscars_Project.OscarsDataSetTableAdapters.tblOscarsTableAdapter()
        Me.TableAdapterManager = New Oscars_Project.OscarsDataSetTableAdapters.TableAdapterManager()
        Me.TblOscarsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAnimated = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPicture = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtActress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtActor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddYear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstDeleteYear = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.OscarsDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TblOscarsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TblOscarsDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'OscarsDataSet
        '
        Me.OscarsDataSet.DataSetName = "OscarsDataSet"
        Me.OscarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblOscarsBindingSource
        '
        Me.TblOscarsBindingSource.DataMember = "tblOscars"
        Me.TblOscarsBindingSource.DataSource = Me.OscarsDataSet
        '
        'TblOscarsTableAdapter
        '
        Me.TblOscarsTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager.tblOscarsTableAdapter = Me.TblOscarsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Oscars_Project.OscarsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblOscarsDataGridView
        '
        Me.TblOscarsDataGridView.AllowUserToAddRows = false
        Me.TblOscarsDataGridView.AllowUserToDeleteRows = false
        Me.TblOscarsDataGridView.AutoGenerateColumns = false
        Me.TblOscarsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblOscarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblOscarsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblOscarsDataGridView.DataSource = Me.TblOscarsBindingSource
        Me.TblOscarsDataGridView.Location = New System.Drawing.Point(12, 10)
        Me.TblOscarsDataGridView.Name = "TblOscarsDataGridView"
        Me.TblOscarsDataGridView.ReadOnly = true
        Me.TblOscarsDataGridView.RowHeadersVisible = false
        Me.TblOscarsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblOscarsDataGridView.Size = New System.Drawing.Size(695, 262)
        Me.TblOscarsDataGridView.StandardTab = true
        Me.TblOscarsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "YearWon"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = true
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Actor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Actor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = true
        Me.DataGridViewTextBoxColumn2.Width = 61
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Actress"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Actress"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = true
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Picture"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Picture"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = true
        Me.DataGridViewTextBoxColumn4.Width = 69
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Animated"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Animated"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtAnimated)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPicture)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtActress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtActor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAddYear)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 148)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Add new record"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(306, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'txtAnimated
        '
        Me.txtAnimated.Location = New System.Drawing.Point(223, 109)
        Me.txtAnimated.Name = "txtAnimated"
        Me.txtAnimated.Size = New System.Drawing.Size(202, 23)
        Me.txtAnimated.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(220, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "A&nimated:"
        '
        'txtPicture
        '
        Me.txtPicture.Location = New System.Drawing.Point(10, 109)
        Me.txtPicture.Name = "txtPicture"
        Me.txtPicture.Size = New System.Drawing.Size(202, 23)
        Me.txtPicture.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(7, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Picture:"
        '
        'txtActress
        '
        Me.txtActress.Location = New System.Drawing.Point(120, 53)
        Me.txtActress.Name = "txtActress"
        Me.txtActress.Size = New System.Drawing.Size(162, 23)
        Me.txtActress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(69, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Actre&ss:"
        '
        'txtActor
        '
        Me.txtActor.Location = New System.Drawing.Point(120, 24)
        Me.txtActor.Name = "txtActor"
        Me.txtActor.Size = New System.Drawing.Size(162, 23)
        Me.txtActor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(69, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Acto&r:"
        '
        'txtAddYear
        '
        Me.txtAddYear.Location = New System.Drawing.Point(10, 41)
        Me.txtAddYear.Name = "txtAddYear"
        Me.txtAddYear.Size = New System.Drawing.Size(43, 23)
        Me.txtAddYear.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Year:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstDeleteYear)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(503, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 106)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Delete record"
        '
        'lstDeleteYear
        '
        Me.lstDeleteYear.DataSource = Me.TblOscarsBindingSource
        Me.lstDeleteYear.DisplayMember = "YearWon"
        Me.lstDeleteYear.FormattingEnabled = true
        Me.lstDeleteYear.ItemHeight = 15
        Me.lstDeleteYear.Location = New System.Drawing.Point(9, 41)
        Me.lstDeleteYear.Name = "lstDeleteYear"
        Me.lstDeleteYear.Size = New System.Drawing.Size(85, 49)
        Me.lstDeleteYear.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(114, 15)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Y&ear:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(632, 414)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 464)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TblOscarsDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oscar Winners"
        CType(Me.OscarsDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TblOscarsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TblOscarsDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents OscarsDataSet As OscarsDataSet
    Friend WithEvents TblOscarsBindingSource As BindingSource
    Friend WithEvents TblOscarsTableAdapter As OscarsDataSetTableAdapters.tblOscarsTableAdapter
    Friend WithEvents TableAdapterManager As OscarsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblOscarsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtAnimated As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPicture As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtActress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtActor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddYear As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstDeleteYear As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As Button
End Class
