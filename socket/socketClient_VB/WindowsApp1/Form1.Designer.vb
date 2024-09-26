<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_CarOut = New System.Windows.Forms.Button()
        Me.IPadress = New System.Windows.Forms.Label()
        Me.DB_IP_Box = New System.Windows.Forms.TextBox()
        Me.IN_CarNumBox = New System.Windows.Forms.TextBox()
        Me.CarNum = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IN_Interface_id_Box = New System.Windows.Forms.TextBox()
        Me.DB_Name_Box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Socket_IP_Box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Socket_Port_Box = New System.Windows.Forms.TextBox()
        Me.Btn_CarIn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Total_Weight_Box = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Empty_Weight_Box = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OUT_CarNumBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OUT_Interface_id_Box = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_CarOut
        '
        Me.Btn_CarOut.Location = New System.Drawing.Point(584, 55)
        Me.Btn_CarOut.Name = "Btn_CarOut"
        Me.Btn_CarOut.Size = New System.Drawing.Size(96, 29)
        Me.Btn_CarOut.TabIndex = 0
        Me.Btn_CarOut.Text = "출차"
        Me.Btn_CarOut.UseVisualStyleBackColor = True
        '
        'IPadress
        '
        Me.IPadress.AutoSize = True
        Me.IPadress.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.IPadress.Location = New System.Drawing.Point(42, 204)
        Me.IPadress.Name = "IPadress"
        Me.IPadress.Size = New System.Drawing.Size(59, 20)
        Me.IPadress.TabIndex = 1
        Me.IPadress.Text = "DB_IP"
        '
        'DB_IP_Box
        '
        Me.DB_IP_Box.Location = New System.Drawing.Point(107, 204)
        Me.DB_IP_Box.Name = "DB_IP_Box"
        Me.DB_IP_Box.Size = New System.Drawing.Size(88, 21)
        Me.DB_IP_Box.TabIndex = 2
        '
        'IN_CarNumBox
        '
        Me.IN_CarNumBox.Location = New System.Drawing.Point(329, 43)
        Me.IN_CarNumBox.Name = "IN_CarNumBox"
        Me.IN_CarNumBox.Size = New System.Drawing.Size(64, 21)
        Me.IN_CarNumBox.TabIndex = 6
        '
        'CarNum
        '
        Me.CarNum.AutoSize = True
        Me.CarNum.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CarNum.Location = New System.Drawing.Point(249, 45)
        Me.CarNum.Name = "CarNum"
        Me.CarNum.Size = New System.Drawing.Size(74, 20)
        Me.CarNum.TabIndex = 5
        Me.CarNum.Text = "CarNum"
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Location = New System.Drawing.Point(46, 21)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(680, 164)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "INTERFACE_ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IN_Interface_id_Box
        '
        Me.IN_Interface_id_Box.Location = New System.Drawing.Point(159, 44)
        Me.IN_Interface_id_Box.Name = "IN_Interface_id_Box"
        Me.IN_Interface_id_Box.Size = New System.Drawing.Size(66, 21)
        Me.IN_Interface_id_Box.TabIndex = 10
        '
        'DB_Name_Box
        '
        Me.DB_Name_Box.Location = New System.Drawing.Point(299, 204)
        Me.DB_Name_Box.Name = "DB_Name_Box"
        Me.DB_Name_Box.Size = New System.Drawing.Size(64, 21)
        Me.DB_Name_Box.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "DB_Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(369, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Socket_IP"
        '
        'Socket_IP_Box
        '
        Me.Socket_IP_Box.Location = New System.Drawing.Point(470, 204)
        Me.Socket_IP_Box.Name = "Socket_IP_Box"
        Me.Socket_IP_Box.Size = New System.Drawing.Size(88, 21)
        Me.Socket_IP_Box.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(564, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Socket_Port"
        '
        'Socket_Port_Box
        '
        Me.Socket_Port_Box.Location = New System.Drawing.Point(683, 204)
        Me.Socket_Port_Box.Name = "Socket_Port_Box"
        Me.Socket_Port_Box.Size = New System.Drawing.Size(43, 21)
        Me.Socket_Port_Box.TabIndex = 18
        '
        'Btn_CarIn
        '
        Me.Btn_CarIn.Location = New System.Drawing.Point(584, 52)
        Me.Btn_CarIn.Name = "Btn_CarIn"
        Me.Btn_CarIn.Size = New System.Drawing.Size(96, 29)
        Me.Btn_CarIn.TabIndex = 19
        Me.Btn_CarIn.Text = "입차"
        Me.Btn_CarIn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Total_Weight_Box)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Btn_CarIn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.IN_CarNumBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CarNum)
        Me.Panel1.Controls.Add(Me.IN_Interface_id_Box)
        Me.Panel1.Location = New System.Drawing.Point(46, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 84)
        Me.Panel1.TabIndex = 20
        '
        'Total_Weight_Box
        '
        Me.Total_Weight_Box.Location = New System.Drawing.Point(506, 43)
        Me.Total_Weight_Box.Name = "Total_Weight_Box"
        Me.Total_Weight_Box.Size = New System.Drawing.Size(64, 21)
        Me.Total_Weight_Box.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.Location = New System.Drawing.Point(420, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "1차중량"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "입차 데이터"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Btn_CarOut)
        Me.Panel2.Controls.Add(Me.Empty_Weight_Box)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.OUT_CarNumBox)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.OUT_Interface_id_Box)
        Me.Panel2.Location = New System.Drawing.Point(46, 333)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(680, 84)
        Me.Panel2.TabIndex = 21
        '
        'Empty_Weight_Box
        '
        Me.Empty_Weight_Box.Location = New System.Drawing.Point(506, 45)
        Me.Empty_Weight_Box.Name = "Empty_Weight_Box"
        Me.Empty_Weight_Box.Size = New System.Drawing.Size(64, 21)
        Me.Empty_Weight_Box.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.Location = New System.Drawing.Point(420, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "2차중량"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "출차 데이터"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OUT_CarNumBox
        '
        Me.OUT_CarNumBox.Location = New System.Drawing.Point(329, 43)
        Me.OUT_CarNumBox.Name = "OUT_CarNumBox"
        Me.OUT_CarNumBox.Size = New System.Drawing.Size(64, 21)
        Me.OUT_CarNumBox.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "INTERFACE_ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label10.Location = New System.Drawing.Point(249, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "CarNum"
        '
        'OUT_Interface_id_Box
        '
        Me.OUT_Interface_id_Box.Location = New System.Drawing.Point(159, 44)
        Me.OUT_Interface_id_Box.Name = "OUT_Interface_id_Box"
        Me.OUT_Interface_id_Box.Size = New System.Drawing.Size(66, 21)
        Me.OUT_Interface_id_Box.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Socket_Port_Box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Socket_IP_Box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DB_Name_Box)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DB_IP_Box)
        Me.Controls.Add(Me.IPadress)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_CarOut As Button
    Friend WithEvents IPadress As Label
    Friend WithEvents DB_IP_Box As TextBox
    Friend WithEvents IN_CarNumBox As TextBox
    Friend WithEvents CarNum As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IN_Interface_id_Box As TextBox
    Friend WithEvents DB_Name_Box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Socket_IP_Box As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Socket_Port_Box As TextBox
    Friend WithEvents Btn_CarIn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Total_Weight_Box As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Empty_Weight_Box As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents OUT_CarNumBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents OUT_Interface_id_Box As TextBox
End Class
