namespace HW4_2 {
    partial class warning {
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
            this.warning_title = new System.Windows.Forms.Label();
            this.warning_text = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // warning_title
            // 
            this.warning_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warning_title.AutoSize = true;
            this.warning_title.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_title.ForeColor = System.Drawing.Color.Crimson;
            this.warning_title.Location = new System.Drawing.Point(4, 0);
            this.warning_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning_title.Name = "warning_title";
            this.warning_title.Size = new System.Drawing.Size(607, 37);
            this.warning_title.TabIndex = 11;
            this.warning_title.Text = "Warning!";
            this.warning_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warning_text
            // 
            this.warning_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warning_text.AutoSize = true;
            this.warning_text.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_text.ForeColor = System.Drawing.Color.Black;
            this.warning_text.Location = new System.Drawing.Point(4, 109);
            this.warning_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning_text.Name = "warning_text";
            this.warning_text.Size = new System.Drawing.Size(607, 110);
            this.warning_text.TabIndex = 12;
            this.warning_text.Text = "Warning!";
            this.warning_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.warning_title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.warning_text, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 219);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "warning";
            this.Text = "warning";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label warning_title;
        private System.Windows.Forms.Label warning_text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}