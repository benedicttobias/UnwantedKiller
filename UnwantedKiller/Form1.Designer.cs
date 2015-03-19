namespace UnwantedKiller
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
            this.label1 = new System.Windows.Forms.Label();
            this.extensionTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extension";
            // 
            // extensionTextbox
            // 
            this.extensionTextbox.Location = new System.Drawing.Point(71, 9);
            this.extensionTextbox.Name = "extensionTextbox";
            this.extensionTextbox.Size = new System.Drawing.Size(251, 20);
            this.extensionTextbox.TabIndex = 1;
            this.extensionTextbox.Text = ".jpg";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(611, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fileList
            // 
            this.fileList.Location = new System.Drawing.Point(15, 74);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(847, 309);
            this.fileList.TabIndex = 3;
            this.fileList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // locationTextbox
            // 
            this.locationTextbox.Location = new System.Drawing.Point(71, 41);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(453, 20);
            this.locationTextbox.TabIndex = 5;
            this.locationTextbox.Text = "C:\\Users\\Tobias\\Desktop\\The Who - Quadrophenia CD 1";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(530, 38);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 395);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.locationTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.extensionTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox extensionTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.Button browseButton;
    }
}

