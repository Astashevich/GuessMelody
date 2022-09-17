namespace GuessMelody
{
    partial class FParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FParams));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.cbAllDirectory = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(670, 407);
            this.listBox1.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectFolder.Location = new System.Drawing.Point(33, 431);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(127, 33);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "Выбрать папку";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonClearList.Location = new System.Drawing.Point(253, 431);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(84, 34);
            this.buttonClearList.TabIndex = 2;
            this.buttonClearList.Text = "Очистить";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // cbAllDirectory
            // 
            this.cbAllDirectory.AutoSize = true;
            this.cbAllDirectory.Location = new System.Drawing.Point(528, 431);
            this.cbAllDirectory.Name = "cbAllDirectory";
            this.cbAllDirectory.Size = new System.Drawing.Size(112, 17);
            this.cbAllDirectory.TabIndex = 3;
            this.cbAllDirectory.Text = "Вложеные папки";
            this.cbAllDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonOK.Location = new System.Drawing.Point(383, 576);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(102, 36);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Подтвердить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonCancel.Location = new System.Drawing.Point(552, 576);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 36);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music_notes_treble_clef_flat_sharp_symbols_flying_vector_design_676239_3008;
            this.ClientSize = new System.Drawing.Size(670, 632);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.cbAllDirectory);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.CheckBox cbAllDirectory;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}