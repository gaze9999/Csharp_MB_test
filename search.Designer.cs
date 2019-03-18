namespace test1
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Cncbtn = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            resources.ApplyResources(this.TextBox1, "TextBox1");
            this.TextBox1.Name = "TextBox1";
            // 
            // Cncbtn
            // 
            this.Cncbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Cncbtn, "Cncbtn");
            this.Cncbtn.Name = "Cncbtn";
            this.Cncbtn.UseVisualStyleBackColor = true;
            this.Cncbtn.Click += new System.EventHandler(this.Cncbtn_Click);
            // 
            // Okbtn
            // 
            this.Okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.Okbtn, "Okbtn");
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // search
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.Cncbtn);
            this.Controls.Add(this.TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "search";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Cncbtn;
        private System.Windows.Forms.Button Okbtn;
    }
}