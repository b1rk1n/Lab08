namespace Lab08
{
    partial class fPlanet
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtMoons = new System.Windows.Forms.TextBox();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.txtStarSystem = new System.Windows.Forms.TextBox();
            this.chkRings = new System.Windows.Forms.CheckBox();
            this.chkAtmosphere = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 195);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(153, 195);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 22);
            this.txtDiameter.TabIndex = 1;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(524, 195);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 22);
            this.txtDistance.TabIndex = 2;
            // 
            // txtMoons
            // 
            this.txtMoons.Location = new System.Drawing.Point(659, 195);
            this.txtMoons.Name = "txtMoons";
            this.txtMoons.Size = new System.Drawing.Size(100, 22);
            this.txtMoons.TabIndex = 3;
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(278, 195);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(100, 22);
            this.txtMass.TabIndex = 4;
            // 
            // txtStarSystem
            // 
            this.txtStarSystem.Location = new System.Drawing.Point(397, 195);
            this.txtStarSystem.Name = "txtStarSystem";
            this.txtStarSystem.Size = new System.Drawing.Size(100, 22);
            this.txtStarSystem.TabIndex = 5;
            // 
            // chkRings
            // 
            this.chkRings.AutoSize = true;
            this.chkRings.Location = new System.Drawing.Point(171, 270);
            this.chkRings.Name = "chkRings";
            this.chkRings.Size = new System.Drawing.Size(82, 20);
            this.chkRings.TabIndex = 6;
            this.chkRings.Text = "Є кільця";
            this.chkRings.UseVisualStyleBackColor = true;
            // 
            // chkAtmosphere
            // 
            this.chkAtmosphere.AutoSize = true;
            this.chkAtmosphere.Location = new System.Drawing.Point(421, 270);
            this.chkAtmosphere.Name = "chkAtmosphere";
            this.chkAtmosphere.Size = new System.Drawing.Size(116, 20);
            this.chkAtmosphere.TabIndex = 7;
            this.chkAtmosphere.Text = "Є атмосфера";
            this.chkAtmosphere.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(209, 351);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(462, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Назва планети";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Діаметр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Масса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Зіркова система";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дистанція від сонця";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Кільк супутників";
            // 
            // fPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkAtmosphere);
            this.Controls.Add(this.chkRings);
            this.Controls.Add(this.txtStarSystem);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.txtMoons);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtName);
            this.Name = "fPlanet";
            this.Text = "fPlanet";
            this.Load += new System.EventHandler(this.fPlanet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtMoons;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.TextBox txtStarSystem;
        private System.Windows.Forms.CheckBox chkRings;
        private System.Windows.Forms.CheckBox chkAtmosphere;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}