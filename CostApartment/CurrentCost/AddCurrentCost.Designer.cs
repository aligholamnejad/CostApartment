namespace CostApartment.CurrentCost
{
    partial class AddCurrentCost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Term = new System.Windows.Forms.ComboBox();
            this.txt_waterCost = new System.Windows.Forms.TextBox();
            this.txt_electricityCost = new System.Windows.Forms.TextBox();
            this.txt_gasCost = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "دوره ی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "هزینه ی آب:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "هزینه ی برق:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "هزینه ی گاز:";
            // 
            // cmb_Term
            // 
            this.cmb_Term.FormattingEnabled = true;
            this.cmb_Term.Location = new System.Drawing.Point(84, 9);
            this.cmb_Term.Name = "cmb_Term";
            this.cmb_Term.Size = new System.Drawing.Size(264, 21);
            this.cmb_Term.TabIndex = 4;
            // 
            // txt_waterCost
            // 
            this.txt_waterCost.Location = new System.Drawing.Point(84, 36);
            this.txt_waterCost.Name = "txt_waterCost";
            this.txt_waterCost.Size = new System.Drawing.Size(264, 20);
            this.txt_waterCost.TabIndex = 5;
            // 
            // txt_electricityCost
            // 
            this.txt_electricityCost.Location = new System.Drawing.Point(84, 62);
            this.txt_electricityCost.Name = "txt_electricityCost";
            this.txt_electricityCost.Size = new System.Drawing.Size(264, 20);
            this.txt_electricityCost.TabIndex = 6;
            // 
            // txt_gasCost
            // 
            this.txt_gasCost.Location = new System.Drawing.Point(84, 88);
            this.txt_gasCost.Name = "txt_gasCost";
            this.txt_gasCost.Size = new System.Drawing.Size(264, 20);
            this.txt_gasCost.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(85, 115);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "ذخیره";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(273, 115);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "رد";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // AddCurrentCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 466);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_gasCost);
            this.Controls.Add(this.txt_electricityCost);
            this.Controls.Add(this.txt_waterCost);
            this.Controls.Add(this.cmb_Term);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCurrentCost";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "افزودن هزینه ی جاری";
            this.Load += new System.EventHandler(this.AddCurrentCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Term;
        private System.Windows.Forms.TextBox txt_waterCost;
        private System.Windows.Forms.TextBox txt_electricityCost;
        private System.Windows.Forms.TextBox txt_gasCost;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}