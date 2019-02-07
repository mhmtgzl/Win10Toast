namespace Win10Toast
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRun = new System.Windows.Forms.Button();
            this.rdHorizontal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdVertical = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTopLeft = new System.Windows.Forms.RadioButton();
            this.rdBottomLeft = new System.Windows.Forms.RadioButton();
            this.rdBottomRight = new System.Windows.Forms.RadioButton();
            this.rdTopRight = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdQuestion = new System.Windows.Forms.RadioButton();
            this.rdError = new System.Windows.Forms.RadioButton();
            this.rdInfo = new System.Windows.Forms.RadioButton();
            this.rdWarning = new System.Windows.Forms.RadioButton();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(54, 225);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(250, 34);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdHorizontal
            // 
            this.rdHorizontal.AutoSize = true;
            this.rdHorizontal.Location = new System.Drawing.Point(24, 53);
            this.rdHorizontal.Name = "rdHorizontal";
            this.rdHorizontal.Size = new System.Drawing.Size(72, 17);
            this.rdHorizontal.TabIndex = 1;
            this.rdHorizontal.Text = "Horizontal";
            this.rdHorizontal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdVertical);
            this.groupBox1.Controls.Add(this.rdHorizontal);
            this.groupBox1.Location = new System.Drawing.Point(273, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rdVertical
            // 
            this.rdVertical.AutoSize = true;
            this.rdVertical.Checked = true;
            this.rdVertical.Location = new System.Drawing.Point(24, 30);
            this.rdVertical.Name = "rdVertical";
            this.rdVertical.Size = new System.Drawing.Size(60, 17);
            this.rdVertical.TabIndex = 2;
            this.rdVertical.TabStop = true;
            this.rdVertical.Text = "Vertical";
            this.rdVertical.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTopLeft);
            this.groupBox2.Controls.Add(this.rdBottomLeft);
            this.groupBox2.Controls.Add(this.rdBottomRight);
            this.groupBox2.Controls.Add(this.rdTopRight);
            this.groupBox2.Location = new System.Drawing.Point(397, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 171);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position";
            // 
            // rdTopLeft
            // 
            this.rdTopLeft.AutoSize = true;
            this.rdTopLeft.Location = new System.Drawing.Point(24, 76);
            this.rdTopLeft.Name = "rdTopLeft";
            this.rdTopLeft.Size = new System.Drawing.Size(65, 17);
            this.rdTopLeft.TabIndex = 4;
            this.rdTopLeft.Text = "Top Left";
            this.rdTopLeft.UseVisualStyleBackColor = true;
            // 
            // rdBottomLeft
            // 
            this.rdBottomLeft.AutoSize = true;
            this.rdBottomLeft.Location = new System.Drawing.Point(24, 99);
            this.rdBottomLeft.Name = "rdBottomLeft";
            this.rdBottomLeft.Size = new System.Drawing.Size(79, 17);
            this.rdBottomLeft.TabIndex = 3;
            this.rdBottomLeft.Text = "Bottom Left";
            this.rdBottomLeft.UseVisualStyleBackColor = true;
            // 
            // rdBottomRight
            // 
            this.rdBottomRight.AutoSize = true;
            this.rdBottomRight.Checked = true;
            this.rdBottomRight.Location = new System.Drawing.Point(24, 30);
            this.rdBottomRight.Name = "rdBottomRight";
            this.rdBottomRight.Size = new System.Drawing.Size(86, 17);
            this.rdBottomRight.TabIndex = 2;
            this.rdBottomRight.TabStop = true;
            this.rdBottomRight.Text = "Bottom Right";
            this.rdBottomRight.UseVisualStyleBackColor = true;
            // 
            // rdTopRight
            // 
            this.rdTopRight.AutoSize = true;
            this.rdTopRight.Location = new System.Drawing.Point(24, 53);
            this.rdTopRight.Name = "rdTopRight";
            this.rdTopRight.Size = new System.Drawing.Size(72, 17);
            this.rdTopRight.TabIndex = 1;
            this.rdTopRight.Text = "Top Right";
            this.rdTopRight.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(54, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(190, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(54, 47);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desc.";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(54, 73);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(190, 20);
            this.txtLink.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Link";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdQuestion);
            this.groupBox3.Controls.Add(this.rdError);
            this.groupBox3.Controls.Add(this.rdInfo);
            this.groupBox3.Controls.Add(this.rdWarning);
            this.groupBox3.Location = new System.Drawing.Point(54, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 84);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // rdQuestion
            // 
            this.rdQuestion.AutoSize = true;
            this.rdQuestion.Location = new System.Drawing.Point(119, 30);
            this.rdQuestion.Name = "rdQuestion";
            this.rdQuestion.Size = new System.Drawing.Size(67, 17);
            this.rdQuestion.TabIndex = 4;
            this.rdQuestion.Text = "Question";
            this.rdQuestion.UseVisualStyleBackColor = true;
            // 
            // rdError
            // 
            this.rdError.AutoSize = true;
            this.rdError.Location = new System.Drawing.Point(119, 53);
            this.rdError.Name = "rdError";
            this.rdError.Size = new System.Drawing.Size(47, 17);
            this.rdError.TabIndex = 3;
            this.rdError.Text = "Error";
            this.rdError.UseVisualStyleBackColor = true;
            // 
            // rdInfo
            // 
            this.rdInfo.AutoSize = true;
            this.rdInfo.Checked = true;
            this.rdInfo.Location = new System.Drawing.Point(24, 30);
            this.rdInfo.Name = "rdInfo";
            this.rdInfo.Size = new System.Drawing.Size(43, 17);
            this.rdInfo.TabIndex = 2;
            this.rdInfo.TabStop = true;
            this.rdInfo.Text = "Info";
            this.rdInfo.UseVisualStyleBackColor = true;
            // 
            // rdWarning
            // 
            this.rdWarning.AutoSize = true;
            this.rdWarning.Location = new System.Drawing.Point(24, 53);
            this.rdWarning.Name = "rdWarning";
            this.rdWarning.Size = new System.Drawing.Size(65, 17);
            this.rdWarning.TabIndex = 1;
            this.rdWarning.Text = "Warning";
            this.rdWarning.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(54, 189);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(46, 20);
            this.txtTime.TabIndex = 12;
            this.txtTime.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "second";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notify";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rdHorizontal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdVertical;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTopLeft;
        private System.Windows.Forms.RadioButton rdBottomLeft;
        private System.Windows.Forms.RadioButton rdBottomRight;
        private System.Windows.Forms.RadioButton rdTopRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdQuestion;
        private System.Windows.Forms.RadioButton rdError;
        private System.Windows.Forms.RadioButton rdInfo;
        private System.Windows.Forms.RadioButton rdWarning;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

