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
            this.groupBoxOperation = new System.Windows.Forms.Label();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxAffine = new System.Windows.Forms.Label();
            this.groupBoxTranslate = new System.Windows.Forms.Label();
            this.groupBoxScale = new System.Windows.Forms.Label();
            this.groupBoxRotate = new System.Windows.Forms.Label();
            this.textBoxTx = new System.Windows.Forms.TextBox();
            this.textBoxTy = new System.Windows.Forms.TextBox();
            this.textBoxSy = new System.Windows.Forms.TextBox();
            this.textBoxSx = new System.Windows.Forms.TextBox();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBoxImage = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTx = new System.Windows.Forms.Label();
            this.lblTy = new System.Windows.Forms.Label();
            this.lblSx = new System.Windows.Forms.Label();
            this.lblSy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxOperation.Location = new System.Drawing.Point(24, 72);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(480, 1158);
            this.groupBoxOperation.TabIndex = 0;
            this.groupBoxOperation.Text = "Operation";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFileSelect.Location = new System.Drawing.Point(111, 133);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(300, 100);
            this.btnFileSelect.TabIndex = 1;
            this.btnFileSelect.Text = "File Select...";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.OnClickBtnFileSelect);
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInit.Location = new System.Drawing.Point(111, 251);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(300, 100);
            this.btnInit.TabIndex = 2;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.OnClickBtnInit);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(111, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(300, 100);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // groupBoxAffine
            // 
            this.groupBoxAffine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxAffine.Location = new System.Drawing.Point(80, 489);
            this.groupBoxAffine.Name = "groupBoxAffine";
            this.groupBoxAffine.Size = new System.Drawing.Size(366, 725);
            this.groupBoxAffine.TabIndex = 4;
            this.groupBoxAffine.Text = "Affine";
            // 
            // groupBoxTranslate
            // 
            this.groupBoxTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxTranslate.Location = new System.Drawing.Point(111, 543);
            this.groupBoxTranslate.Name = "groupBoxTranslate";
            this.groupBoxTranslate.Size = new System.Drawing.Size(300, 180);
            this.groupBoxTranslate.TabIndex = 5;
            this.groupBoxTranslate.Text = "Translate";
            // 
            // groupBoxScale
            // 
            this.groupBoxScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxScale.Location = new System.Drawing.Point(111, 736);
            this.groupBoxScale.Name = "groupBoxScale";
            this.groupBoxScale.Size = new System.Drawing.Size(300, 180);
            this.groupBoxScale.TabIndex = 6;
            this.groupBoxScale.Text = "Scale";
            // 
            // groupBoxRotate
            // 
            this.groupBoxRotate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxRotate.Location = new System.Drawing.Point(111, 929);
            this.groupBoxRotate.Name = "groupBoxRotate";
            this.groupBoxRotate.Size = new System.Drawing.Size(300, 180);
            this.groupBoxRotate.TabIndex = 7;
            this.groupBoxRotate.Text = "Rotate";
            // 
            // textBoxTx
            // 
            this.textBoxTx.Location = new System.Drawing.Point(173, 594);
            this.textBoxTx.Name = "textBoxTx";
            this.textBoxTx.Size = new System.Drawing.Size(184, 54);
            this.textBoxTx.TabIndex = 4;
            this.textBoxTx.Text = "0";
            this.textBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTy
            // 
            this.textBoxTy.Location = new System.Drawing.Point(173, 654);
            this.textBoxTy.Name = "textBoxTy";
            this.textBoxTy.Size = new System.Drawing.Size(184, 54);
            this.textBoxTy.TabIndex = 5;
            this.textBoxTy.Text = "0";
            this.textBoxTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSy
            // 
            this.textBoxSy.Location = new System.Drawing.Point(173, 848);
            this.textBoxSy.Name = "textBoxSy";
            this.textBoxSy.Size = new System.Drawing.Size(184, 54);
            this.textBoxSy.TabIndex = 7;
            this.textBoxSy.Text = "1";
            this.textBoxSy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressTextBoxSy);
            // 
            // textBoxSx
            // 
            this.textBoxSx.Location = new System.Drawing.Point(173, 788);
            this.textBoxSx.Name = "textBoxSx";
            this.textBoxSx.Size = new System.Drawing.Size(184, 54);
            this.textBoxSx.TabIndex = 6;
            this.textBoxSx.Text = "1";
            this.textBoxSx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressTextBoxSx);
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.Location = new System.Drawing.Point(173, 1002);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.Size = new System.Drawing.Size(184, 54);
            this.textBoxRotate.TabIndex = 8;
            this.textBoxRotate.Text = "0";
            this.textBoxRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGo.Location = new System.Drawing.Point(173, 1125);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(184, 74);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.OnClickBtnGo);
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxImage.Location = new System.Drawing.Point(527, 74);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(1154, 1156);
            this.groupBoxImage.TabIndex = 11;
            this.groupBoxImage.Text = "Image";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(544, 133);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1118, 1080);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1698, 55);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Affine";
            // 
            // lblTx
            // 
            this.lblTx.Location = new System.Drawing.Point(118, 598);
            this.lblTx.Name = "lblTx";
            this.lblTx.Size = new System.Drawing.Size(50, 50);
            this.lblTx.TabIndex = 14;
            this.lblTx.Text = "X";
            // 
            // lblTy
            // 
            this.lblTy.Location = new System.Drawing.Point(118, 655);
            this.lblTy.Name = "lblTy";
            this.lblTy.Size = new System.Drawing.Size(50, 50);
            this.lblTy.TabIndex = 15;
            this.lblTy.Text = "Y";
            // 
            // lblSx
            // 
            this.lblSx.Location = new System.Drawing.Point(117, 794);
            this.lblSx.Name = "lblSx";
            this.lblSx.Size = new System.Drawing.Size(50, 50);
            this.lblSx.TabIndex = 16;
            this.lblSx.Text = "X";
            // 
            // lblSy
            // 
            this.lblSy.Location = new System.Drawing.Point(117, 850);
            this.lblSy.Name = "lblSy";
            this.lblSy.Size = new System.Drawing.Size(50, 50);
            this.lblSy.TabIndex = 17;
            this.lblSy.Text = "Y";
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1700, 1250);
            this.Controls.Add(this.lblSy);
            this.Controls.Add(this.lblSx);
            this.Controls.Add(this.lblTy);
            this.Controls.Add(this.lblTx);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.textBoxRotate);
            this.Controls.Add(this.textBoxSy);
            this.Controls.Add(this.textBoxSx);
            this.Controls.Add(this.textBoxTx);
            this.Controls.Add(this.textBoxTy);
            this.Controls.Add(this.groupBoxRotate);
            this.Controls.Add(this.groupBoxScale);
            this.Controls.Add(this.groupBoxTranslate);
            this.Controls.Add(this.groupBoxAffine);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.groupBoxOperation);
            this.Controls.Add(this.groupBoxImage);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();

        }

        #endregion
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox textBoxTx;
        private System.Windows.Forms.TextBox textBoxTy;
        private System.Windows.Forms.TextBox textBoxSy;
        private System.Windows.Forms.TextBox textBoxSx;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label groupBoxOperation;
        private System.Windows.Forms.Label groupBoxAffine;
        private System.Windows.Forms.Label groupBoxTranslate;
        private System.Windows.Forms.Label groupBoxScale;
        private System.Windows.Forms.Label groupBoxRotate;
        private System.Windows.Forms.Label groupBoxImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTx;
        private System.Windows.Forms.Label lblTy;
        private System.Windows.Forms.Label lblSx;
        private System.Windows.Forms.Label lblSy;
    }
}

