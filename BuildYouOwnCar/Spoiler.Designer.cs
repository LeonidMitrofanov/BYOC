namespace BuildYouOwnCar
{
    partial class Spoiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spoiler));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGoNext = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelSpoilers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSpoiler = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.labelWheelsName = new System.Windows.Forms.Label();
            this.pictureBoxSpoiler = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.flowLayoutPanelSpoilers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSpoiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpoiler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanelSpoilers);
            this.splitContainer.Size = new System.Drawing.Size(761, 661);
            this.splitContainer.SplitterDistance = 447;
            this.splitContainer.SplitterWidth = 2;
            this.splitContainer.TabIndex = 1;
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(529, 2);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonGoNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoNext.Name = "buttonGoNext";
            this.buttonGoNext.Size = new System.Drawing.Size(136, 48);
            this.buttonGoNext.TabIndex = 1;
            this.buttonGoNext.Text = "Итоги";
            this.buttonGoNext.UseVisualStyleBackColor = true;
            this.buttonGoNext.Click += new System.EventHandler(this.buttonGoNext_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGoBack.Location = new System.Drawing.Point(2, 2);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(88, 48);
            this.buttonGoBack.TabIndex = 2;
            this.buttonGoBack.Text = "Отмена";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCar.ErrorImage = global::BuildYouOwnCar.Properties.Resources.NoFound404;
            this.pictureBoxCar.Image = global::BuildYouOwnCar.Properties.Resources.Loading_Circule;
            this.pictureBoxCar.InitialImage = global::BuildYouOwnCar.Properties.Resources.CarLoading_Orange;
            this.pictureBoxCar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(761, 447);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // flowLayoutPanelSpoilers
            // 
            this.flowLayoutPanelSpoilers.AutoScroll = true;
            this.flowLayoutPanelSpoilers.BackColor = System.Drawing.Color.Maroon;
            this.flowLayoutPanelSpoilers.Controls.Add(this.panel1);
            this.flowLayoutPanelSpoilers.Controls.Add(this.panelSpoiler);
            this.flowLayoutPanelSpoilers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSpoilers.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSpoilers.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelSpoilers.Name = "flowLayoutPanelSpoilers";
            this.flowLayoutPanelSpoilers.Size = new System.Drawing.Size(761, 212);
            this.flowLayoutPanelSpoilers.TabIndex = 0;
            this.flowLayoutPanelSpoilers.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 206);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "0 р";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Без спойлера";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::BuildYouOwnCar.Properties.Resources.None;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelSpoiler
            // 
            this.panelSpoiler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSpoiler.Controls.Add(this.label3);
            this.panelSpoiler.Controls.Add(this.pictureBoxStatus);
            this.panelSpoiler.Controls.Add(this.labelWheelsName);
            this.panelSpoiler.Controls.Add(this.pictureBoxSpoiler);
            this.panelSpoiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSpoiler.Location = new System.Drawing.Point(156, 2);
            this.panelSpoiler.Margin = new System.Windows.Forms.Padding(2);
            this.panelSpoiler.Name = "panelSpoiler";
            this.panelSpoiler.Size = new System.Drawing.Size(150, 206);
            this.panelSpoiler.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "2 000 р";
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
            // labelWheelsName
            // 
            this.labelWheelsName.AutoSize = true;
            this.labelWheelsName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWheelsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWheelsName.Location = new System.Drawing.Point(0, 156);
            this.labelWheelsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWheelsName.Name = "labelWheelsName";
            this.labelWheelsName.Size = new System.Drawing.Size(148, 20);
            this.labelWheelsName.TabIndex = 1;
            this.labelWheelsName.Text = "Standart VAZ-2114";
            // 
            // pictureBoxSpoiler
            // 
            this.pictureBoxSpoiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSpoiler.Image = global::BuildYouOwnCar.Properties.Resources.spoiler_LadaDefolt;
            this.pictureBoxSpoiler.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSpoiler.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxSpoiler.Name = "pictureBoxSpoiler";
            this.pictureBoxSpoiler.Size = new System.Drawing.Size(150, 156);
            this.pictureBoxSpoiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSpoiler.TabIndex = 0;
            this.pictureBoxSpoiler.TabStop = false;
            // 
            // Spoiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 661);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(325, 435);
            this.Name = "Spoiler";
            this.Text = "BYOC_Spoiler";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.flowLayoutPanelSpoilers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSpoiler.ResumeLayout(false);
            this.panelSpoiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpoiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonGoNext;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpoilers;
        private System.Windows.Forms.Panel panelSpoiler;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Label labelWheelsName;
        private System.Windows.Forms.PictureBox pictureBoxSpoiler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}