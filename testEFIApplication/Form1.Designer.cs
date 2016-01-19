namespace testEFIApplication
{
    partial class Form1
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblBus = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblFunction = new System.Windows.Forms.Label();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtRegister1 = new System.Windows.Forms.TextBox();
            this.txtRegister2 = new System.Windows.Forms.TextBox();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(12, 21);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(49, 13);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Register:";
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Location = new System.Drawing.Point(12, 61);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(28, 13);
            this.lblBus.TabIndex = 1;
            this.lblBus.Text = "Bus:";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(83, 61);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(44, 13);
            this.lblDevice.TabIndex = 2;
            this.lblDevice.Text = "Device:";
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(173, 61);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(51, 13);
            this.lblFunction.TabIndex = 3;
            this.lblFunction.Text = "Function:";
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(12, 103);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(38, 13);
            this.lblOffset.TabIndex = 4;
            this.lblOffset.Text = "Offset:";
            // 
            // txtRegister1
            // 
            this.txtRegister1.Location = new System.Drawing.Point(63, 18);
            this.txtRegister1.Name = "txtRegister1";
            this.txtRegister1.Size = new System.Drawing.Size(41, 20);
            this.txtRegister1.TabIndex = 5;
            // 
            // txtRegister2
            // 
            this.txtRegister2.Location = new System.Drawing.Point(110, 18);
            this.txtRegister2.Name = "txtRegister2";
            this.txtRegister2.Size = new System.Drawing.Size(41, 20);
            this.txtRegister2.TabIndex = 6;
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(40, 58);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(41, 20);
            this.txtBus.TabIndex = 7;
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(126, 58);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(41, 20);
            this.txtDevice.TabIndex = 8;
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(230, 58);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(41, 20);
            this.txtFunction.TabIndex = 9;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(54, 100);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(41, 20);
            this.txtOffset.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 147);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.txtRegister2);
            this.Controls.Add(this.txtRegister1);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.lblBus);
            this.Controls.Add(this.lblRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox txtRegister1;
        private System.Windows.Forms.TextBox txtRegister2;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Button btnCalculate;
    }
}

