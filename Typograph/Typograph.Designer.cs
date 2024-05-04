namespace Typograph
{
    partial class Typograph
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Typograph));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.Rule1CheckBox = new System.Windows.Forms.CheckBox();
            this.Rule2CheckBox = new System.Windows.Forms.CheckBox();
            this.Rule3CheckBox = new System.Windows.Forms.CheckBox();
            this.Rule4CheckBox = new System.Windows.Forms.CheckBox();
            this.Rule5CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FormatButton = new System.Windows.Forms.Button();
            this.Rule6CheckBox = new System.Windows.Forms.CheckBox();
            this.Rule7CheckBox = new System.Windows.Forms.CheckBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.Input_label = new System.Windows.Forms.Label();
            this.Output_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox.Location = new System.Drawing.Point(11, 269);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(426, 349);
            this.InputTextBox.TabIndex = 0;
            // 
            // Rule1CheckBox
            // 
            this.Rule1CheckBox.AutoSize = true;
            this.Rule1CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rule1CheckBox.Location = new System.Drawing.Point(12, 36);
            this.Rule1CheckBox.Name = "Rule1CheckBox";
            this.Rule1CheckBox.Size = new System.Drawing.Size(656, 22);
            this.Rule1CheckBox.TabIndex = 1;
            this.Rule1CheckBox.Text = "Все знаки препинания пишутся слева слитно со словом, а справа отбиваются пробелом" +
    ".";
            this.Rule1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Rule2CheckBox
            // 
            this.Rule2CheckBox.AutoSize = true;
            this.Rule2CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rule2CheckBox.Location = new System.Drawing.Point(12, 64);
            this.Rule2CheckBox.Name = "Rule2CheckBox";
            this.Rule2CheckBox.Size = new System.Drawing.Size(356, 22);
            this.Rule2CheckBox.TabIndex = 2;
            this.Rule2CheckBox.Text = "Нельзя писать подряд более одного пробела.";
            this.Rule2CheckBox.UseVisualStyleBackColor = true;
            // 
            // Rule3CheckBox
            // 
            this.Rule3CheckBox.AutoSize = true;
            this.Rule3CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rule3CheckBox.Location = new System.Drawing.Point(12, 92);
            this.Rule3CheckBox.Name = "Rule3CheckBox";
            this.Rule3CheckBox.Size = new System.Drawing.Size(803, 22);
            this.Rule3CheckBox.TabIndex = 3;
            this.Rule3CheckBox.Text = "Дефис пробелами не отбивается и всегда пишется слитно с частями слова или цифр, к" +
    "оторые он разделяет.";
            this.Rule3CheckBox.UseVisualStyleBackColor = true;
            // 
            // Rule4CheckBox
            // 
            this.Rule4CheckBox.AutoSize = true;
            this.Rule4CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rule4CheckBox.Location = new System.Drawing.Point(12, 120);
            this.Rule4CheckBox.Name = "Rule4CheckBox";
            this.Rule4CheckBox.Size = new System.Drawing.Size(891, 22);
            this.Rule4CheckBox.TabIndex = 4;
            this.Rule4CheckBox.Text = "Все стандартные сокращения типа «и т. д.», «и т. п.», «т. к.» должны писаться чер" +
    "ез пробел, и ни в коем случае не слитно.";
            this.Rule4CheckBox.UseVisualStyleBackColor = true;
            // 
            // Rule5CheckBox
            // 
            this.Rule5CheckBox.AutoSize = true;
            this.Rule5CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rule5CheckBox.Location = new System.Drawing.Point(12, 148);
            this.Rule5CheckBox.Name = "Rule5CheckBox";
            this.Rule5CheckBox.Size = new System.Drawing.Size(904, 22);
            this.Rule5CheckBox.TabIndex = 5;
            this.Rule5CheckBox.Text = "При указании каких-либо технических характеристик, значение и единица измерения п" +
    "ишутся через непереносимый пробел.";
            this.Rule5CheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Правила форматирования";
            // 
            // FormatButton
            // 
            this.FormatButton.BackColor = System.Drawing.Color.Yellow;
            this.FormatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormatButton.Location = new System.Drawing.Point(390, 624);
            this.FormatButton.Name = "FormatButton";
            this.FormatButton.Size = new System.Drawing.Size(159, 38);
            this.FormatButton.TabIndex = 7;
            this.FormatButton.Text = "Преобразовать";
            this.FormatButton.UseVisualStyleBackColor = false;
            this.FormatButton.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // Rule6CheckBox
            // 
            this.Rule6CheckBox.AutoSize = true;
            this.Rule6CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rule6CheckBox.Location = new System.Drawing.Point(11, 177);
            this.Rule6CheckBox.Name = "Rule6CheckBox";
            this.Rule6CheckBox.Size = new System.Drawing.Size(614, 22);
            this.Rule6CheckBox.TabIndex = 8;
            this.Rule6CheckBox.Text = "Все буквы в предложении, следующем за точкой, воспринимаются как начальные.";
            this.Rule6CheckBox.UseVisualStyleBackColor = true;
            // 
            // Rule7CheckBox
            // 
            this.Rule7CheckBox.AutoSize = true;
            this.Rule7CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rule7CheckBox.Location = new System.Drawing.Point(12, 206);
            this.Rule7CheckBox.Name = "Rule7CheckBox";
            this.Rule7CheckBox.Size = new System.Drawing.Size(412, 22);
            this.Rule7CheckBox.TabIndex = 9;
            this.Rule7CheckBox.Text = "Перед каждой точкой с запятой должен быть пробел.";
            this.Rule7CheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.White;
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTextBox.Location = new System.Drawing.Point(501, 269);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(426, 349);
            this.OutputTextBox.TabIndex = 10;
            // 
            // Input_label
            // 
            this.Input_label.AutoSize = true;
            this.Input_label.BackColor = System.Drawing.Color.Yellow;
            this.Input_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_label.Location = new System.Drawing.Point(147, 234);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(150, 20);
            this.Input_label.TabIndex = 11;
            this.Input_label.Text = "До преобразований";
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.BackColor = System.Drawing.Color.Yellow;
            this.Output_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output_label.Location = new System.Drawing.Point(627, 234);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(174, 20);
            this.Output_label.TabIndex = 12;
            this.Output_label.Text = "После преобразований";
            // 
            // Typograph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1068, 684);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.Input_label);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.Rule7CheckBox);
            this.Controls.Add(this.Rule6CheckBox);
            this.Controls.Add(this.FormatButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rule5CheckBox);
            this.Controls.Add(this.Rule4CheckBox);
            this.Controls.Add(this.Rule3CheckBox);
            this.Controls.Add(this.Rule2CheckBox);
            this.Controls.Add(this.Rule1CheckBox);
            this.Controls.Add(this.InputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Typograph";
            this.Text = "Типограф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.CheckBox Rule1CheckBox;
        private System.Windows.Forms.CheckBox Rule2CheckBox;
        private System.Windows.Forms.CheckBox Rule3CheckBox;
        private System.Windows.Forms.CheckBox Rule4CheckBox;
        private System.Windows.Forms.CheckBox Rule5CheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FormatButton;
        private System.Windows.Forms.CheckBox Rule6CheckBox;
        private System.Windows.Forms.CheckBox Rule7CheckBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label Input_label;
        private System.Windows.Forms.Label Output_label;
    }
}

