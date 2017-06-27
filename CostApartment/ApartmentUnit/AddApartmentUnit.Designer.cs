namespace CostApartment.ApartmentUnit
{
    partial class AddApartmentUnit
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_UnitApartment = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_metr = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txt_Meter = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(372, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Name.Size = new System.Drawing.Size(23, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "نام:";
            // 
            // lbl_UnitApartment
            // 
            this.lbl_UnitApartment.AutoSize = true;
            this.lbl_UnitApartment.Location = new System.Drawing.Point(372, 38);
            this.lbl_UnitApartment.Name = "lbl_UnitApartment";
            this.lbl_UnitApartment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_UnitApartment.Size = new System.Drawing.Size(31, 13);
            this.lbl_UnitApartment.TabIndex = 1;
            this.lbl_UnitApartment.Text = "واحد:";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(372, 67);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Count.Size = new System.Drawing.Size(33, 13);
            this.lbl_Count.TabIndex = 2;
            this.lbl_Count.Text = "تعداد:";
            // 
            // lbl_metr
            // 
            this.lbl_metr.AutoSize = true;
            this.lbl_metr.Location = new System.Drawing.Point(372, 93);
            this.lbl_metr.Name = "lbl_metr";
            this.lbl_metr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_metr.Size = new System.Drawing.Size(32, 13);
            this.lbl_metr.TabIndex = 3;
            this.lbl_metr.Text = "متراژ:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(145, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(221, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_unit
            // 
            this.txt_unit.Location = new System.Drawing.Point(145, 38);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(221, 20);
            this.txt_unit.TabIndex = 5;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(145, 64);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(221, 20);
            this.txt_Count.TabIndex = 6;
            this.txt_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Count_KeyPress);
            // 
            // txt_Meter
            // 
            this.txt_Meter.Location = new System.Drawing.Point(145, 90);
            this.txt_Meter.Name = "txt_Meter";
            this.txt_Meter.Size = new System.Drawing.Size(221, 20);
            this.txt_Meter.TabIndex = 7;
            this.txt_Meter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Meter_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(291, 116);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "ذخیره";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(145, 116);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "رد";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // AddApartmentUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 302);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Meter);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_unit);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_metr);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.lbl_UnitApartment);
            this.Controls.Add(this.lbl_Name);
            this.Name = "AddApartmentUnit";
            this.Text = "افزودن واحد آپارتمان";
            this.Load += new System.EventHandler(this.AddApartmentUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_UnitApartment;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_metr;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.TextBox txt_Meter;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}