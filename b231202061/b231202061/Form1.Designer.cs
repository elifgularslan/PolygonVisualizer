
//********************************************************************************
//**************       STUDENT NAME : ELİF GÜL ARSLAN ****************************
//**************     STUDENT NUMBER : B231202061      ****************************
//********************************************************************************



namespace b231202061
{
    partial class Form1
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
            txtCenterX = new TextBox();
            txtLength = new TextBox();
            txtNumberOfEdges = new TextBox();
            txtRotationAngle = new TextBox();
            labelCenter = new Label();
            labelLength = new Label();
            labelRed = new Label();
            labelGreen = new Label();
            labelBlue = new Label();
            labelEdge = new Label();
            labelAngle = new Label();
            labelTotalRotation = new Label();
            checkBoxCCW = new CheckBox();
            checkBoxFill = new CheckBox();
            btnDraw = new Button();
            btnRotate = new Button();
            btnReset = new Button();
            listBoxVertices = new ListBox();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            pictureBox = new PictureBox();
            groupBoxControl = new GroupBox();
            txtCenterY = new TextBox();
            labelMadeBy = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBoxControl.SuspendLayout();
            SuspendLayout();
            // 
            // txtCenterX
            // 
            txtCenterX.Location = new Point(94, 36);
            txtCenterX.Name = "txtCenterX";
            txtCenterX.Size = new Size(45, 27);
            txtCenterX.TabIndex = 0;
            txtCenterX.Text = "0";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(94, 73);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(125, 27);
            txtLength.TabIndex = 2;
            txtLength.Text = "4";
            // 
            // txtNumberOfEdges
            // 
            txtNumberOfEdges.Location = new Point(89, 283);
            txtNumberOfEdges.Name = "txtNumberOfEdges";
            txtNumberOfEdges.Size = new Size(50, 27);
            txtNumberOfEdges.TabIndex = 3;
            txtNumberOfEdges.Text = "5";
            // 
            // txtRotationAngle
            // 
            txtRotationAngle.Location = new Point(89, 328);
            txtRotationAngle.Name = "txtRotationAngle";
            txtRotationAngle.Size = new Size(125, 27);
            txtRotationAngle.TabIndex = 4;
            txtRotationAngle.Text = "30";
            // 
            // labelCenter
            // 
            labelCenter.AutoSize = true;
            labelCenter.Location = new Point(6, 43);
            labelCenter.Name = "labelCenter";
            labelCenter.Size = new Size(83, 20);
            labelCenter.TabIndex = 5;
            labelCenter.Text = "Center (x,y)";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(6, 73);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(54, 20);
            labelLength.TabIndex = 6;
            labelLength.Text = "Length";
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(6, 106);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(35, 20);
            labelRed.TabIndex = 7;
            labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(6, 159);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(48, 20);
            labelGreen.TabIndex = 8;
            labelGreen.Text = "Green";
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Location = new Point(6, 221);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(38, 20);
            labelBlue.TabIndex = 9;
            labelBlue.Text = "Blue";
            // 
            // labelEdge
            // 
            labelEdge.AutoSize = true;
            labelEdge.Location = new Point(6, 290);
            labelEdge.Name = "labelEdge";
            labelEdge.Size = new Size(43, 20);
            labelEdge.TabIndex = 10;
            labelEdge.Text = "Edge";
            // 
            // labelAngle
            // 
            labelAngle.AutoSize = true;
            labelAngle.Location = new Point(6, 328);
            labelAngle.Name = "labelAngle";
            labelAngle.Size = new Size(48, 20);
            labelAngle.TabIndex = 11;
            labelAngle.Text = "Angle";
            // 
            // labelTotalRotation
            // 
            labelTotalRotation.AutoSize = true;
            labelTotalRotation.Location = new Point(6, 502);
            labelTotalRotation.Name = "labelTotalRotation";
            labelTotalRotation.Size = new Size(149, 20);
            labelTotalRotation.TabIndex = 12;
            labelTotalRotation.Text = "Total Rotation Angle:";
            // 
            // checkBoxCCW
            // 
            checkBoxCCW.AutoSize = true;
            checkBoxCCW.Location = new Point(145, 286);
            checkBoxCCW.Name = "checkBoxCCW";
            checkBoxCCW.Size = new Size(161, 24);
            checkBoxCCW.TabIndex = 13;
            checkBoxCCW.Text = "Counter-Clock Wise";
            checkBoxCCW.UseVisualStyleBackColor = true;
            // 
            // checkBoxFill
            // 
            checkBoxFill.AutoSize = true;
            checkBoxFill.Location = new Point(186, 502);
            checkBoxFill.Name = "checkBoxFill";
            checkBoxFill.Size = new Size(120, 24);
            checkBoxFill.TabIndex = 14;
            checkBoxFill.Text = "Fill with color";
            checkBoxFill.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(89, 549);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(94, 29);
            btnDraw.TabIndex = 15;
            btnDraw.Text = "DRAW";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(89, 584);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(94, 29);
            btnRotate.TabIndex = 16;
            btnRotate.Text = "ROTATE";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(89, 619);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 17;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // listBoxVertices
            // 
            listBoxVertices.FormattingEnabled = true;
            listBoxVertices.Location = new Point(89, 375);
            listBoxVertices.Name = "listBoxVertices";
            listBoxVertices.Size = new Size(150, 104);
            listBoxVertices.TabIndex = 18;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(89, 106);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(130, 56);
            trackBarRed.TabIndex = 19;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(89, 159);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(130, 56);
            trackBarGreen.TabIndex = 20;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(89, 221);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(130, 56);
            trackBarBlue.TabIndex = 21;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 32);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(708, 664);
            pictureBox.TabIndex = 22;
            pictureBox.TabStop = false;
            // 
            // groupBoxControl
            // 
            groupBoxControl.Controls.Add(txtCenterY);
            groupBoxControl.Controls.Add(labelCenter);
            groupBoxControl.Controls.Add(checkBoxFill);
            groupBoxControl.Controls.Add(btnReset);
            groupBoxControl.Controls.Add(listBoxVertices);
            groupBoxControl.Controls.Add(btnRotate);
            groupBoxControl.Controls.Add(trackBarBlue);
            groupBoxControl.Controls.Add(btnDraw);
            groupBoxControl.Controls.Add(txtCenterX);
            groupBoxControl.Controls.Add(trackBarGreen);
            groupBoxControl.Controls.Add(labelTotalRotation);
            groupBoxControl.Controls.Add(labelLength);
            groupBoxControl.Controls.Add(trackBarRed);
            groupBoxControl.Controls.Add(checkBoxCCW);
            groupBoxControl.Controls.Add(txtRotationAngle);
            groupBoxControl.Controls.Add(labelAngle);
            groupBoxControl.Controls.Add(txtLength);
            groupBoxControl.Controls.Add(labelRed);
            groupBoxControl.Controls.Add(labelGreen);
            groupBoxControl.Controls.Add(labelEdge);
            groupBoxControl.Controls.Add(txtNumberOfEdges);
            groupBoxControl.Controls.Add(labelBlue);
            groupBoxControl.Font = new Font("Segoe UI", 9F);
            groupBoxControl.Location = new Point(777, 12);
            groupBoxControl.Name = "groupBoxControl";
            groupBoxControl.Size = new Size(314, 692);
            groupBoxControl.TabIndex = 23;
            groupBoxControl.TabStop = false;
            groupBoxControl.Text = "Control Panel";
            // 
            // txtCenterY
            // 
            txtCenterY.Location = new Point(167, 36);
            txtCenterY.Name = "txtCenterY";
            txtCenterY.Size = new Size(47, 27);
            txtCenterY.TabIndex = 7;
            txtCenterY.Text = "0";
            // 
            // labelMadeBy
            // 
            labelMadeBy.AutoSize = true;
            labelMadeBy.BackColor = SystemColors.ActiveCaption;
            labelMadeBy.Location = new Point(978, 714);
            labelMadeBy.Name = "labelMadeBy";
            labelMadeBy.Size = new Size(105, 20);
            labelMadeBy.TabIndex = 24;
            labelMadeBy.Text = "Made By E.G.A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 743);
            Controls.Add(labelMadeBy);
            Controls.Add(groupBoxControl);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBoxControl.ResumeLayout(false);
            groupBoxControl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCenterX;
        private TextBox txtLength;
        private TextBox txtNumberOfEdges;
        private TextBox txtRotationAngle;
        private Label labelCenter;
        private Label labelLength;
        private Label labelRed;
        private Label labelGreen;
        private Label labelBlue;
        private Label labelEdge;
        private Label labelAngle;
        private Label labelTotalRotation;
        private CheckBox checkBoxCCW;
        private CheckBox checkBoxFill;
        private Button btnDraw;
        private Button btnRotate;
        private Button btnReset;
        private ListBox listBoxVertices;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private PictureBox pictureBox;
        private GroupBox groupBoxControl;
        private TextBox txtCenterY;
        private Label labelMadeBy;
    }
}
