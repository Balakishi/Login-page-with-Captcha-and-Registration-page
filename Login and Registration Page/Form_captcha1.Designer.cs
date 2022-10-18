namespace Login_and_Registration_Page
{
    partial class Form_captcha1
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
            this.btn_result = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.btn_capctha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label_capctha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Nivea", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_result.Location = new System.Drawing.Point(507, 358);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(177, 54);
            this.btn_result.TabIndex = 9;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Nivea", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(478, 371);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 32);
            this.label_result.TabIndex = 8;
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Nivea", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_input.Location = new System.Drawing.Point(305, 357);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(185, 54);
            this.textBox_input.TabIndex = 7;
            // 
            // btn_capctha
            // 
            this.btn_capctha.Font = new System.Drawing.Font("Nivea", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capctha.Location = new System.Drawing.Point(43, 357);
            this.btn_capctha.Name = "btn_capctha";
            this.btn_capctha.Size = new System.Drawing.Size(227, 54);
            this.btn_capctha.TabIndex = 6;
            this.btn_capctha.Text = "Click";
            this.btn_capctha.UseVisualStyleBackColor = true;
            this.btn_capctha.Click += new System.EventHandler(this.btn_capctha_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login_and_Registration_Page.Properties.Resources.bg6;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.label_capctha);
            this.panel1.Location = new System.Drawing.Point(-87, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 304);
            this.panel1.TabIndex = 5;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Image = global::Login_and_Registration_Page.Properties.Resources.captcha;
            this.btn_refresh.Location = new System.Drawing.Point(812, 253);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(71, 48);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label_capctha
            // 
            this.label_capctha.AutoSize = true;
            this.label_capctha.BackColor = System.Drawing.Color.Transparent;
            this.label_capctha.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_capctha.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_capctha.ImageKey = "(none)";
            this.label_capctha.Location = new System.Drawing.Point(335, 106);
            this.label_capctha.Name = "label_capctha";
            this.label_capctha.Size = new System.Drawing.Size(0, 57);
            this.label_capctha.TabIndex = 0;
            // 
            // Form_captcha1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.btn_capctha);
            this.Controls.Add(this.panel1);
            this.Name = "Form_captcha1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button btn_capctha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label_capctha;
    }
}