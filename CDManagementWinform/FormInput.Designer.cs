namespace CDManagementWinform
{
    partial class FormInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.ErrorDuration = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorAlbum = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorSinger = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorSong = new System.Windows.Forms.ErrorProvider(this.components);
            this.listSongs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Singer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Song:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(211, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(76, 50);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(211, 20);
            this.txtAlbum.TabIndex = 2;
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(76, 76);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(211, 20);
            this.txtSinger.TabIndex = 3;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(76, 130);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(211, 20);
            this.txtDuration.TabIndex = 5;
            this.txtDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDuration_KeyDown);
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(76, 156);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(211, 20);
            this.txtSong.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(187, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(61, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSong.Location = new System.Drawing.Point(294, 154);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(25, 19);
            this.btnAddSong.TabIndex = 7;
            this.btnAddSong.Text = "+";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // cbxGenre
            // 
            this.cbxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
            "Rock",
            "Rap",
            "Country",
            "Blue",
            "Jazz",
            "Dance"});
            this.cbxGenre.Location = new System.Drawing.Point(76, 103);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(211, 21);
            this.cbxGenre.TabIndex = 4;
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSong.Location = new System.Drawing.Point(294, 182);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(25, 19);
            this.btnRemoveSong.TabIndex = 10;
            this.btnRemoveSong.Text = "-";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // ErrorDuration
            // 
            this.ErrorDuration.ContainerControl = this;
            // 
            // ErrorAlbum
            // 
            this.ErrorAlbum.ContainerControl = this;
            // 
            // ErrorID
            // 
            this.ErrorID.ContainerControl = this;
            // 
            // ErrorSinger
            // 
            this.ErrorSinger.ContainerControl = this;
            // 
            // ErrorSong
            // 
            this.ErrorSong.ContainerControl = this;
            // 
            // listSongs
            // 
            this.listSongs.FormattingEnabled = true;
            this.listSongs.Location = new System.Drawing.Point(76, 182);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(211, 108);
            this.listSongs.TabIndex = 11;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 335);
            this.Controls.Add(this.listSongs);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.cbxGenre);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtSinger);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInput";
            this.Text = "Input Form";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtSinger;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.ErrorProvider ErrorDuration;
        private System.Windows.Forms.ErrorProvider ErrorAlbum;
        private System.Windows.Forms.ErrorProvider ErrorID;
        private System.Windows.Forms.ErrorProvider ErrorSinger;
        private System.Windows.Forms.ErrorProvider ErrorSong;
        private System.Windows.Forms.ListBox listSongs;
    }
}