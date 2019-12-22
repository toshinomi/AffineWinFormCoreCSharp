using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffineWinFormCoreCSharp
{
    /// <summary>
    /// MainFormのロジック
    /// </summary>
    public partial class FormMain : Form
    {
        private Point m_mousePoint;
        private string m_strOpenFileName;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            lblTitle.MouseDown += new MouseEventHandler(OnMouseDownLblTitle);
            lblTitle.MouseMove += new MouseEventHandler(OnMouseMoveLblTitle);
        }

        /// <summary>
        /// タイトルバーマウスダウンのクリックイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベントのデータ</param>
        private void OnMouseDownLblTitle(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                m_mousePoint = new Point(e.X, e.Y);
            }
        }

        /// <summary>
        /// タイトルバーマウスムーブのクリックイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベントのデータ</param>
        private void OnMouseMoveLblTitle(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - m_mousePoint.X;
                this.Top += e.Y - m_mousePoint.Y;
            }
        }

        /// <summary>
        /// ファイル選択ボタンのクリックイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベントのデータ</param>
        private void OnClickBtnFileSelect(object sender, EventArgs e)
        {
            ComOpenFileDialog openFileDlg = new ComOpenFileDialog();
            openFileDlg.Filter = "JPG|*.jpg|PNG|*.png";
            openFileDlg.Title = "Open the file";
            if (openFileDlg.ShowDialog() == true)
            {
                pictureBox.Image = null;
                m_strOpenFileName = openFileDlg.FileName;
                pictureBox.ImageLocation = m_strOpenFileName;
            }

            return;
        }

        /// <summary>
        /// 閉じるボタンのクリックイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベントのデータ</param>
        private void OnClickBtnClose(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Close the application ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 初期化ボタンのクリックイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベントのデータ</param>
        private void OnClickBtnInit(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(m_strOpenFileName))
            {
                pictureBox.ImageLocation = m_strOpenFileName;
            }
        }

        /// <summary>
        /// アフィン変換実行ボタンのクリックイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベントのデータ</param>
        private void OnClickBtnGo(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(m_strOpenFileName))
            {
                return;
            }

            AffineInfo affineInfo = new AffineInfo();
            if (!IsEmpty(textBoxTx.Text))
            {
                affineInfo.Translate.Tx = float.Parse(textBoxTx.Text);
            }
            if (!IsEmpty(textBoxTy.Text))
            {
                affineInfo.Translate.Ty = float.Parse(textBoxTy.Text);
            }

            if (!IsEmpty(textBoxSx.Text))
            {
                affineInfo.Scale.Sx = float.Parse(textBoxSx.Text);
            }
            if (!IsEmpty(textBoxSy.Text))
            {
                affineInfo.Scale.Sy = float.Parse(textBoxSy.Text);
            }

            if (!IsEmpty(textBoxRotate.Text))
            {
                affineInfo.Rotate.Angle = float.Parse(textBoxRotate.Text);
            }

            pictureBox.Image = Affine(affineInfo);
        }

        /// <summary>
        /// 文字列の空のチェック
        /// </summary>
        /// <param name="_str">画像処理の名称</param>
        /// <returns>文字列の空のチェックの結果 文字列なし/文字列あり</returns>
        public bool IsEmpty(string _str)
        {
            bool bIsEmpty = false;
            if (string.IsNullOrWhiteSpace(_str))
            {
                bIsEmpty = true;
            }

            return bIsEmpty;
        }

        /// <summary>
        /// アフィン変換
        /// </summary>
        /// <param name="_affineInfo">アフィン変換情報</param>
        /// <returns>アフィン変換のイメージ</returns>
        public Image Affine(AffineInfo _affineInfo)
        {
            float fTx = _affineInfo.Translate.Tx;
            float fTy = _affineInfo.Translate.Ty;
            float fSx = _affineInfo.Scale.Sx;
            float fSy = _affineInfo.Scale.Sy;
            float fAngle = _affineInfo.Rotate.Angle;

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            Image image = Image.FromFile(m_strOpenFileName);

            graphics.ResetTransform();
            graphics.TranslateTransform(fTx, fTy, System.Drawing.Drawing2D.MatrixOrder.Append);
            graphics.ScaleTransform(fSx, fSy);
            graphics.RotateTransform(fAngle, System.Drawing.Drawing2D.MatrixOrder.Append);
            graphics.DrawImage(image, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));

            image.Dispose();
            graphics.Dispose();

            return bitmap;
        }

        /// <summary>
        /// スケールXのテキストボックスのキー入力イベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">キー入力イベントのデータ</param>
        private void OnKeyPressTextBoxSx(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                TextBox textbox = (TextBox)sender;
                if (textbox.TextLength <= 0)
                {
                    e.Handled = true;
                    return;
                }
                if (CountChar(textbox.Text, ".") >= 1)
                {
                    e.Handled = true;
                    return;
                }
            }
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            return;
        }

        /// <summary>
        /// スケールYのテキストボックスのキー入力イベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">キー入力イベントのデータ</param>
        private void OnKeyPressTextBoxSy(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                TextBox textbox = (TextBox)sender;
                if (textbox.TextLength <= 0)
                {
                    e.Handled = true;
                    return;
                }
                if (CountChar(textbox.Text, ".") >= 1)
                {
                    e.Handled = true;
                    return;
                }
            }
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            return;
        }

        /// <summary>
        /// 文字列から指定の文字をカウントする
        /// </summary>
        /// <param name="_str">文字列</param>
        /// <param name="_strChar">カウントする文字</param>
        /// <returns>カウント数</returns>
        public int CountChar(string _str, string _strChar)
        {
            return _str.Length - _str.Replace(_strChar, "").Length;
        }
    }

    /// <summary>
    /// アフィン変換情報
    /// </summary>
    public class AffineInfo
    {
        private Translate m_translate;
        private Scale m_scale;
        private Rotate m_rotate;

        /// <summary>
        /// 移動情報
        /// </summary>
        public Translate Translate
        {
            set {m_translate = value; }
            get { return m_translate; }
        }

        /// <summary>
        /// 拡大・縮小情報
        /// </summary>
        public Scale Scale
        {
            set { m_scale = value; }
            get { return m_scale; }
        }

        /// <summary>
        /// 回転情報
        /// </summary>
        public Rotate Rotate
        {
            set { m_rotate = value; }
            get { return m_rotate; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AffineInfo()
        {
            m_translate = new Translate();
            m_scale = new Scale();
            m_rotate = new Rotate();
        }

        /// <summary>
        /// デスクトラクタ
        /// </summary>
        ~AffineInfo()
        {
        }
    }

    /// <summary>
    /// 移動情報
    /// </summary>
    public class Translate
    {
        private float m_fTx;
        private float m_fTy;

        /// <summary>
        /// X方向の移動
        /// </summary>
        public float Tx
        {
            set { m_fTx = value; }
            get { return m_fTx; }
        }

        /// <summary>
        /// Y方向の移動
        /// </summary>
        public float Ty
        {
            set { m_fTy = value; }
            get { return m_fTy; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Translate()
        {
            m_fTx = 0.0F;
            m_fTy = 0.0F;
        }

        /// <summary>
        /// デスクトラクタ
        /// </summary>
        ~Translate()
        {
        }
    }

    /// <summary>
    /// 拡大・縮小情報
    /// </summary>
    public class Scale
    {
        private float m_fSx;
        private float m_fSy;

        /// <summary>
        /// X方向の拡大・縮小
        /// </summary>
        public float Sx
        {
            set
            {
                if (value > 0)
                {
                    m_fSx = value;
                }
            }
            get { return m_fSx; }
        }

        /// <summary>
        /// Y方向の拡大・縮小
        /// </summary>
        public float Sy
        {
            set
            {
                if (value > 0)
                {
                    m_fSy = value;
                }
            }
            get { return m_fSy; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Scale()
        {
            m_fSx = 1.0F;
            m_fSy = 1.0F;
        }

        /// <summary>
        /// デスクトラクタ
        /// </summary>
        ~Scale()
        {
        }
    }

    /// <summary>
    /// 回転情報
    /// </summary>
    public class Rotate
    {
        private float m_angle;

        /// <summary>
        /// 回転
        /// </summary>
        public float Angle
        {
            set { m_angle = value; }
            get { return m_angle; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Rotate()
        {
            m_angle = 0.0F;
        }

        /// <summary>
        /// デスクトラクタ
        /// </summary>
        ~Rotate()
        {
        }
    }
}