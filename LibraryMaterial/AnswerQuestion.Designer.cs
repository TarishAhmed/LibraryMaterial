namespace LibraryMaterial
{
    partial class AnswerQuestion
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
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryMaterial.LibraryDataSet();
            this.questionTableAdapter = new LibraryMaterial.LibraryDataSetTableAdapters.QuestionTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_question = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_answer = new MetroFramework.Controls.MetroTextBox();
            this.button_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.answerQuestionData = new LibraryMaterial.AnswerQuestionData();
            this.answerQuestionDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter1 = new LibraryMaterial.AnswerQuestionDataTableAdapters.QuestionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerQuestionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerQuestionDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_questionno
            // 
            this.listBox_questionno.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_questionno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_questionno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_questionno.DataSource = this.questionBindingSource1;
            this.listBox_questionno.DisplayMember = "Qno";
            this.listBox_questionno.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_questionno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBox_questionno.FormattingEnabled = true;
            this.listBox_questionno.ItemHeight = 19;
            this.listBox_questionno.Location = new System.Drawing.Point(106, 119);
            this.listBox_questionno.Name = "listBox_questionno";
            this.listBox_questionno.Size = new System.Drawing.Size(120, 97);
            this.listBox_questionno.TabIndex = 0;
            this.listBox_questionno.ValueMember = "Qno";
            this.listBox_questionno.Click += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox_questionno.SelectedIndexChanged += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox_questionno.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "Question";
            this.questionBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(106, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Question Number";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_question
            // 
            this.txt_question.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_question.Location = new System.Drawing.Point(264, 119);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(337, 95);
            this.txt_question.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_question.TabIndex = 2;
            this.txt_question.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_question.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(264, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Question";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(106, 247);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Picture Clue";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(380, 247);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Answer";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = true;
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(380, 285);
            this.txt_answer.Multiline = true;
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(221, 104);
            this.txt_answer.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_answer.TabIndex = 7;
            this.txt_answer.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_answer.UseStyleColors = true;
            // 
            // button_submit
            // 
            this.button_submit.AutoSize = true;
            this.button_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit.Depth = 0;
            this.button_submit.Icon = null;
            this.button_submit.Location = new System.Drawing.Point(458, 405);
            this.button_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_submit.Name = "button_submit";
            this.button_submit.Primary = true;
            this.button_submit.Size = new System.Drawing.Size(71, 36);
            this.button_submit.TabIndex = 8;
            this.button_submit.Text = "SUBMIT";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // answerQuestionData
            // 
            this.answerQuestionData.DataSetName = "AnswerQuestionData";
            this.answerQuestionData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // answerQuestionDataBindingSource
            // 
            this.answerQuestionDataBindingSource.DataSource = this.answerQuestionData;
            this.answerQuestionDataBindingSource.Position = 0;
            // 
            // questionBindingSource1
            // 
            this.questionBindingSource1.DataMember = "Question";
            this.questionBindingSource1.DataSource = this.answerQuestionDataBindingSource;
            // 
            // questionTableAdapter1
            // 
            this.questionTableAdapter1.ClearBeforeFill = true;
            // 
            // AnswerQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox_questionno);
            this.Name = "AnswerQuestion";
            this.Size = new System.Drawing.Size(700, 527);
            this.Load += new System.EventHandler(this.AnswerQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerQuestionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerQuestionDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_questionno;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private LibraryDataSet libraryDataSet;
        private LibraryDataSetTableAdapters.QuestionTableAdapter questionTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_question;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_answer;
        private MaterialSkin.Controls.MaterialRaisedButton button_submit;
        private System.Windows.Forms.BindingSource questionBindingSource1;
        private System.Windows.Forms.BindingSource answerQuestionDataBindingSource;
        private AnswerQuestionData answerQuestionData;
        private AnswerQuestionDataTableAdapters.QuestionTableAdapter questionTableAdapter1;
    }
}
