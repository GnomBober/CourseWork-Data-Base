namespace WinFormsApp1
{
    partial class FormClient
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
            gridClient = new DataGridView();
            clientNameF = new TextBox();
            clientSurnameF = new TextBox();
            clientLastNameF = new TextBox();
            clientNumberF = new TextBox();
            clientMailF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            clientAddB = new Button();
            clientDelB = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClient).BeginInit();
            SuspendLayout();
            // 
            // gridClient
            // 
            gridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClient.Location = new Point(12, 12);
            gridClient.Name = "gridClient";
            gridClient.Size = new Size(398, 426);
            gridClient.TabIndex = 1;
            gridClient.CellContentClick += gridClient_CellContentClick;
            // 
            // clientNameF
            // 
            clientNameF.Location = new Point(515, 12);
            clientNameF.Name = "clientNameF";
            clientNameF.Size = new Size(273, 23);
            clientNameF.TabIndex = 2;
            // 
            // clientSurnameF
            // 
            clientSurnameF.Location = new Point(515, 41);
            clientSurnameF.Name = "clientSurnameF";
            clientSurnameF.Size = new Size(273, 23);
            clientSurnameF.TabIndex = 3;
            // 
            // clientLastNameF
            // 
            clientLastNameF.Location = new Point(515, 70);
            clientLastNameF.Name = "clientLastNameF";
            clientLastNameF.Size = new Size(273, 23);
            clientLastNameF.TabIndex = 4;
            // 
            // clientNumberF
            // 
            clientNumberF.Location = new Point(515, 99);
            clientNumberF.Name = "clientNumberF";
            clientNumberF.Size = new Size(273, 23);
            clientNumberF.TabIndex = 5;
            // 
            // clientMailF
            // 
            clientMailF.Location = new Point(515, 128);
            clientMailF.Name = "clientMailF";
            clientMailF.Size = new Size(273, 23);
            clientMailF.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(416, 10);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 7;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(416, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 8;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(416, 68);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 9;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(416, 97);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 10;
            label4.Text = "Номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(416, 126);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 11;
            label5.Text = "Почта";
            // 
            // clientAddB
            // 
            clientAddB.Location = new Point(713, 157);
            clientAddB.Name = "clientAddB";
            clientAddB.Size = new Size(75, 23);
            clientAddB.TabIndex = 12;
            clientAddB.Text = "Добавить";
            clientAddB.UseVisualStyleBackColor = true;
            clientAddB.Click += clientAddB_Click;
            // 
            // clientDelB
            // 
            clientDelB.Location = new Point(515, 157);
            clientDelB.Name = "clientDelB";
            clientDelB.Size = new Size(75, 23);
            clientDelB.TabIndex = 13;
            clientDelB.Text = "Удалить";
            clientDelB.UseVisualStyleBackColor = true;
            clientDelB.Click += clientDelB_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clientDelB);
            Controls.Add(clientAddB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clientMailF);
            Controls.Add(clientNumberF);
            Controls.Add(clientLastNameF);
            Controls.Add(clientSurnameF);
            Controls.Add(clientNameF);
            Controls.Add(gridClient);
            Name = "FormClient";
            Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)gridClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridClient;
        private TextBox clientNameF;
        private TextBox clientSurnameF;
        private TextBox clientLastNameF;
        private TextBox clientNumberF;
        private TextBox clientMailF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button clientAddB;
        private Button clientDelB;
    }
}