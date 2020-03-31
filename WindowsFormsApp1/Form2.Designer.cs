namespace WindowsFormsApp1
{
    partial class Form2
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
            this.labelSearchByDescription = new System.Windows.Forms.Label();
            this.textBoxSearchByDescription = new System.Windows.Forms.TextBox();
            this.labelSearchByTag = new System.Windows.Forms.Label();
            this.comboBoxSearchByTag = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBoxResults = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResults)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchByDescription
            // 
            this.labelSearchByDescription.AutoSize = true;
            this.labelSearchByDescription.Location = new System.Drawing.Point(12, 9);
            this.labelSearchByDescription.Name = "labelSearchByDescription";
            this.labelSearchByDescription.Size = new System.Drawing.Size(145, 17);
            this.labelSearchByDescription.TabIndex = 0;
            this.labelSearchByDescription.Text = "Search by description";
            this.labelSearchByDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSearchByDescription
            // 
            this.textBoxSearchByDescription.Location = new System.Drawing.Point(15, 46);
            this.textBoxSearchByDescription.Name = "textBoxSearchByDescription";
            this.textBoxSearchByDescription.Size = new System.Drawing.Size(142, 22);
            this.textBoxSearchByDescription.TabIndex = 1;
            // 
            // labelSearchByTag
            // 
            this.labelSearchByTag.AutoSize = true;
            this.labelSearchByTag.Location = new System.Drawing.Point(303, 9);
            this.labelSearchByTag.Name = "labelSearchByTag";
            this.labelSearchByTag.Size = new System.Drawing.Size(96, 17);
            this.labelSearchByTag.TabIndex = 2;
            this.labelSearchByTag.Text = "Search by tag";
            // 
            // comboBoxSearchByTag
            // 
            this.comboBoxSearchByTag.FormattingEnabled = true;
            this.comboBoxSearchByTag.Location = new System.Drawing.Point(306, 44);
            this.comboBoxSearchByTag.Name = "comboBoxSearchByTag";
            this.comboBoxSearchByTag.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSearchByTag.TabIndex = 3;
            this.comboBoxSearchByTag.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchByTag_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(487, 211);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(181, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(15, 404);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(129, 23);
            this.buttonPrevious.TabIndex = 6;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(298, 404);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(129, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // pictureBoxResults
            // 
            this.pictureBoxResults.Location = new System.Drawing.Point(15, 90);
            this.pictureBoxResults.Name = "pictureBoxResults";
            this.pictureBoxResults.Size = new System.Drawing.Size(412, 294);
            this.pictureBoxResults.TabIndex = 8;
            this.pictureBoxResults.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(487, 404);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(197, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.pictureBoxResults);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearchByTag);
            this.Controls.Add(this.labelSearchByTag);
            this.Controls.Add(this.textBoxSearchByDescription);
            this.Controls.Add(this.labelSearchByDescription);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchByDescription;
        private System.Windows.Forms.TextBox textBoxSearchByDescription;
        private System.Windows.Forms.Label labelSearchByTag;
        private System.Windows.Forms.ComboBox comboBoxSearchByTag;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBoxResults;
        private System.Windows.Forms.Button buttonDelete;
    }
}