namespace LibraryMaterial
{
    partial class Correction1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.studentAnswerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_roll = new System.Windows.Forms.ListBox();
            this.studentAnswerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryMaterial.LibraryDataSet();
            this.txt_question = new MetroFramework.Controls.MetroTextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_markscor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_markalot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_answer = new MetroFramework.Controls.MetroTextBox();
            this.studentAnswerTableAdapter = new LibraryMaterial.LibraryDataSetTableAdapters.StudentAnswerTableAdapter();
            this.listBox_Qno = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentAnswerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAnswerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentAnswerBindingSource
            // 
            this.studentAnswerBindingSource.DataMember = "StudentAnswer";
            // 
            // list_roll
            // 
            this.list_roll.DataSource = this.studentAnswerBindingSource1;
            this.list_roll.DisplayMember = "Roll_No";
            this.list_roll.FormattingEnabled = true;
            this.list_roll.Location = new System.Drawing.Point(53, 81);
            this.list_roll.Name = "list_roll";
            this.list_roll.Size = new System.Drawing.Size(120, 95);
            this.list_roll.TabIndex = 15;
            this.list_roll.ValueMember = "Roll_No";
            this.list_roll.SelectedIndexChanged += new System.EventHandler(this.list_roll_SelectedIndexChanged);
            // 
            // studentAnswerBindingSource1
            // 
            this.studentAnswerBindingSource1.DataMember = "StudentAnswer";
            this.studentAnswerBindingSource1.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_question
            // 
            this.txt_question.Location = new System.Drawing.Point(397, 81);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(250, 95);
            this.txt_question.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_question.TabIndex = 14;
            this.txt_question.UseStyleColors = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.DarkRed;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton1.ForeColor = System.Drawing.Color.Red;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(149, 411);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(71, 36);
            this.materialFlatButton1.TabIndex = 23;
            this.materialFlatButton1.Text = "SUBMIT";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txt_markscor
            // 
            this.txt_markscor.Location = new System.Drawing.Point(222, 378);
            this.txt_markscor.Name = "txt_markscor";
            this.txt_markscor.Size = new System.Drawing.Size(75, 23);
            this.txt_markscor.TabIndex = 22;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(217, 350);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Mark Scored";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(67, 350);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Mark Allotted";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_markalot
            // 
            this.txt_markalot.Location = new System.Drawing.Point(73, 379);
            this.txt_markalot.Name = "txt_markalot";
            this.txt_markalot.Size = new System.Drawing.Size(75, 23);
            this.txt_markalot.TabIndex = 19;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(396, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Picture Clue";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(396, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(53, 246);
            this.txt_answer.Multiline = true;
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.ReadOnly = true;
            this.txt_answer.Size = new System.Drawing.Size(250, 95);
            this.txt_answer.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_answer.TabIndex = 16;
            this.txt_answer.UseStyleColors = true;
            // 
            // studentAnswerTableAdapter
            // 
            this.studentAnswerTableAdapter.ClearBeforeFill = true;
            // 
            // listBox_Qno
            // 
            this.listBox_Qno.DataSource = this.studentAnswerBindingSource1;
            this.listBox_Qno.DisplayMember = "Qno";
            this.listBox_Qno.FormattingEnabled = true;
            this.listBox_Qno.Location = new System.Drawing.Point(222, 81);
            this.listBox_Qno.Name = "listBox_Qno";
            this.listBox_Qno.Size = new System.Drawing.Size(120, 95);
            this.listBox_Qno.TabIndex = 24;
            this.listBox_Qno.ValueMember = "Qno";
            this.listBox_Qno.SelectedIndexChanged += new System.EventHandler(this.listBox_Qno_SelectedIndexChanged);
            // 
            // Correction1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.list_roll);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txt_markscor);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_markalot);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.listBox_Qno);
            this.Name = "Correction1";
            this.Size = new System.Drawing.Size(700, 527);
            this.Load += new System.EventHandler(this.Correction1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentAnswerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAnswerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentAnswerBindingSource;
        private System.Windows.Forms.ListBox list_roll;
        private System.Windows.Forms.BindingSource studentAnswerBindingSource1;
        private LibraryDataSet libraryDataSet;
        private MetroFramework.Controls.MetroTextBox txt_question;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MetroFramework.Controls.MetroTextBox txt_markscor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_markalot;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txt_answer;
        private LibraryDataSetTableAdapters.StudentAnswerTableAdapter studentAnswerTableAdapter;
        private System.Windows.Forms.ListBox listBox_Qno;
    }
}
