
namespace File_Opener1
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
            this.FileLocationList = new System.Windows.Forms.ListBox();
            this.openfilebtn = new System.Windows.Forms.Button();
            this.addfilebtn = new System.Windows.Forms.Button();
            this.removeallbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileLocationList
            // 
            this.FileLocationList.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileLocationList.FormattingEnabled = true;
            this.FileLocationList.Location = new System.Drawing.Point(0, 0);
            this.FileLocationList.Name = "FileLocationList";
            this.FileLocationList.Size = new System.Drawing.Size(570, 277);
            this.FileLocationList.TabIndex = 0;
            this.FileLocationList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileLocationList_MouseDoubleClick);
            // 
            // openfilebtn
            // 
            this.openfilebtn.Location = new System.Drawing.Point(0, 283);
            this.openfilebtn.Name = "openfilebtn";
            this.openfilebtn.Size = new System.Drawing.Size(568, 23);
            this.openfilebtn.TabIndex = 1;
            this.openfilebtn.Text = "OPEN";
            this.openfilebtn.UseVisualStyleBackColor = true;
            this.openfilebtn.Click += new System.EventHandler(this.openfilebtn_Click);
            // 
            // addfilebtn
            // 
            this.addfilebtn.Location = new System.Drawing.Point(1, 309);
            this.addfilebtn.Name = "addfilebtn";
            this.addfilebtn.Size = new System.Drawing.Size(468, 23);
            this.addfilebtn.TabIndex = 2;
            this.addfilebtn.Text = "ADD";
            this.addfilebtn.UseVisualStyleBackColor = true;
            this.addfilebtn.Click += new System.EventHandler(this.addfilebtn_Click);
            // 
            // removeallbtn
            // 
            this.removeallbtn.Location = new System.Drawing.Point(475, 309);
            this.removeallbtn.Name = "removeallbtn";
            this.removeallbtn.Size = new System.Drawing.Size(93, 23);
            this.removeallbtn.TabIndex = 3;
            this.removeallbtn.Text = "REMOVE LIST";
            this.removeallbtn.UseVisualStyleBackColor = true;
            this.removeallbtn.Click += new System.EventHandler(this.removeallbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 334);
            this.Controls.Add(this.removeallbtn);
            this.Controls.Add(this.addfilebtn);
            this.Controls.Add(this.openfilebtn);
            this.Controls.Add(this.FileLocationList);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File Opener";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FileLocationList;
        private System.Windows.Forms.Button openfilebtn;
        private System.Windows.Forms.Button addfilebtn;
        private System.Windows.Forms.Button removeallbtn;
    }
}

