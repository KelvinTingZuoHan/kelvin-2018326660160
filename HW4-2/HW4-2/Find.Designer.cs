namespace HW4_2 {
    partial class Find {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalPrice_sign = new System.Windows.Forms.ListBox();
            this.num_sign = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitPrice_text = new System.Windows.Forms.RichTextBox();
            this.buyer_text = new System.Windows.Forms.RichTextBox();
            this.objID_label = new System.Windows.Forms.Label();
            this.num_text = new System.Windows.Forms.RichTextBox();
            this.objName_label = new System.Windows.Forms.Label();
            this.supplier_label = new System.Windows.Forms.Label();
            this.objName_text = new System.Windows.Forms.RichTextBox();
            this.objID_text = new System.Windows.Forms.RichTextBox();
            this.buyer_label = new System.Windows.Forms.Label();
            this.supllier_text = new System.Windows.Forms.RichTextBox();
            this.unitPrice_label = new System.Windows.Forms.Label();
            this.num_label = new System.Windows.Forms.Label();
            this.totalPrce_label = new System.Windows.Forms.Label();
            this.totalPrice_text = new System.Windows.Forms.RichTextBox();
            this.unitPrice_sign = new System.Windows.Forms.ListBox();
            this.add_text = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.totalPrice_sign, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.num_sign, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.unitPrice_text, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buyer_text, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.objID_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.num_text, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.objName_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.supplier_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.objName_text, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.objID_text, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buyer_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.supllier_text, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.unitPrice_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.num_label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.totalPrce_label, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.totalPrice_text, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.unitPrice_sign, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(143, 112);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 331);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // totalPrice_sign
            // 
            this.totalPrice_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice_sign.FormattingEnabled = true;
            this.totalPrice_sign.ItemHeight = 25;
            this.totalPrice_sign.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<="});
            this.totalPrice_sign.Location = new System.Drawing.Point(265, 286);
            this.totalPrice_sign.Margin = new System.Windows.Forms.Padding(4);
            this.totalPrice_sign.Name = "totalPrice_sign";
            this.totalPrice_sign.Size = new System.Drawing.Size(251, 29);
            this.totalPrice_sign.TabIndex = 38;
            // 
            // num_sign
            // 
            this.num_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_sign.FormattingEnabled = true;
            this.num_sign.ItemHeight = 25;
            this.num_sign.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<="});
            this.num_sign.Location = new System.Drawing.Point(265, 239);
            this.num_sign.Margin = new System.Windows.Forms.Padding(4);
            this.num_sign.Name = "num_sign";
            this.num_sign.Size = new System.Drawing.Size(251, 29);
            this.num_sign.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(265, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(265, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 37);
            this.label4.TabIndex = 32;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(265, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(265, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitPrice_text
            // 
            this.unitPrice_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_text.Location = new System.Drawing.Point(526, 192);
            this.unitPrice_text.Margin = new System.Windows.Forms.Padding(4);
            this.unitPrice_text.Name = "unitPrice_text";
            this.unitPrice_text.Size = new System.Drawing.Size(253, 38);
            this.unitPrice_text.TabIndex = 24;
            this.unitPrice_text.Text = "";
            // 
            // buyer_text
            // 
            this.buyer_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyer_text.Location = new System.Drawing.Point(526, 145);
            this.buyer_text.Margin = new System.Windows.Forms.Padding(4);
            this.buyer_text.Name = "buyer_text";
            this.buyer_text.Size = new System.Drawing.Size(253, 38);
            this.buyer_text.TabIndex = 23;
            this.buyer_text.Text = "";
            // 
            // objID_label
            // 
            this.objID_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.objID_label.AutoSize = true;
            this.objID_label.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objID_label.ForeColor = System.Drawing.Color.Black;
            this.objID_label.Location = new System.Drawing.Point(75, 0);
            this.objID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objID_label.Name = "objID_label";
            this.objID_label.Size = new System.Drawing.Size(110, 22);
            this.objID_label.TabIndex = 15;
            this.objID_label.Text = "Object ID:";
            this.objID_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_text
            // 
            this.num_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_text.Location = new System.Drawing.Point(526, 239);
            this.num_text.Margin = new System.Windows.Forms.Padding(4);
            this.num_text.Name = "num_text";
            this.num_text.Size = new System.Drawing.Size(253, 38);
            this.num_text.TabIndex = 25;
            this.num_text.Text = "";
            // 
            // objName_label
            // 
            this.objName_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.objName_label.AutoSize = true;
            this.objName_label.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objName_label.ForeColor = System.Drawing.Color.Black;
            this.objName_label.Location = new System.Drawing.Point(65, 47);
            this.objName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objName_label.Name = "objName_label";
            this.objName_label.Size = new System.Drawing.Size(130, 22);
            this.objName_label.TabIndex = 14;
            this.objName_label.Text = "Object name:";
            this.objName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supplier_label
            // 
            this.supplier_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.supplier_label.AutoSize = true;
            this.supplier_label.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_label.ForeColor = System.Drawing.Color.Black;
            this.supplier_label.Location = new System.Drawing.Point(80, 94);
            this.supplier_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplier_label.Name = "supplier_label";
            this.supplier_label.Size = new System.Drawing.Size(100, 22);
            this.supplier_label.TabIndex = 16;
            this.supplier_label.Text = "Supplier:";
            this.supplier_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objName_text
            // 
            this.objName_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objName_text.Location = new System.Drawing.Point(526, 51);
            this.objName_text.Margin = new System.Windows.Forms.Padding(4);
            this.objName_text.Name = "objName_text";
            this.objName_text.Size = new System.Drawing.Size(253, 38);
            this.objName_text.TabIndex = 21;
            this.objName_text.Text = "";
            // 
            // objID_text
            // 
            this.objID_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objID_text.Location = new System.Drawing.Point(526, 4);
            this.objID_text.Margin = new System.Windows.Forms.Padding(4);
            this.objID_text.Name = "objID_text";
            this.objID_text.Size = new System.Drawing.Size(253, 38);
            this.objID_text.TabIndex = 20;
            this.objID_text.Text = "";
            // 
            // buyer_label
            // 
            this.buyer_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buyer_label.AutoSize = true;
            this.buyer_label.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyer_label.ForeColor = System.Drawing.Color.Black;
            this.buyer_label.Location = new System.Drawing.Point(95, 141);
            this.buyer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyer_label.Name = "buyer_label";
            this.buyer_label.Size = new System.Drawing.Size(70, 22);
            this.buyer_label.TabIndex = 17;
            this.buyer_label.Text = "Buyer:";
            this.buyer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supllier_text
            // 
            this.supllier_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supllier_text.Location = new System.Drawing.Point(526, 98);
            this.supllier_text.Margin = new System.Windows.Forms.Padding(4);
            this.supllier_text.Name = "supllier_text";
            this.supllier_text.Size = new System.Drawing.Size(253, 38);
            this.supllier_text.TabIndex = 22;
            this.supllier_text.Text = "";
            // 
            // unitPrice_label
            // 
            this.unitPrice_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unitPrice_label.AutoSize = true;
            this.unitPrice_label.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_label.ForeColor = System.Drawing.Color.Black;
            this.unitPrice_label.Location = new System.Drawing.Point(70, 188);
            this.unitPrice_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitPrice_label.Name = "unitPrice_label";
            this.unitPrice_label.Size = new System.Drawing.Size(120, 22);
            this.unitPrice_label.TabIndex = 18;
            this.unitPrice_label.Text = "Unit price:";
            this.unitPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_label
            // 
            this.num_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.num_label.AutoSize = true;
            this.num_label.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_label.ForeColor = System.Drawing.Color.Black;
            this.num_label.Location = new System.Drawing.Point(90, 235);
            this.num_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(80, 22);
            this.num_label.TabIndex = 19;
            this.num_label.Text = "Number:";
            this.num_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPrce_label
            // 
            this.totalPrce_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalPrce_label.AutoSize = true;
            this.totalPrce_label.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrce_label.ForeColor = System.Drawing.Color.Black;
            this.totalPrce_label.Location = new System.Drawing.Point(65, 282);
            this.totalPrce_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPrce_label.Name = "totalPrce_label";
            this.totalPrce_label.Size = new System.Drawing.Size(130, 22);
            this.totalPrce_label.TabIndex = 28;
            this.totalPrce_label.Text = "Total price:";
            this.totalPrce_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPrice_text
            // 
            this.totalPrice_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice_text.Location = new System.Drawing.Point(526, 286);
            this.totalPrice_text.Margin = new System.Windows.Forms.Padding(4);
            this.totalPrice_text.Name = "totalPrice_text";
            this.totalPrice_text.Size = new System.Drawing.Size(253, 38);
            this.totalPrice_text.TabIndex = 30;
            this.totalPrice_text.Text = "";
            // 
            // unitPrice_sign
            // 
            this.unitPrice_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_sign.FormattingEnabled = true;
            this.unitPrice_sign.ItemHeight = 25;
            this.unitPrice_sign.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<="});
            this.unitPrice_sign.Location = new System.Drawing.Point(265, 192);
            this.unitPrice_sign.Margin = new System.Windows.Forms.Padding(4);
            this.unitPrice_sign.Name = "unitPrice_sign";
            this.unitPrice_sign.Size = new System.Drawing.Size(251, 29);
            this.unitPrice_sign.TabIndex = 36;
            // 
            // add_text
            // 
            this.add_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_text.AutoSize = true;
            this.add_text.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_text.ForeColor = System.Drawing.Color.Black;
            this.add_text.Location = new System.Drawing.Point(417, 26);
            this.add_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_text.Name = "add_text";
            this.add_text.Size = new System.Drawing.Size(241, 37);
            this.add_text.TabIndex = 24;
            this.add_text.Text = "Find an order:";
            this.add_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(16, 474);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(1035, 52);
            this.confirm_btn.TabIndex = 25;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.add_text);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Find";
            this.Text = "Find";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label objID_label;
        private System.Windows.Forms.Label objName_label;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.Label buyer_label;
        private System.Windows.Forms.Label unitPrice_label;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.RichTextBox unitPrice_text;
        private System.Windows.Forms.RichTextBox buyer_text;
        private System.Windows.Forms.RichTextBox num_text;
        private System.Windows.Forms.RichTextBox objName_text;
        private System.Windows.Forms.RichTextBox objID_text;
        private System.Windows.Forms.RichTextBox supllier_text;
        private System.Windows.Forms.Label totalPrce_label;
        private System.Windows.Forms.RichTextBox totalPrice_text;
        private System.Windows.Forms.Label add_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.ListBox unitPrice_sign;
        private System.Windows.Forms.ListBox totalPrice_sign;
        private System.Windows.Forms.ListBox num_sign;
    }
}