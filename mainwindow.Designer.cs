namespace test1
{
    partial class Test
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Load_file = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load_file
            // 
            this.Load_file.Location = new System.Drawing.Point(12, 12);
            this.Load_file.Name = "Load_file";
            this.Load_file.Size = new System.Drawing.Size(75, 23);
            this.Load_file.TabIndex = 0;
            this.Load_file.Text = "Loading File";
            this.Load_file.UseVisualStyleBackColor = true;
            this.Load_file.Click += new System.EventHandler(this.Load_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(93, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(479, 387);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(12, 41);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(12, 70);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Load_file);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Test";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "File Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_file;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button savebtn;
    }
}

