
namespace simplepaint
{
    partial class Form1
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
            this.rityta = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pBoxColorDialog = new System.Windows.Forms.PictureBox();
            this.widthSelectionBar = new System.Windows.Forms.TrackBar();
            this.widthSelectorGroup = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.shapeChoiceBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rityta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxColorDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelectionBar)).BeginInit();
            this.widthSelectorGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rityta
            // 
            this.rityta.Location = new System.Drawing.Point(12, 117);
            this.rityta.Name = "rityta";
            this.rityta.Size = new System.Drawing.Size(567, 435);
            this.rityta.TabIndex = 0;
            this.rityta.TabStop = false;
            this.rityta.Paint += new System.Windows.Forms.PaintEventHandler(this.rityta_Paint);
            this.rityta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rityta_MouseDown);
            this.rityta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rityta_MouseMove);
            this.rityta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rityta_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::simplepaint.Properties.Resources.cooltext454210699375667;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 108);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pBoxColorDialog);
            this.groupBox1.Location = new System.Drawing.Point(687, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(66, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Färgval";
            // 
            // pBoxColorDialog
            // 
            this.pBoxColorDialog.BackColor = System.Drawing.Color.Black;
            this.pBoxColorDialog.Location = new System.Drawing.Point(15, 19);
            this.pBoxColorDialog.Name = "pBoxColorDialog";
            this.pBoxColorDialog.Size = new System.Drawing.Size(37, 33);
            this.pBoxColorDialog.TabIndex = 5;
            this.pBoxColorDialog.TabStop = false;
            this.pBoxColorDialog.Click += new System.EventHandler(this.pBoxColorDialog_Click);
            // 
            // widthSelectionBar
            // 
            this.widthSelectionBar.Location = new System.Drawing.Point(10, 19);
            this.widthSelectionBar.Maximum = 30;
            this.widthSelectionBar.Name = "widthSelectionBar";
            this.widthSelectionBar.Size = new System.Drawing.Size(157, 45);
            this.widthSelectionBar.TabIndex = 3;
            this.widthSelectionBar.ValueChanged += new System.EventHandler(this.widthSelectionBar_ValueChanged);
            // 
            // widthSelectorGroup
            // 
            this.widthSelectorGroup.Controls.Add(this.widthSelectionBar);
            this.widthSelectorGroup.Location = new System.Drawing.Point(585, 12);
            this.widthSelectorGroup.Name = "widthSelectorGroup";
            this.widthSelectorGroup.Size = new System.Drawing.Size(168, 78);
            this.widthSelectorGroup.TabIndex = 4;
            this.widthSelectorGroup.TabStop = false;
            this.widthSelectorGroup.Text = "Tjocklek";
            // 
            // shapeChoiceBox
            // 
            this.shapeChoiceBox.FormattingEnabled = true;
            this.shapeChoiceBox.Items.AddRange(new object[] {
            "Pen",
            "Rectangle",
            "Ellips"});
            this.shapeChoiceBox.Location = new System.Drawing.Point(6, 15);
            this.shapeChoiceBox.Name = "shapeChoiceBox";
            this.shapeChoiceBox.Size = new System.Drawing.Size(84, 43);
            this.shapeChoiceBox.TabIndex = 5;
            this.shapeChoiceBox.SelectedIndexChanged += new System.EventHandler(this.shapeChoiceBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shapeChoiceBox);
            this.groupBox2.Location = new System.Drawing.Point(585, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ritverktyg";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(595, 166);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(678, 166);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(75, 23);
            this.helpBtn.TabIndex = 8;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 575);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.widthSelectorGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rityta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rityta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxColorDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelectionBar)).EndInit();
            this.widthSelectorGroup.ResumeLayout(false);
            this.widthSelectorGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rityta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar widthSelectionBar;
        private System.Windows.Forms.GroupBox widthSelectorGroup;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pBoxColorDialog;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ListBox shapeChoiceBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button helpBtn;
    }
}

