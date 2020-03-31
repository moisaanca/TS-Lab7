namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonSubmitPath = new System.Windows.Forms.Button();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxTags = new System.Windows.Forms.ComboBox();
            this.labelAvailableTags = new System.Windows.Forms.Label();
            this.labelTagValue = new System.Windows.Forms.Label();
            this.textBoxTagValue = new System.Windows.Forms.TextBox();
            this.buttonSearchPhotos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            resources.ApplyResources(this.textBoxPath, "textBoxPath");
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // buttonSubmitPath
            // 
            resources.ApplyResources(this.buttonSubmitPath, "buttonSubmitPath");
            this.buttonSubmitPath.Name = "buttonSubmitPath";
            this.buttonSubmitPath.UseVisualStyleBackColor = true;
            this.buttonSubmitPath.Click += new System.EventHandler(this.buttonSubmitPath_Click);
            // 
            // buttonAddTag
            // 
            resources.ApplyResources(this.buttonAddTag, "buttonAddTag");
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.UseVisualStyleBackColor = true;
            this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // comboBoxTags
            // 
            this.comboBoxTags.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxTags, "comboBoxTags");
            this.comboBoxTags.Name = "comboBoxTags";
            this.comboBoxTags.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelAvailableTags
            // 
            resources.ApplyResources(this.labelAvailableTags, "labelAvailableTags");
            this.labelAvailableTags.Name = "labelAvailableTags";
            this.labelAvailableTags.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTagValue
            // 
            resources.ApplyResources(this.labelTagValue, "labelTagValue");
            this.labelTagValue.Name = "labelTagValue";
            // 
            // textBoxTagValue
            // 
            resources.ApplyResources(this.textBoxTagValue, "textBoxTagValue");
            this.textBoxTagValue.Name = "textBoxTagValue";
            this.textBoxTagValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSearchPhotos
            // 
            resources.ApplyResources(this.buttonSearchPhotos, "buttonSearchPhotos");
            this.buttonSearchPhotos.Name = "buttonSearchPhotos";
            this.buttonSearchPhotos.UseVisualStyleBackColor = true;
            this.buttonSearchPhotos.Click += new System.EventHandler(this.buttonSearchPhotos_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonSubmitPath;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBoxTags;
        private System.Windows.Forms.Label labelAvailableTags;
        private System.Windows.Forms.Label labelTagValue;
        private System.Windows.Forms.TextBox textBoxTagValue;
        private System.Windows.Forms.Button buttonSearchPhotos;
    }
}

