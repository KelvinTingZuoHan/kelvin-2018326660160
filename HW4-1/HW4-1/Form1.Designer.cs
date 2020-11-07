namespace hw4_1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.recursionDeepthText = new System.Windows.Forms.RichTextBox();
            this.recusionDeepthLabel = new System.Windows.Forms.Label();
            this.mainBranchLabel = new System.Windows.Forms.Label();
            this.rightPerLabel = new System.Windows.Forms.Label();
            this.leftAngleLabel = new System.Windows.Forms.Label();
            this.rightAngleLabel = new System.Windows.Forms.Label();
            this.leftPerLabel = new System.Windows.Forms.Label();
            this.penColorLabel = new System.Windows.Forms.Label();
            this.penColorList = new System.Windows.Forms.ListBox();
            this.mainBranchText = new System.Windows.Forms.RichTextBox();
            this.rightPerText = new System.Windows.Forms.RichTextBox();
            this.leftPerText = new System.Windows.Forms.RichTextBox();
            this.rightAngleText = new System.Windows.Forms.RichTextBox();
            this.leftAngleText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recursionDeepthText
            // 
            this.recursionDeepthText.Location = new System.Drawing.Point(150, 27);
            this.recursionDeepthText.Name = "recursionDeepthText";
            this.recursionDeepthText.Size = new System.Drawing.Size(188, 34);
            this.recursionDeepthText.TabIndex = 0;
            this.recursionDeepthText.Text = "";
            // 
            // recusionDeepthLabel
            // 
            this.recusionDeepthLabel.AutoSize = true;
            this.recusionDeepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recusionDeepthLabel.Location = new System.Drawing.Point(29, 34);
            this.recusionDeepthLabel.Name = "recusionDeepthLabel";
            this.recusionDeepthLabel.Size = new System.Drawing.Size(92, 25);
            this.recusionDeepthLabel.TabIndex = 1;
            this.recusionDeepthLabel.Text = "递归深度";
            this.recusionDeepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainBranchLabel
            // 
            this.mainBranchLabel.AutoSize = true;
            this.mainBranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainBranchLabel.Location = new System.Drawing.Point(29, 95);
            this.mainBranchLabel.Name = "mainBranchLabel";
            this.mainBranchLabel.Size = new System.Drawing.Size(92, 25);
            this.mainBranchLabel.TabIndex = 2;
            this.mainBranchLabel.Text = "主干长度";
            this.mainBranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPerLabel
            // 
            this.rightPerLabel.AutoSize = true;
            this.rightPerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightPerLabel.Location = new System.Drawing.Point(11, 153);
            this.rightPerLabel.Name = "rightPerLabel";
            this.rightPerLabel.Size = new System.Drawing.Size(132, 25);
            this.rightPerLabel.TabIndex = 4;
            this.rightPerLabel.Text = "右分支长度比";
            this.rightPerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftAngleLabel
            // 
            this.leftAngleLabel.AutoSize = true;
            this.leftAngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftAngleLabel.Location = new System.Drawing.Point(20, 335);
            this.leftAngleLabel.Name = "leftAngleLabel";
            this.leftAngleLabel.Size = new System.Drawing.Size(112, 25);
            this.leftAngleLabel.TabIndex = 10;
            this.leftAngleLabel.Text = "左分支角度";
            this.leftAngleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightAngleLabel
            // 
            this.rightAngleLabel.AutoSize = true;
            this.rightAngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightAngleLabel.Location = new System.Drawing.Point(20, 272);
            this.rightAngleLabel.Name = "rightAngleLabel";
            this.rightAngleLabel.Size = new System.Drawing.Size(112, 25);
            this.rightAngleLabel.TabIndex = 8;
            this.rightAngleLabel.Text = "右分支角度";
            this.rightAngleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPerLabel
            // 
            this.leftPerLabel.AutoSize = true;
            this.leftPerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftPerLabel.Location = new System.Drawing.Point(10, 211);
            this.leftPerLabel.Name = "leftPerLabel";
            this.leftPerLabel.Size = new System.Drawing.Size(132, 25);
            this.leftPerLabel.TabIndex = 7;
            this.leftPerLabel.Text = "左分支长度比";
            this.leftPerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // penColorLabel
            // 
            this.penColorLabel.AutoSize = true;
            this.penColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.penColorLabel.Location = new System.Drawing.Point(29, 400);
            this.penColorLabel.Name = "penColorLabel";
            this.penColorLabel.Size = new System.Drawing.Size(92, 25);
            this.penColorLabel.TabIndex = 12;
            this.penColorLabel.Text = "画笔颜色";
            this.penColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // penColorList
            // 
            this.penColorList.Font = new System.Drawing.Font("STZhongsong", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.penColorList.FormattingEnabled = true;
            this.penColorList.ItemHeight = 20;
            this.penColorList.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Green",
            "Purple",
            "Yellow"});
            this.penColorList.Location = new System.Drawing.Point(150, 400);
            this.penColorList.Name = "penColorList";
            this.penColorList.Size = new System.Drawing.Size(188, 64);
            this.penColorList.TabIndex = 13;
            // 
            // mainBranchText
            // 
            this.mainBranchText.Location = new System.Drawing.Point(150, 87);
            this.mainBranchText.Name = "mainBranchText";
            this.mainBranchText.Size = new System.Drawing.Size(188, 34);
            this.mainBranchText.TabIndex = 14;
            this.mainBranchText.Text = "";
            // 
            // rightPerText
            // 
            this.rightPerText.Location = new System.Drawing.Point(150, 146);
            this.rightPerText.Name = "rightPerText";
            this.rightPerText.Size = new System.Drawing.Size(188, 34);
            this.rightPerText.TabIndex = 15;
            this.rightPerText.Text = "";
            // 
            // leftPerText
            // 
            this.leftPerText.Location = new System.Drawing.Point(150, 204);
            this.leftPerText.Name = "leftPerText";
            this.leftPerText.Size = new System.Drawing.Size(188, 34);
            this.leftPerText.TabIndex = 16;
            this.leftPerText.Text = "";
            // 
            // rightAngleText
            // 
            this.rightAngleText.Location = new System.Drawing.Point(150, 265);
            this.rightAngleText.Name = "rightAngleText";
            this.rightAngleText.Size = new System.Drawing.Size(188, 34);
            this.rightAngleText.TabIndex = 17;
            this.rightAngleText.Text = "";
            // 
            // leftAngleText
            // 
            this.leftAngleText.Location = new System.Drawing.Point(150, 327);
            this.leftAngleText.Name = "leftAngleText";
            this.leftAngleText.Size = new System.Drawing.Size(188, 34);
            this.leftAngleText.TabIndex = 18;
            this.leftAngleText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.penColorList);
            this.groupBox1.Controls.Add(this.leftAngleText);
            this.groupBox1.Controls.Add(this.recursionDeepthText);
            this.groupBox1.Controls.Add(this.rightAngleText);
            this.groupBox1.Controls.Add(this.recusionDeepthLabel);
            this.groupBox1.Controls.Add(this.leftPerText);
            this.groupBox1.Controls.Add(this.mainBranchLabel);
            this.groupBox1.Controls.Add(this.rightPerText);
            this.groupBox1.Controls.Add(this.rightPerLabel);
            this.groupBox1.Controls.Add(this.mainBranchText);
            this.groupBox1.Controls.Add(this.leftPerLabel);
            this.groupBox1.Controls.Add(this.rightAngleLabel);
            this.groupBox1.Controls.Add(this.penColorLabel);
            this.groupBox1.Controls.Add(this.leftAngleLabel);
            this.groupBox1.Font = new System.Drawing.Font("STZhongsong", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(816, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 485);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // drawButton
            // 
            this.drawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawButton.Location = new System.Drawing.Point(946, 570);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(110, 35);
            this.drawButton.TabIndex = 20;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawPanel.Location = new System.Drawing.Point(0, 0);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(797, 635);
            this.drawPanel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 635);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox recursionDeepthText;
        private System.Windows.Forms.Label recusionDeepthLabel;
        private System.Windows.Forms.Label mainBranchLabel;
        private System.Windows.Forms.Label rightPerLabel;
        private System.Windows.Forms.Label leftAngleLabel;
        private System.Windows.Forms.Label rightAngleLabel;
        private System.Windows.Forms.Label leftPerLabel;
        private System.Windows.Forms.Label penColorLabel;
        private System.Windows.Forms.ListBox penColorList;
        private System.Windows.Forms.RichTextBox mainBranchText;
        private System.Windows.Forms.RichTextBox rightPerText;
        private System.Windows.Forms.RichTextBox leftPerText;
        private System.Windows.Forms.RichTextBox rightAngleText;
        private System.Windows.Forms.RichTextBox leftAngleText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel drawPanel;
    }
}

