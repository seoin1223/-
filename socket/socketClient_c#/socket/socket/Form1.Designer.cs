
namespace socket
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Btn_CarOut = new System.Windows.Forms.Button();
            this.Empty_Weight_Box = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.OUT_CarNumBox = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.OUT_Interface_id_Box = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Total_Weight_Box = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Btn_CarIn = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.IN_CarNumBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CarNum = new System.Windows.Forms.Label();
            this.IN_Interface_id_Box = new System.Windows.Forms.TextBox();
            this.Socket_Port_Box = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Socket_IP_Box = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.DB_Name_Box = new System.Windows.Forms.TextBox();
            this.DB_IP_Box = new System.Windows.Forms.TextBox();
            this.IPadress = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.TextBox1.Location = new System.Drawing.Point(55, 23);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(680, 164);
            this.TextBox1.TabIndex = 26;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel2.Controls.Add(this.Btn_CarOut);
            this.Panel2.Controls.Add(this.Empty_Weight_Box);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.OUT_CarNumBox);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.OUT_Interface_id_Box);
            this.Panel2.Location = new System.Drawing.Point(58, 327);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(680, 84);
            this.Panel2.TabIndex = 17;
            // 
            // Btn_CarOut
            // 
            this.Btn_CarOut.Location = new System.Drawing.Point(584, 55);
            this.Btn_CarOut.Name = "Btn_CarOut";
            this.Btn_CarOut.Size = new System.Drawing.Size(96, 29);
            this.Btn_CarOut.TabIndex = 25;
            this.Btn_CarOut.Text = "출차";
            this.Btn_CarOut.UseVisualStyleBackColor = true;
            this.Btn_CarOut.Click += new System.EventHandler(this.Btn_CarOut_Click);
            // 
            // Empty_Weight_Box
            // 
            this.Empty_Weight_Box.Location = new System.Drawing.Point(506, 45);
            this.Empty_Weight_Box.Name = "Empty_Weight_Box";
            this.Empty_Weight_Box.Size = new System.Drawing.Size(64, 21);
            this.Empty_Weight_Box.TabIndex = 24;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label7.Location = new System.Drawing.Point(420, 45);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 20);
            this.Label7.TabIndex = 23;
            this.Label7.Text = "2차중량";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label8.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label8.Location = new System.Drawing.Point(3, 4);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(116, 20);
            this.Label8.TabIndex = 11;
            this.Label8.Text = "출차 데이터";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OUT_CarNumBox
            // 
            this.OUT_CarNumBox.Location = new System.Drawing.Point(329, 43);
            this.OUT_CarNumBox.Name = "OUT_CarNumBox";
            this.OUT_CarNumBox.Size = new System.Drawing.Size(64, 21);
            this.OUT_CarNumBox.TabIndex = 22;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label9.Location = new System.Drawing.Point(20, 44);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(133, 20);
            this.Label9.TabIndex = 19;
            this.Label9.Text = "INTERFACE_ID";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label10.Location = new System.Drawing.Point(249, 45);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(74, 20);
            this.Label10.TabIndex = 21;
            this.Label10.Text = "CarNum";
            // 
            // OUT_Interface_id_Box
            // 
            this.OUT_Interface_id_Box.Location = new System.Drawing.Point(159, 44);
            this.OUT_Interface_id_Box.Name = "OUT_Interface_id_Box";
            this.OUT_Interface_id_Box.Size = new System.Drawing.Size(66, 21);
            this.OUT_Interface_id_Box.TabIndex = 20;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel1.Controls.Add(this.Total_Weight_Box);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Btn_CarIn);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.IN_CarNumBox);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.CarNum);
            this.Panel1.Controls.Add(this.IN_Interface_id_Box);
            this.Panel1.Location = new System.Drawing.Point(58, 237);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(680, 84);
            this.Panel1.TabIndex = 9;
            // 
            // Total_Weight_Box
            // 
            this.Total_Weight_Box.Location = new System.Drawing.Point(506, 43);
            this.Total_Weight_Box.Name = "Total_Weight_Box";
            this.Total_Weight_Box.Size = new System.Drawing.Size(64, 21);
            this.Total_Weight_Box.TabIndex = 15;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label6.Location = new System.Drawing.Point(420, 44);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "1차중량";
            // 
            // Btn_CarIn
            // 
            this.Btn_CarIn.Location = new System.Drawing.Point(584, 52);
            this.Btn_CarIn.Name = "Btn_CarIn";
            this.Btn_CarIn.Size = new System.Drawing.Size(96, 29);
            this.Btn_CarIn.TabIndex = 16;
            this.Btn_CarIn.Text = "입차";
            this.Btn_CarIn.UseVisualStyleBackColor = true;
            this.Btn_CarIn.Click += new System.EventHandler(this.Btn_CarIn_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label2.Location = new System.Drawing.Point(3, 4);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "입차 데이터";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IN_CarNumBox
            // 
            this.IN_CarNumBox.Location = new System.Drawing.Point(329, 43);
            this.IN_CarNumBox.Name = "IN_CarNumBox";
            this.IN_CarNumBox.Size = new System.Drawing.Size(64, 21);
            this.IN_CarNumBox.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.Location = new System.Drawing.Point(20, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(133, 20);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "INTERFACE_ID";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarNum
            // 
            this.CarNum.AutoSize = true;
            this.CarNum.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CarNum.Location = new System.Drawing.Point(249, 45);
            this.CarNum.Name = "CarNum";
            this.CarNum.Size = new System.Drawing.Size(74, 20);
            this.CarNum.TabIndex = 12;
            this.CarNum.Text = "CarNum";
            // 
            // IN_Interface_id_Box
            // 
            this.IN_Interface_id_Box.Location = new System.Drawing.Point(159, 44);
            this.IN_Interface_id_Box.Name = "IN_Interface_id_Box";
            this.IN_Interface_id_Box.Size = new System.Drawing.Size(66, 21);
            this.IN_Interface_id_Box.TabIndex = 11;
            // 
            // Socket_Port_Box
            // 
            this.Socket_Port_Box.Location = new System.Drawing.Point(695, 198);
            this.Socket_Port_Box.Name = "Socket_Port_Box";
            this.Socket_Port_Box.Size = new System.Drawing.Size(43, 21);
            this.Socket_Port_Box.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label5.Location = new System.Drawing.Point(576, 199);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(114, 20);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Socket_Port";
            // 
            // Socket_IP_Box
            // 
            this.Socket_IP_Box.Location = new System.Drawing.Point(482, 198);
            this.Socket_IP_Box.Name = "Socket_IP_Box";
            this.Socket_IP_Box.Size = new System.Drawing.Size(88, 21);
            this.Socket_IP_Box.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label4.Location = new System.Drawing.Point(381, 199);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(95, 20);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Socket_IP";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label3.Location = new System.Drawing.Point(213, 198);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(92, 20);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "DB_Name";
            // 
            // DB_Name_Box
            // 
            this.DB_Name_Box.Location = new System.Drawing.Point(311, 198);
            this.DB_Name_Box.Name = "DB_Name_Box";
            this.DB_Name_Box.Size = new System.Drawing.Size(64, 21);
            this.DB_Name_Box.TabIndex = 4;
            // 
            // DB_IP_Box
            // 
            this.DB_IP_Box.Location = new System.Drawing.Point(119, 198);
            this.DB_IP_Box.Name = "DB_IP_Box";
            this.DB_IP_Box.Size = new System.Drawing.Size(88, 21);
            this.DB_IP_Box.TabIndex = 2;
            // 
            // IPadress
            // 
            this.IPadress.AutoSize = true;
            this.IPadress.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IPadress.Location = new System.Drawing.Point(54, 198);
            this.IPadress.Name = "IPadress";
            this.IPadress.Size = new System.Drawing.Size(59, 20);
            this.IPadress.TabIndex = 1;
            this.IPadress.Text = "DB_IP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Socket_Port_Box);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Socket_IP_Box);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DB_Name_Box);
            this.Controls.Add(this.DB_IP_Box);
            this.Controls.Add(this.IPadress);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button Btn_CarOut;
        internal System.Windows.Forms.TextBox Empty_Weight_Box;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox OUT_CarNumBox;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox OUT_Interface_id_Box;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox Total_Weight_Box;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button Btn_CarIn;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox IN_CarNumBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label CarNum;
        internal System.Windows.Forms.TextBox IN_Interface_id_Box;
        internal System.Windows.Forms.TextBox Socket_Port_Box;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Socket_IP_Box;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox DB_Name_Box;
        internal System.Windows.Forms.TextBox DB_IP_Box;
        internal System.Windows.Forms.Label IPadress;
        private System.Windows.Forms.Button button1;
    }
}

