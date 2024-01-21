namespace WinFormsApp1
{
    partial class FormEmployee
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
            gridEmployee = new DataGridView();
            employeeNameF = new TextBox();
            employeeSurnameF = new TextBox();
            employeeLastNameF = new TextBox();
            employeeJobF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            employeeDelB = new Button();
            employeeAddB = new Button();
            ((System.ComponentModel.ISupportInitialize)gridEmployee).BeginInit();
            SuspendLayout();
            // 
            // gridEmployee
            // 
            gridEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmployee.Location = new Point(12, 12);
            gridEmployee.Name = "gridEmployee";
            gridEmployee.Size = new Size(398, 426);
            gridEmployee.TabIndex = 1;
            gridEmployee.CellContentClick += gridEmployee_CellContentClick;
            // 
            // employeeNameF
            // 
            employeeNameF.Location = new Point(515, 12);
            employeeNameF.Name = "employeeNameF";
            employeeNameF.Size = new Size(273, 23);
            employeeNameF.TabIndex = 3;
            // 
            // employeeSurnameF
            // 
            employeeSurnameF.Location = new Point(515, 41);
            employeeSurnameF.Name = "employeeSurnameF";
            employeeSurnameF.Size = new Size(273, 23);
            employeeSurnameF.TabIndex = 4;
            // 
            // employeeLastNameF
            // 
            employeeLastNameF.Location = new Point(515, 70);
            employeeLastNameF.Name = "employeeLastNameF";
            employeeLastNameF.Size = new Size(273, 23);
            employeeLastNameF.TabIndex = 5;
            // 
            // employeeJobF
            // 
            employeeJobF.Location = new Point(515, 99);
            employeeJobF.Name = "employeeJobF";
            employeeJobF.Size = new Size(273, 23);
            employeeJobF.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(416, 10);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 8;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(416, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 9;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(416, 68);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 10;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(419, 101);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 11;
            label4.Text = "Должность";
            // 
            // employeeDelB
            // 
            employeeDelB.Location = new Point(515, 128);
            employeeDelB.Name = "employeeDelB";
            employeeDelB.Size = new Size(75, 23);
            employeeDelB.TabIndex = 14;
            employeeDelB.Text = "Удалить";
            employeeDelB.UseVisualStyleBackColor = true;
            employeeDelB.Click += employeeDelB_Click;
            // 
            // employeeAddB
            // 
            employeeAddB.Location = new Point(713, 128);
            employeeAddB.Name = "employeeAddB";
            employeeAddB.Size = new Size(75, 23);
            employeeAddB.TabIndex = 15;
            employeeAddB.Text = "Добавить";
            employeeAddB.UseVisualStyleBackColor = true;
            employeeAddB.Click += employeeAddB_Click;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(employeeAddB);
            Controls.Add(employeeDelB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(employeeJobF);
            Controls.Add(employeeLastNameF);
            Controls.Add(employeeSurnameF);
            Controls.Add(employeeNameF);
            Controls.Add(gridEmployee);
            Name = "FormEmployee";
            Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)gridEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridEmployee;
        private TextBox employeeNameF;
        private TextBox employeeSurnameF;
        private TextBox employeeLastNameF;
        private TextBox employeeJobF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button employeeDelB;
        private Button employeeAddB;
    }
}