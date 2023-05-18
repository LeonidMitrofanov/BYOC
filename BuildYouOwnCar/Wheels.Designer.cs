namespace BuildYouOwnCar
{
    partial class Wheels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wheels));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGoNext = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.flowLayoutPanelWheels = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWheels = new System.Windows.Forms.Panel();
            this.labelWheelsName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.pictureBoxWheels = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelWheelsPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanelWheels.SuspendLayout();
            this.panelWheels.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel);
            this.splitContainer.Panel1.Controls.Add(this.pictureBoxCar);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanelWheels);
            this.splitContainer.Size = new System.Drawing.Size(754, 661);
            this.splitContainer.SplitterDistance = 441;
            this.splitContainer.SplitterWidth = 2;
            this.splitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.Controls.Add(this.buttonGoNext, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonGoBack, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(522, 2);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(232, 52);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // buttonGoNext
            // 
            this.buttonGoNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGoNext.Location = new System.Drawing.Point(94, 2);
            this.buttonGoNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGoNext.Name = "buttonGoNext";
            this.buttonGoNext.Size = new System.Drawing.Size(136, 48);
            this.buttonGoNext.TabIndex = 1;
            this.buttonGoNext.Text = "Далее";
            this.buttonGoNext.UseVisualStyleBackColor = true;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGoBack.Location = new System.Drawing.Point(2, 2);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(88, 48);
            this.buttonGoBack.TabIndex = 2;
            this.buttonGoBack.Text = "Отмена";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelWheels
            // 
            this.flowLayoutPanelWheels.AutoScroll = true;
            this.flowLayoutPanelWheels.BackColor = System.Drawing.Color.Maroon;
            this.flowLayoutPanelWheels.Controls.Add(this.panelWheels);
            this.flowLayoutPanelWheels.Controls.Add(this.panel1);
            this.flowLayoutPanelWheels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelWheels.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelWheels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelWheels.Name = "flowLayoutPanelWheels";
            this.flowLayoutPanelWheels.Size = new System.Drawing.Size(754, 218);
            this.flowLayoutPanelWheels.TabIndex = 0;
            this.flowLayoutPanelWheels.WrapContents = false;
            // 
            // panelWheels
            // 
            this.panelWheels.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelWheels.Controls.Add(this.labelWheelsPrice);
            this.panelWheels.Controls.Add(this.pictureBoxStatus);
            this.panelWheels.Controls.Add(this.labelWheelsName);
            this.panelWheels.Controls.Add(this.pictureBoxWheels);
            this.panelWheels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelWheels.Location = new System.Drawing.Point(2, 2);
            this.panelWheels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelWheels.Name = "panelWheels";
            this.panelWheels.Size = new System.Drawing.Size(150, 206);
            this.panelWheels.TabIndex = 0;
            // 
            // labelWheelsName
            // 
            this.labelWheelsName.AutoSize = true;
            this.labelWheelsName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWheelsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWheelsName.Location = new System.Drawing.Point(0, 156);
            this.labelWheelsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWheelsName.Name = "labelWheelsName";
            this.labelWheelsName.Size = new System.Drawing.Size(71, 20);
            this.labelWheelsName.TabIndex = 1;
            this.labelWheelsName.Text = "Standart";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(156, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 206);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dimond wheels";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCar.Image = global::BuildYouOwnCar.Properties.Resources.Lada2114_Wheels;
            this.pictureBoxCar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(754, 441);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxStatus.Image = global::BuildYouOwnCar.Properties.Resources.BlackCheckMark;
            this.pictureBoxStatus.Location = new System.Drawing.Point(124, 176);
            this.pictureBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(26, 30);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStatus.TabIndex = 2;
            this.pictureBoxStatus.TabStop = false;
            // 
            // pictureBoxWheels
            // 
            this.pictureBoxWheels.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxWheels.Image = global::BuildYouOwnCar.Properties.Resources.wheels_LadaStandart;
            this.pictureBoxWheels.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxWheels.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxWheels.Name = "pictureBoxWheels";
            this.pictureBoxWheels.Size = new System.Drawing.Size(150, 156);
            this.pictureBoxWheels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWheels.TabIndex = 0;
            this.pictureBoxWheels.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::BuildYouOwnCar.Properties.Resources.BlackCheckMark;
            this.pictureBox1.Location = new System.Drawing.Point(124, 176);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::BuildYouOwnCar.Properties.Resources.Diamond;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelWheelsPrice
            // 
            this.labelWheelsPrice.AutoSize = true;
            this.labelWheelsPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelWheelsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWheelsPrice.Location = new System.Drawing.Point(0, 190);
            this.labelWheelsPrice.Name = "labelWheelsPrice";
            this.labelWheelsPrice.Size = new System.Drawing.Size(25, 16);
            this.labelWheelsPrice.TabIndex = 3;
            this.labelWheelsPrice.Text = "0 р";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "5 000 р";
            // 
            // Wheels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 661);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Wheels";
            this.Text = "BYOC_Wheels";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanelWheels.ResumeLayout(false);
            this.panelWheels.ResumeLayout(false);
            this.panelWheels.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelWheels;
        private System.Windows.Forms.Label labelWheelsName;
        private System.Windows.Forms.PictureBox pictureBoxWheels;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWheels;
        private System.Windows.Forms.Button buttonGoNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelWheelsPrice;
        private System.Windows.Forms.Label label2;
    }
}