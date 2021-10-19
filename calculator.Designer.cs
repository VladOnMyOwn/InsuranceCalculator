namespace insurance_calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.comment = new System.Windows.Forms.Label();
            this.sex_male = new System.Windows.Forms.RadioButton();
            this.sex_female = new System.Windows.Forms.RadioButton();
            this.sex_choose = new System.Windows.Forms.GroupBox();
            this.experience = new System.Windows.Forms.Label();
            this.d_exp = new System.Windows.Forms.TextBox();
            this.model_label = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.ComboBox();
            this.full = new System.Windows.Forms.RadioButton();
            this.partly = new System.Windows.Forms.RadioButton();
            this.insur_type = new System.Windows.Forms.GroupBox();
            this.calc = new System.Windows.Forms.Button();
            this.summ = new System.Windows.Forms.TextBox();
            this.summ_label = new System.Windows.Forms.Label();
            this.sex_choose.SuspendLayout();
            this.insur_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // comment
            // 
            this.comment.BackColor = System.Drawing.Color.Transparent;
            this.comment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.comment.Location = new System.Drawing.Point(57, 50);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(803, 29);
            this.comment.TabIndex = 0;
            this.comment.Text = "Для расчета стоимости страхового тарифа заполните следующую форму";
            // 
            // sex_male
            // 
            this.sex_male.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sex_male.Location = new System.Drawing.Point(7, 22);
            this.sex_male.Name = "sex_male";
            this.sex_male.Size = new System.Drawing.Size(116, 24);
            this.sex_male.TabIndex = 1;
            this.sex_male.Text = "Мужской";
            this.sex_male.UseVisualStyleBackColor = true;
            // 
            // sex_female
            // 
            this.sex_female.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sex_female.Location = new System.Drawing.Point(7, 49);
            this.sex_female.Name = "sex_female";
            this.sex_female.Size = new System.Drawing.Size(116, 24);
            this.sex_female.TabIndex = 2;
            this.sex_female.Text = "Женский";
            this.sex_female.UseVisualStyleBackColor = true;
            // 
            // sex_choose
            // 
            this.sex_choose.BackColor = System.Drawing.Color.Transparent;
            this.sex_choose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sex_choose.Controls.Add(this.sex_male);
            this.sex_choose.Controls.Add(this.sex_female);
            this.sex_choose.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sex_choose.Location = new System.Drawing.Point(57, 104);
            this.sex_choose.Name = "sex_choose";
            this.sex_choose.Size = new System.Drawing.Size(129, 79);
            this.sex_choose.TabIndex = 3;
            this.sex_choose.TabStop = false;
            this.sex_choose.Text = "Пол";
            // 
            // experience
            // 
            this.experience.BackColor = System.Drawing.Color.Transparent;
            this.experience.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.experience.Location = new System.Drawing.Point(64, 211);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(128, 23);
            this.experience.TabIndex = 4;
            this.experience.Text = "Стаж вождения";
            // 
            // d_exp
            // 
            this.d_exp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.d_exp.Location = new System.Drawing.Point(57, 237);
            this.d_exp.Name = "d_exp";
            this.d_exp.Size = new System.Drawing.Size(135, 28);
            this.d_exp.TabIndex = 5;
            this.d_exp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.d_exp_KeyPress);
            // 
            // model_label
            // 
            this.model_label.BackColor = System.Drawing.Color.Transparent;
            this.model_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.model_label.Location = new System.Drawing.Point(64, 298);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(169, 23);
            this.model_label.TabIndex = 6;
            this.model_label.Text = "Марка автомобиля";
            // 
            // auto
            // 
            this.auto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.auto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.auto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.auto.FormattingEnabled = true;
            this.auto.Location = new System.Drawing.Point(57, 324);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(198, 29);
            this.auto.TabIndex = 7;
            // 
            // full
            // 
            this.full.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.full.Location = new System.Drawing.Point(6, 23);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(104, 24);
            this.full.TabIndex = 8;
            this.full.TabStop = true;
            this.full.Text = "Полное";
            this.full.UseVisualStyleBackColor = true;
            // 
            // partly
            // 
            this.partly.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.partly.Location = new System.Drawing.Point(6, 53);
            this.partly.Name = "partly";
            this.partly.Size = new System.Drawing.Size(129, 24);
            this.partly.TabIndex = 9;
            this.partly.TabStop = true;
            this.partly.Text = "Частичное";
            this.partly.UseVisualStyleBackColor = true;
            // 
            // insur_type
            // 
            this.insur_type.BackColor = System.Drawing.Color.Transparent;
            this.insur_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insur_type.Controls.Add(this.partly);
            this.insur_type.Controls.Add(this.full);
            this.insur_type.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.insur_type.Location = new System.Drawing.Point(64, 389);
            this.insur_type.Name = "insur_type";
            this.insur_type.Size = new System.Drawing.Size(146, 83);
            this.insur_type.TabIndex = 10;
            this.insur_type.TabStop = false;
            this.insur_type.Text = "Тип страхования";
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.calc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calc.Location = new System.Drawing.Point(603, 283);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(86, 38);
            this.calc.TabIndex = 11;
            this.calc.Text = "Расчет";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // summ
            // 
            this.summ.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.summ.Location = new System.Drawing.Point(534, 249);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(218, 28);
            this.summ.TabIndex = 12;
            this.summ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // summ_label
            // 
            this.summ_label.BackColor = System.Drawing.Color.Transparent;
            this.summ_label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.summ_label.Location = new System.Drawing.Point(534, 220);
            this.summ_label.Name = "summ_label";
            this.summ_label.Size = new System.Drawing.Size(218, 26);
            this.summ_label.TabIndex = 13;
            this.summ_label.Text = "Стоимость страхования";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 535);
            this.Controls.Add(this.summ_label);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.insur_type);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.d_exp);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.sex_choose);
            this.Controls.Add(this.comment);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор страхового тарифа";
            this.sex_choose.ResumeLayout(false);
            this.insur_type.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label summ_label;

        private System.Windows.Forms.TextBox summ;

        private System.Windows.Forms.Button calc;

        private System.Windows.Forms.GroupBox insur_type;

        private System.Windows.Forms.RadioButton full;

        private System.Windows.Forms.RadioButton partly;

        private System.Windows.Forms.ComboBox auto;
        private System.Windows.Forms.Label model_label;

        private System.Windows.Forms.Label experience;
        private System.Windows.Forms.TextBox d_exp;

        private System.Windows.Forms.RadioButton sex_female;
        private System.Windows.Forms.GroupBox sex_choose;

        private System.Windows.Forms.RadioButton sex_male;

        private System.Windows.Forms.Label comment;

        #endregion
    }
}