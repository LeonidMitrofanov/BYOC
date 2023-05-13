namespace BuildYouOwnCar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanelAllCars = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCar = new System.Windows.Forms.Panel();
            this.labelCarName = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelAllCars.SuspendLayout();
            this.panelCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAllCars
            // 
            this.flowLayoutPanelAllCars.AutoScroll = true;
            this.flowLayoutPanelAllCars.Controls.Add(this.panelCar);
            this.flowLayoutPanelAllCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAllCars.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAllCars.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.flowLayoutPanelAllCars.Name = "flowLayoutPanelAllCars";
            this.flowLayoutPanelAllCars.Size = new System.Drawing.Size(1428, 935);
            this.flowLayoutPanelAllCars.TabIndex = 0;
            // 
            // panelCar
            // 
            this.panelCar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCar.BackColor = System.Drawing.Color.Maroon;
            this.panelCar.Controls.Add(this.labelCarName);
            this.panelCar.Controls.Add(this.pictureBoxCar);
            this.panelCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCar.Location = new System.Drawing.Point(10, 10);
            this.panelCar.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(620, 419);
            this.panelCar.TabIndex = 0;
            // 
            // labelCarName
            // 
            this.labelCarName.AutoSize = true;
            this.labelCarName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCarName.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarName.ForeColor = System.Drawing.Color.White;
            this.labelCarName.Location = new System.Drawing.Point(0, 360);
            this.labelCarName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCarName.Name = "labelCarName";
            this.labelCarName.Size = new System.Drawing.Size(279, 49);
            this.labelCarName.TabIndex = 1;
            this.labelCarName.Text = "Название авто";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCar.Image = global::BuildYouOwnCar.Properties.Resources.Lada2114_Main;
            this.pictureBoxCar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(620, 360);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1428, 935);
            this.Controls.Add(this.flowLayoutPanelAllCars);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "BYOC";
            this.flowLayoutPanelAllCars.ResumeLayout(false);
            this.panelCar.ResumeLayout(false);
            this.panelCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAllCars;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Label labelCarName;
        private System.Windows.Forms.PictureBox pictureBoxCar;
    }
}

