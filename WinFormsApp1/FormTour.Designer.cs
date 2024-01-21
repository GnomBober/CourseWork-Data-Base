namespace WinFormsApp1
{
    partial class FormTour
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
            gridTour = new DataGridView();
            tourPlaceF = new TextBox();
            tourTypeF = new TextBox();
            tourPriceF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tourDelB = new Button();
            tourAddB = new Button();
            ((System.ComponentModel.ISupportInitialize)gridTour).BeginInit();
            SuspendLayout();
            // 
            // gridTour
            // 
            gridTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTour.Location = new Point(12, 12);
            gridTour.Name = "gridTour";
            gridTour.Size = new Size(398, 426);
            gridTour.TabIndex = 1;
            gridTour.CellContentClick += gridTour_CellContentClick;
            // 
            // tourPlaceF
            // 
            tourPlaceF.Location = new Point(515, 12);
            tourPlaceF.Name = "tourPlaceF";
            tourPlaceF.Size = new Size(273, 23);
            tourPlaceF.TabIndex = 4;
            // 
            // tourTypeF
            // 
            tourTypeF.Location = new Point(515, 41);
            tourTypeF.Name = "tourTypeF";
            tourTypeF.Size = new Size(273, 23);
            tourTypeF.TabIndex = 5;
            // 
            // tourPriceF
            // 
            tourPriceF.Location = new Point(515, 70);
            tourPriceF.Name = "tourPriceF";
            tourPriceF.Size = new Size(273, 23);
            tourPriceF.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(416, 10);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 9;
            label1.Text = "Локация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(416, 41);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 10;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(416, 68);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 11;
            label3.Text = "Цена";
            // 
            // tourDelB
            // 
            tourDelB.Location = new Point(515, 99);
            tourDelB.Name = "tourDelB";
            tourDelB.Size = new Size(75, 23);
            tourDelB.TabIndex = 14;
            tourDelB.Text = "Удалить";
            tourDelB.UseVisualStyleBackColor = true;
            tourDelB.Click += tourDelB_Click;
            // 
            // tourAddB
            // 
            tourAddB.Location = new Point(713, 99);
            tourAddB.Name = "tourAddB";
            tourAddB.Size = new Size(75, 23);
            tourAddB.TabIndex = 15;
            tourAddB.Text = "Добавить";
            tourAddB.UseVisualStyleBackColor = true;
            tourAddB.Click += tourAddB_Click;
            // 
            // FormTour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tourAddB);
            Controls.Add(tourDelB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tourPriceF);
            Controls.Add(tourTypeF);
            Controls.Add(tourPlaceF);
            Controls.Add(gridTour);
            Name = "FormTour";
            Text = "Туры";
            ((System.ComponentModel.ISupportInitialize)gridTour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridTour;
        private TextBox tourPlaceF;
        private TextBox tourTypeF;
        private TextBox tourPriceF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button tourDelB;
        private Button tourAddB;
    }
}