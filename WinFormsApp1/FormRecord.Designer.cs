namespace WinFormsApp1
{
    partial class FormRecord
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridRecord = new DataGridView();
            clientBox = new ComboBox();
            employeeBox = new ComboBox();
            tourBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tourDelB = new Button();
            button1 = new Button();
            button2 = new Button();
            recToClientB = new Button();
            recToEmployeeB = new Button();
            recToTourB = new Button();
            ((System.ComponentModel.ISupportInitialize)gridRecord).BeginInit();
            SuspendLayout();
            // 
            // gridRecord
            // 
            gridRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRecord.Location = new Point(12, 12);
            gridRecord.Name = "gridRecord";
            gridRecord.Size = new Size(398, 426);
            gridRecord.TabIndex = 0;
            gridRecord.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clientBox
            // 
            clientBox.FormattingEnabled = true;
            clientBox.Location = new Point(528, 12);
            clientBox.Name = "clientBox";
            clientBox.Size = new Size(260, 23);
            clientBox.TabIndex = 1;
            clientBox.SelectedIndexChanged += clientBox_SelectedIndexChanged;
            // 
            // employeeBox
            // 
            employeeBox.FormattingEnabled = true;
            employeeBox.Location = new Point(528, 41);
            employeeBox.Name = "employeeBox";
            employeeBox.Size = new Size(260, 23);
            employeeBox.TabIndex = 2;
            // 
            // tourBox
            // 
            tourBox.FormattingEnabled = true;
            tourBox.Location = new Point(528, 70);
            tourBox.Name = "tourBox";
            tourBox.Size = new Size(260, 23);
            tourBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(416, 10);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 10;
            label1.Text = "Клиент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(416, 39);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 11;
            label2.Text = "Сотрудник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(416, 68);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 12;
            label3.Text = "Тур";
            // 
            // tourDelB
            // 
            tourDelB.Location = new Point(528, 99);
            tourDelB.Name = "tourDelB";
            tourDelB.Size = new Size(75, 23);
            tourDelB.TabIndex = 15;
            tourDelB.Text = "Удалить";
            tourDelB.UseVisualStyleBackColor = true;
            tourDelB.Click += tourDelB_Click;
            // 
            // button1
            // 
            button1.Location = new Point(620, 99);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(713, 99);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // recToClientB
            // 
            recToClientB.Location = new Point(434, 394);
            recToClientB.Name = "recToClientB";
            recToClientB.Size = new Size(86, 44);
            recToClientB.TabIndex = 18;
            recToClientB.Text = "Добавить Клинета";
            recToClientB.UseVisualStyleBackColor = true;
            recToClientB.Click += recToClientB_Click;
            // 
            // recToEmployeeB
            // 
            recToEmployeeB.Location = new Point(528, 394);
            recToEmployeeB.Name = "recToEmployeeB";
            recToEmployeeB.Size = new Size(86, 44);
            recToEmployeeB.TabIndex = 19;
            recToEmployeeB.Text = "Добавить Сотрудника";
            recToEmployeeB.UseVisualStyleBackColor = true;
            recToEmployeeB.Click += recToEmployeeB_Click;
            // 
            // recToTourB
            // 
            recToTourB.Location = new Point(620, 394);
            recToTourB.Name = "recToTourB";
            recToTourB.Size = new Size(86, 44);
            recToTourB.TabIndex = 20;
            recToTourB.Text = "Добавить Тур";
            recToTourB.UseVisualStyleBackColor = true;
            recToTourB.Click += recToTourB_Click;
            // 
            // FormRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(recToTourB);
            Controls.Add(recToEmployeeB);
            Controls.Add(recToClientB);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tourDelB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tourBox);
            Controls.Add(employeeBox);
            Controls.Add(clientBox);
            Controls.Add(gridRecord);
            Name = "FormRecord";
            Text = "Записи";
            ((System.ComponentModel.ISupportInitialize)gridRecord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridRecord;
        private ComboBox clientBox;
        private ComboBox employeeBox;
        private ComboBox tourBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button tourDelB;
        private Button button1;
        private Button button2;
        private Button recToClientB;
        private Button recToEmployeeB;
        private Button recToTourB;
    }
}
