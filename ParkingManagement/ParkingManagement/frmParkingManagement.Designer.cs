namespace ParkingManagement
{
    partial class frmParkingManagement
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnIn1 = new System.Windows.Forms.Button();
            this.btnOut1 = new System.Windows.Forms.Button();
            this.lblIn1 = new System.Windows.Forms.Label();
            this.lblOut1 = new System.Windows.Forms.Label();
            this.gb1_1 = new System.Windows.Forms.GroupBox();
            this.lblSum1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaseMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.lblNowTime = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.gb1_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.gb1_1);
            this.gb1.Controls.Add(this.lblOut1);
            this.gb1.Controls.Add(this.lblIn1);
            this.gb1.Controls.Add(this.btnOut1);
            this.gb1.Controls.Add(this.btnIn1);
            this.gb1.Location = new System.Drawing.Point(12, 75);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(346, 145);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "1번";
            // 
            // btnIn1
            // 
            this.btnIn1.Location = new System.Drawing.Point(23, 33);
            this.btnIn1.Name = "btnIn1";
            this.btnIn1.Size = new System.Drawing.Size(75, 23);
            this.btnIn1.TabIndex = 0;
            this.btnIn1.Text = "입고";
            this.btnIn1.UseVisualStyleBackColor = true;
            this.btnIn1.Click += new System.EventHandler(this.btnIn1_Click);
            // 
            // btnOut1
            // 
            this.btnOut1.Location = new System.Drawing.Point(23, 86);
            this.btnOut1.Name = "btnOut1";
            this.btnOut1.Size = new System.Drawing.Size(75, 23);
            this.btnOut1.TabIndex = 1;
            this.btnOut1.Text = "출고";
            this.btnOut1.UseVisualStyleBackColor = true;
            this.btnOut1.Click += new System.EventHandler(this.btnOut1_Click);
            // 
            // lblIn1
            // 
            this.lblIn1.AutoSize = true;
            this.lblIn1.Location = new System.Drawing.Point(126, 37);
            this.lblIn1.Name = "lblIn1";
            this.lblIn1.Size = new System.Drawing.Size(0, 15);
            this.lblIn1.TabIndex = 2;
            // 
            // lblOut1
            // 
            this.lblOut1.AutoSize = true;
            this.lblOut1.Location = new System.Drawing.Point(126, 90);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(0, 15);
            this.lblOut1.TabIndex = 3;
            // 
            // gb1_1
            // 
            this.gb1_1.Controls.Add(this.lblSum1);
            this.gb1_1.Location = new System.Drawing.Point(209, 33);
            this.gb1_1.Name = "gb1_1";
            this.gb1_1.Size = new System.Drawing.Size(131, 76);
            this.gb1_1.TabIndex = 1;
            this.gb1_1.TabStop = false;
            this.gb1_1.Text = "현재금액";
            // 
            // lblSum1
            // 
            this.lblSum1.AutoSize = true;
            this.lblSum1.Location = new System.Drawing.Point(18, 36);
            this.lblSum1.Name = "lblSum1";
            this.lblSum1.Size = new System.Drawing.Size(0, 15);
            this.lblSum1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNowTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBaseMoney);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBaseTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "단위시간";
            // 
            // txtBaseTime
            // 
            this.txtBaseTime.Location = new System.Drawing.Point(77, 23);
            this.txtBaseTime.Name = "txtBaseTime";
            this.txtBaseTime.Size = new System.Drawing.Size(49, 22);
            this.txtBaseTime.TabIndex = 1;
            this.txtBaseTime.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "금액";
            // 
            // txtBaseMoney
            // 
            this.txtBaseMoney.Location = new System.Drawing.Point(241, 23);
            this.txtBaseMoney.Name = "txtBaseMoney";
            this.txtBaseMoney.Size = new System.Drawing.Size(67, 22);
            this.txtBaseMoney.TabIndex = 3;
            this.txtBaseMoney.Text = "2000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "분";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "원";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // lblNowTime
            // 
            this.lblNowTime.AutoSize = true;
            this.lblNowTime.Location = new System.Drawing.Point(388, 26);
            this.lblNowTime.Name = "lblNowTime";
            this.lblNowTime.Size = new System.Drawing.Size(0, 15);
            this.lblNowTime.TabIndex = 6;
            // 
            // frmParkingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 237);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Name = "frmParkingManagement";
            this.Text = "주차관리시스템";
            this.Load += new System.EventHandler(this.frmParkingManagement_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb1_1.ResumeLayout(false);
            this.gb1_1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb1_1;
        private System.Windows.Forms.Label lblSum1;
        private System.Windows.Forms.Label lblOut1;
        private System.Windows.Forms.Label lblIn1;
        private System.Windows.Forms.Button btnOut1;
        private System.Windows.Forms.Button btnIn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaseMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaseTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label lblNowTime;
    }
}

