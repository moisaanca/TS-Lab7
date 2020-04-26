namespace WindowsFormsApp2
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
            this.buttonSearchPhotos = new System.Windows.Forms.Button();
            this.textBoxTagValue = new System.Windows.Forms.TextBox();
            this.labelTagValue = new System.Windows.Forms.Label();
            this.labelAvailableTags = new System.Windows.Forms.Label();
            this.comboBoxTags = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.buttonSubmitPath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchPhotos
            // 
            this.buttonSearchPhotos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearchPhotos.Location = new System.Drawing.Point(655, 393);
            this.buttonSearchPhotos.Name = "buttonSearchPhotos";
            this.buttonSearchPhotos.Size = new System.Drawing.Size(132, 29);
            this.buttonSearchPhotos.TabIndex = 22;
            this.buttonSearchPhotos.Text = "Search photos";
            this.buttonSearchPhotos.UseVisualStyleBackColor = true;
            // 
            // textBoxTagValue
            // 
            this.textBoxTagValue.Location = new System.Drawing.Point(655, 232);
            this.textBoxTagValue.Name = "textBoxTagValue";
            this.textBoxTagValue.Size = new System.Drawing.Size(283, 22);
            this.textBoxTagValue.TabIndex = 21;
            // 
            // labelTagValue
            // 
            this.labelTagValue.AutoSize = true;
            this.labelTagValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTagValue.Location = new System.Drawing.Point(652, 201);
            this.labelTagValue.Name = "labelTagValue";
            this.labelTagValue.Size = new System.Drawing.Size(71, 17);
            this.labelTagValue.TabIndex = 20;
            this.labelTagValue.Text = "Tag value";
            // 
            // labelAvailableTags
            // 
            this.labelAvailableTags.AutoSize = true;
            this.labelAvailableTags.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAvailableTags.Location = new System.Drawing.Point(652, 123);
            this.labelAvailableTags.Name = "labelAvailableTags";
            this.labelAvailableTags.Size = new System.Drawing.Size(96, 17);
            this.labelAvailableTags.TabIndex = 19;
            this.labelAvailableTags.Text = "Available tags";
            // 
            // comboBoxTags
            // 
            this.comboBoxTags.FormattingEnabled = true;
            this.comboBoxTags.Location = new System.Drawing.Point(655, 153);
            this.comboBoxTags.Name = "comboBoxTags";
            this.comboBoxTags.Size = new System.Drawing.Size(283, 24);
            this.comboBoxTags.TabIndex = 18;
            // 
            // pictureBox
            // 
            this.pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox.Location = new System.Drawing.Point(32, 82);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(497, 340);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSave.Location = new System.Drawing.Point(953, 28);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 29);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAddTag.Location = new System.Drawing.Point(803, 29);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(135, 28);
            this.buttonAddTag.TabIndex = 15;
            this.buttonAddTag.Text = "Add tag";
            this.buttonAddTag.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitPath
            // 
            this.buttonSubmitPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSubmitPath.Location = new System.Drawing.Point(655, 28);
            this.buttonSubmitPath.Name = "buttonSubmitPath";
            this.buttonSubmitPath.Size = new System.Drawing.Size(132, 29);
            this.buttonSubmitPath.TabIndex = 14;
            this.buttonSubmitPath.Text = "Display";
            this.buttonSubmitPath.UseVisualStyleBackColor = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(32, 31);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(498, 22);
            this.textBoxPath.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.buttonSearchPhotos);
            this.Controls.Add(this.textBoxTagValue);
            this.Controls.Add(this.labelTagValue);
            this.Controls.Add(this.labelAvailableTags);
            this.Controls.Add(this.comboBoxTags);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddTag);
            this.Controls.Add(this.buttonSubmitPath);
            this.Controls.Add(this.textBoxPath);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchPhotos;
        private System.Windows.Forms.TextBox textBoxTagValue;
        private System.Windows.Forms.Label labelTagValue;
        private System.Windows.Forms.Label labelAvailableTags;
        private System.Windows.Forms.ComboBox comboBoxTags;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.Button buttonSubmitPath;
        private System.Windows.Forms.TextBox textBoxPath;
    }
}

