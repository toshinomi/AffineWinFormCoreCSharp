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
    public partial class FormMain : Form
    {
        private Point m_mousePoint;
        private string m_strOpenFileName;

        public FormMain()
        {
            InitializeComponent();

            groupBoxOperation.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            groupBoxOperation.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            btnFileSelect.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            btnFileSelect.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            btnClose.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            btnClose.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);

            groupBoxImage.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            groupBoxImage.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            pictureBox.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            pictureBox.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);

            groupBoxTranslate.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            groupBoxTranslate.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            textBoxTx.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            textBoxTx.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            textBoxTy.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            textBoxTy.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);

            groupBoxScale.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            groupBoxScale.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            textBoxSx.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            textBoxSx.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            textBoxSy.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            textBoxSy.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);

            groupBoxRotate.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            groupBoxRotate.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            textBoxRotate.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            textBoxRotate.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
            btnGo.MouseDown += new MouseEventHandler(OnMouseDownFormMain);
            btnGo.MouseMove += new MouseEventHandler(OnMouseMoveFormMain);
        }

        private void OnMouseDownFormMain(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                m_mousePoint = new Point(e.X, e.Y);
            }
        }

        private void OnMouseMoveFormMain(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - m_mousePoint.X;
                this.Top += e.Y - m_mousePoint.Y;
            }
        }

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

        private void OnClickBtnClose(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Close the application ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void OnClickBtnInit(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(m_strOpenFileName))
            {
                pictureBox.ImageLocation = m_strOpenFileName;
            }
        }

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

        public bool IsEmpty(string _str)
        {
            bool bIsEmpty = false;
            if (string.IsNullOrWhiteSpace(_str))
            {
                bIsEmpty = true;
            }

            return bIsEmpty;
        }

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

        private void OnKeyPressTextBoxSx(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                TextBox textbox = (TextBox)sender;
                if (CountChar(textbox.Text, '.') >= 1)
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

        private void OnKeyPressTextBoxSy(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                TextBox textbox = (TextBox)sender;
                if (CountChar(textbox.Text, '.') >= 1)
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

        public int CountChar(string _str, char _char)
        {
            return _str.Length - _str.Replace(_char.ToString(), "").Length;
        }
    }

    public class AffineInfo
    {
        private Translate m_translate;
        private Scale m_scale;
        private Rotate m_rotate;

        public Translate Translate
        {
            set {m_translate = value; }
            get { return m_translate; }
        }
        public Scale Scale
        {
            set { m_scale = value; }
            get { return m_scale; }
        }
        public Rotate Rotate
        {
            set { m_rotate = value; }
            get { return m_rotate; }
        }

        public AffineInfo()
        {
            m_translate = new Translate();
            m_scale = new Scale();
            m_rotate = new Rotate();
        }

        ~AffineInfo()
        {
        }
    }

    public class Translate
    {
        private float m_fTx;
        private float m_fTy;

        public float Tx
        {
            set { m_fTx = value; }
            get { return m_fTx; }
        }
        public float Ty
        {
            set { m_fTy = value; }
            get { return m_fTy; }
        }
        public Translate()
        {
            m_fTx = 0F;
            m_fTy = 0F;
        }

        ~Translate()
        {
        }
    }

    public class Scale
    {
        private float m_fSx;
        private float m_fSy;

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
        public Scale()
        {
            m_fSx = 1F;
            m_fSy = 1F;
        }

        ~Scale()
        {
        }
    }

    public class Rotate
    {
        private float m_angle;

        public float Angle
        {
            set { m_angle = value; }
            get { return m_angle; }
        }
        public Rotate()
        {
            m_angle = 0F;
        }

        ~Rotate()
        {
        }
    }
}