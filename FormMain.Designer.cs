namespace AffineWinFormCoreCSharp
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.groupBoxAffine = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBoxTranslate = new System.Windows.Forms.GroupBox();
            this.textBoxTy = new System.Windows.Forms.TextBox();
            this.textBoxTx = new System.Windows.Forms.TextBox();
            this.groupBoxScale = new System.Windows.Forms.GroupBox();
            this.textBoxSy = new System.Windows.Forms.TextBox();
            this.textBoxSx = new System.Windows.Forms.TextBox();
            this.groupBoxRotate = new System.Windows.Forms.GroupBox();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblTx = new System.Windows.Forms.Label();
            this.lblTy = new System.Windows.Forms.Label();
            this.lblSx = new System.Windows.Forms.Label();
            this.lblSy = new System.Windows.Forms.Label();
            this.groupBoxOperation.SuspendLayout();
            this.groupBoxAffine.SuspendLayout();
            this.groupBoxTranslate.SuspendLayout();
            this.groupBoxScale.SuspendLayout();
            this.groupBoxRotate.SuspendLayout();
            this.groupBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.btnInit);
            this.groupBoxOperation.Controls.Add(this.btnClose);
            this.groupBoxOperation.Controls.Add(this.btnFileSelect);
            this.groupBoxOperation.Controls.Add(this.groupBoxAffine);
            this.groupBoxOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxOperation.Location = new System.Drawing.Point(15, 8);
            this.groupBoxOperation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBoxOperation.Size = new System.Drawing.Size(240, 578);
            this.groupBoxOperation.TabIndex = 1;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Operation";
            // 
            // btnInit
            // 
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Location = new System.Drawing.Point(44, 90);
            this.btnInit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(150, 50);
            this.btnInit.TabIndex = 3;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.OnClickBtnInit);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(44, 150);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSelect.Location = new System.Drawing.Point(44, 28);
            this.btnFileSelect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(150, 50);
            this.btnFileSelect.TabIndex = 2;
            this.btnFileSelect.Text = "File Select...";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.OnClickBtnFileSelect);
            // 
            // groupBoxAffine
            // 
            this.groupBoxAffine.Controls.Add(this.btnGo);
            this.groupBoxAffine.Controls.Add(this.groupBoxTranslate);
            this.groupBoxAffine.Controls.Add(this.groupBoxScale);
            this.groupBoxAffine.Controls.Add(this.groupBoxRotate);
            this.groupBoxAffine.Location = new System.Drawing.Point(25, 208);
            this.groupBoxAffine.Name = "groupBoxAffine";
            this.groupBoxAffine.Size = new System.Drawing.Size(183, 359);
            this.groupBoxAffine.TabIndex = 8;
            this.groupBoxAffine.TabStop = false;
            this.groupBoxAffine.Text = "Affine";
            // 
            // btnGo
            // 
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Location = new System.Drawing.Point(50, 314);
            this.btnGo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(92, 37);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.OnClickBtnGo);
            // 
            // groupBoxTranslate
            // 
            this.groupBoxTranslate.Controls.Add(this.lblTy);
            this.groupBoxTranslate.Controls.Add(this.lblTx);
            this.groupBoxTranslate.Controls.Add(this.textBoxTy);
            this.groupBoxTranslate.Controls.Add(this.textBoxTx);
            this.groupBoxTranslate.Location = new System.Drawing.Point(19, 26);
            this.groupBoxTranslate.Name = "groupBoxTranslate";
            this.groupBoxTranslate.Size = new System.Drawing.Size(147, 90);
            this.groupBoxTranslate.TabIndex = 5;
            this.groupBoxTranslate.TabStop = false;
            this.groupBoxTranslate.Text = "Translate";
            // 
            // textBoxTy
            // 
            this.textBoxTy.BackColor = System.Drawing.Color.White;
            this.textBoxTy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTy.Location = new System.Drawing.Point(31, 53);
            this.textBoxTy.Name = "textBoxTy";
            this.textBoxTy.Size = new System.Drawing.Size(92, 20);
            this.textBoxTy.TabIndex = 5;
            this.textBoxTy.Text = "0";
            this.textBoxTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTx
            // 
            this.textBoxTx.BackColor = System.Drawing.Color.White;
            this.textBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTx.Location = new System.Drawing.Point(31, 27);
            this.textBoxTx.Name = "textBoxTx";
            this.textBoxTx.Size = new System.Drawing.Size(92, 20);
            this.textBoxTx.TabIndex = 4;
            this.textBoxTx.Text = "0";
            this.textBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxScale
            // 
            this.groupBoxScale.Controls.Add(this.lblSy);
            this.groupBoxScale.Controls.Add(this.lblSx);
            this.groupBoxScale.Controls.Add(this.textBoxSy);
            this.groupBoxScale.Controls.Add(this.textBoxSx);
            this.groupBoxScale.Location = new System.Drawing.Point(19, 120);
            this.groupBoxScale.Name = "groupBoxScale";
            this.groupBoxScale.Size = new System.Drawing.Size(147, 90);
            this.groupBoxScale.TabIndex = 6;
            this.groupBoxScale.TabStop = false;
            this.groupBoxScale.Text = "Scale";
            // 
            // textBoxSy
            // 
            this.textBoxSy.BackColor = System.Drawing.Color.White;
            this.textBoxSy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSy.Location = new System.Drawing.Point(31, 53);
            this.textBoxSy.Name = "textBoxSy";
            this.textBoxSy.Size = new System.Drawing.Size(92, 20);
            this.textBoxSy.TabIndex = 7;
            this.textBoxSy.Text = "1";
            this.textBoxSy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressTextBoxSy);
            // 
            // textBoxSx
            // 
            this.textBoxSx.BackColor = System.Drawing.Color.White;
            this.textBoxSx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSx.Location = new System.Drawing.Point(31, 27);
            this.textBoxSx.Name = "textBoxSx";
            this.textBoxSx.Size = new System.Drawing.Size(92, 20);
            this.textBoxSx.TabIndex = 6;
            this.textBoxSx.Text = "1";
            this.textBoxSx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressTextBoxSx);
            // 
            // groupBoxRotate
            // 
            this.groupBoxRotate.Controls.Add(this.textBoxRotate);
            this.groupBoxRotate.Location = new System.Drawing.Point(19, 216);
            this.groupBoxRotate.Name = "groupBoxRotate";
            this.groupBoxRotate.Size = new System.Drawing.Size(147, 90);
            this.groupBoxRotate.TabIndex = 7;
            this.groupBoxRotate.TabStop = false;
            this.groupBoxRotate.Text = "Rotate";
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.BackColor = System.Drawing.Color.White;
            this.textBoxRotate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRotate.Location = new System.Drawing.Point(31, 41);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.Size = new System.Drawing.Size(92, 20);
            this.textBoxRotate.TabIndex = 8;
            this.textBoxRotate.Text = "0";
            this.textBoxRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.pictureBox);
            this.groupBoxImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxImage.Location = new System.Drawing.Point(267, 8);
            this.groupBoxImage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBoxImage.Size = new System.Drawing.Size(568, 578);
            this.groupBoxImage.TabIndex = 3;
            this.groupBoxImage.TabStop = false;
            this.groupBoxImage.Text = "Image";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(9, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(550, 539);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // lblTx
            // 
            this.lblTx.Location = new System.Drawing.Point(6, 27);
            this.lblTx.Name = "lblTx";
            this.lblTx.Size = new System.Drawing.Size(21, 23);
            this.lblTx.TabIndex = 6;
            this.lblTx.Text = "X";
            // 
            // lblTy
            // 
            this.lblTy.Location = new System.Drawing.Point(6, 53);
            this.lblTy.Name = "lblTy";
            this.lblTy.Size = new System.Drawing.Size(21, 20);
            this.lblTy.TabIndex = 7;
            this.lblTy.Text = "Y";
            // 
            // lblSx
            // 
            this.lblSx.Location = new System.Drawing.Point(6, 27);
            this.lblSx.Name = "lblSx";
            this.lblSx.Size = new System.Drawing.Size(21, 23);
            this.lblSx.TabIndex = 8;
            this.lblSx.Text = "X";
            // 
            // lblSy
            // 
            this.lblSy.Location = new System.Drawing.Point(6, 53);
            this.lblSy.Name = "lblSy";
            this.lblSy.Size = new System.Drawing.Size(21, 23);
            this.lblSy.TabIndex = 9;
            this.lblSy.Text = "Y";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxImage);
            this.Controls.Add(this.groupBoxOperation);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormMain";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownFormMain);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveFormMain);
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxAffine.ResumeLayout(false);
            this.groupBoxTranslate.ResumeLayout(false);
            this.groupBoxTranslate.PerformLayout();
            this.groupBoxScale.ResumeLayout(false);
            this.groupBoxScale.PerformLayout();
            this.groupBoxRotate.ResumeLayout(false);
            this.groupBoxRotate.PerformLayout();
            this.groupBoxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.GroupBox groupBoxTranslate;
        private System.Windows.Forms.TextBox textBoxTx;
        private System.Windows.Forms.TextBox textBoxTy;
        private System.Windows.Forms.GroupBox groupBoxScale;
        private System.Windows.Forms.TextBox textBoxSy;
        private System.Windows.Forms.TextBox textBoxSx;
        private System.Windows.Forms.GroupBox groupBoxRotate;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.GroupBox groupBoxAffine;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblTy;
        private System.Windows.Forms.Label lblTx;
        private System.Windows.Forms.Label lblSy;
        private System.Windows.Forms.Label lblSx;
    }
}

