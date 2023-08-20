namespace cart
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.back_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.browse_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(348, 553);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(13, 13);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(66, 28);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(87, 91);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(177, 60);
            this.home_btn.TabIndex = 2;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(87, 263);
            this.browse_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(177, 60);
            this.browse_btn.TabIndex = 3;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            // 
            // profile_btn
            // 
            this.profile_btn.Location = new System.Drawing.Point(87, 444);
            this.profile_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(177, 60);
            this.profile_btn.TabIndex = 4;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.profile_btn);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "The Foodie Zone";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button profile_btn;
    }
}

