namespace Campchon
{
    partial class Main
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCamp = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.gbReservation = new System.Windows.Forms.GroupBox();
            this.lbReservation = new System.Windows.Forms.ListBox();
            this.cbAsync = new System.Windows.Forms.CheckBox();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStartReservation = new System.Windows.Forms.Button();
            this.gbLog.SuspendLayout();
            this.gbReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(207, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "＃ 캠핑장";
            // 
            // lbCamp
            // 
            this.lbCamp.FormattingEnabled = true;
            this.lbCamp.ItemHeight = 12;
            this.lbCamp.Location = new System.Drawing.Point(12, 29);
            this.lbCamp.Name = "lbCamp";
            this.lbCamp.Size = new System.Drawing.Size(183, 148);
            this.lbCamp.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(9, 183);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(418, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "예약추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(9, 339);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(418, 104);
            this.gbLog.TabIndex = 28;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "로그";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(6, 20);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(406, 74);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // gbReservation
            // 
            this.gbReservation.Controls.Add(this.lbReservation);
            this.gbReservation.Controls.Add(this.cbAsync);
            this.gbReservation.Controls.Add(this.numInterval);
            this.gbReservation.Controls.Add(this.btnDelete);
            this.gbReservation.Controls.Add(this.btnStartReservation);
            this.gbReservation.Location = new System.Drawing.Point(9, 212);
            this.gbReservation.Name = "gbReservation";
            this.gbReservation.Size = new System.Drawing.Size(418, 118);
            this.gbReservation.TabIndex = 27;
            this.gbReservation.TabStop = false;
            this.gbReservation.Text = "예약";
            // 
            // lbReservation
            // 
            this.lbReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReservation.FormattingEnabled = true;
            this.lbReservation.ItemHeight = 12;
            this.lbReservation.Location = new System.Drawing.Point(7, 20);
            this.lbReservation.Name = "lbReservation";
            this.lbReservation.Size = new System.Drawing.Size(405, 64);
            this.lbReservation.TabIndex = 17;
            // 
            // cbAsync
            // 
            this.cbAsync.AutoSize = true;
            this.cbAsync.Location = new System.Drawing.Point(380, 144);
            this.cbAsync.Name = "cbAsync";
            this.cbAsync.Size = new System.Drawing.Size(60, 16);
            this.cbAsync.TabIndex = 16;
            this.cbAsync.Text = "비동기";
            this.cbAsync.UseVisualStyleBackColor = true;
            // 
            // numInterval
            // 
            this.numInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numInterval.Location = new System.Drawing.Point(286, 90);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(44, 21);
            this.numInterval.TabIndex = 14;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(6, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "선택삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnStartReservation
            // 
            this.btnStartReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartReservation.Location = new System.Drawing.Point(337, 89);
            this.btnStartReservation.Name = "btnStartReservation";
            this.btnStartReservation.Size = new System.Drawing.Size(75, 23);
            this.btnStartReservation.TabIndex = 12;
            this.btnStartReservation.Text = "예약시작";
            this.btnStartReservation.UseVisualStyleBackColor = true;
            this.btnStartReservation.Click += new System.EventHandler(this.btnStartReservation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 455);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbReservation);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCamp);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Main";
            this.Text = "캠프촌";
            this.gbLog.ResumeLayout(false);
            this.gbReservation.ResumeLayout(false);
            this.gbReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCamp;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.GroupBox gbReservation;
        private System.Windows.Forms.ListBox lbReservation;
        private System.Windows.Forms.CheckBox cbAsync;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStartReservation;
    }
}

