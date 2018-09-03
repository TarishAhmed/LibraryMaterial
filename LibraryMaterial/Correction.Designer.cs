namespace LibraryMaterial
{
    partial class Correction
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
            this.listBox_questionno = new System.Windows.Forms.ListBox();
            this.studentAnswerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new LibraryMaterial.DataSet1();
            this.txt_question = new MetroFramework.Controls.MetroTextBox();
            this.studentAnswerTableAdapter = new LibraryMaterial.DataSet1TableAdapters.StudentAnswerTableAdapter();
            this.list_roll = new System.Windows.Forms.ListBox();
            this.txt_answer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_markalot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_markscor = new MetroFramework.Controls.MetroTextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentAnswerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_questionno
            // 
            this.listBox_questionno.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.studentAnswerBindingSource, "Roll_No", true));
            this.listBox_questionno.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.studentAnswerBindingSource, "Roll_No", true));
            this.listBox_questionno.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.studentAnswerBindingSource, "Roll_No", true));
            this.listBox_questionno.FormattingEnabled = true;
            this.listBox_questionno.Location = new System.Drawing.Point(220, 51);
            this.listBox_questionno.MultiColumn = true;
            this.listBox_questionno.Name = "listBox_questionno";
            this.listBox_questionno.Size = new System.Drawing.Size(120, 95);
            this.listBox_questionno.TabIndex = 0;
            this.listBox_questionno.SelectedIndexChanged += new System.EventHandler(this.listBox_questionno_SelectedIndexChanged);
            // 
            // studentAnswerBindingSource
            // 
            this.studentAnswerBindingSource.DataMember = "StudentAnswer";
            this.studentAnswerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_question
            // 
            this.txt_question.Location = new System.Drawing.Point(395, 51);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(250, 95);
            this.txt_question.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_question.TabIndex = 1;
            this.txt_question.UseStyleColors = true;
            // 
            // studentAnswerTableAdapter
            // 
            this.studentAnswerTableAdapter.ClearBeforeFill = true;
            // 
            // list_roll
            // 
            this.list_roll.FormattingEnabled = true;
            this.list_roll.Location = new System.Drawing.Point(51, 51);
            this.list_roll.Name = "list_roll";
            this.list_roll.Size = new System.Drawing.Size(120, 95);
            this.list_roll.TabIndex = 2;
            this.list_roll.SelectedIndexChanged += new System.EventHandler(this.list_roll_SelectedIndexChanged);
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(51, 216);
            this.txt_answer.Multiline = true;
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.ReadOnly = true;
            this.txt_answer.Size = new System.Drawing.Size(250, 95);
            this.txt_answer.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_answer.TabIndex = 3;
            this.txt_answer.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(394, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Picture Clue";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(394, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txt_markalot
            // 
            this.txt_markalot.Location = new System.Drawing.Point(71, 349);
            this.txt_markalot.Name = "txt_markalot";
            this.txt_markalot.Size = new System.Drawing.Size(75, 23);
            this.txt_markalot.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(65, 320);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Mark Allotted";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(220, 320);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Mark Scored";
            // 
            // txt_markscor
            // 
            this.txt_markscor.Location = new System.Drawing.Point(220, 348);
            this.txt_markscor.Name = "txt_markscor";
            this.txt_markscor.Size = new System.Drawing.Size(75, 23);
            this.txt_markscor.TabIndex = 11;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Exo Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton1.ForeColor = System.Drawing.Color.Red;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(169, 380);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(71, 36);
            this.materialFlatButton1.TabIndex = 12;
            this.materialFlatButton1.Text = "SUBMIT";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Correction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txt_markscor);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_markalot);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.list_roll);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.listBox_questionno);
            this.Name = "Correction";
            this.Size = new System.Drawing.Size(700, 527);
            this.Load += new System.EventHandler(this.Correction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentAnswerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_questionno;
        private MetroFramework.Controls.MetroTextBox txt_question;
        private System.Windows.Forms.BindingSource studentAnswerBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.StudentAnswerTableAdapter studentAnswerTableAdapter;
        private System.Windows.Forms.ListBox list_roll;
        private MetroFramework.Controls.MetroTextBox txt_answer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txt_markalot;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_markscor;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
