using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sprites
{
    public partial class Form1 : Form
    {
        // Khởi tạo 
        // Bitmap dùng cho ảnh sprite 
        private Bitmap sprite;
        //  Back buffer 
        private Bitmap backBuffer;
        private Timer timer;
        public Graphics graphics;
        // Số thự tự của frame (16 frame ảnh) 
        private int index;
        //  dòng hiện tại của frame 
        private int curFrameColumn;
        // cột hiện tại của frame 
        private int curFrameRow; 
        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            // Tạo back buffer 
            backBuffer = new Bitmap(this.ClientSize.Width,
            this.ClientSize.Height);
            // Lấy ảnh sprite 
            sprite = new Bitmap("coin1.png");
            index = 0;
            // Khởi tạo một đồng hồ 
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 60;
            timer.Tick += new EventHandler(timer_Tick);
        } 
        // Vẽ một phần của ảnh sprite 
        private void Render()
        {
            // Lấy đối tượng graphics để vẽ lên back buffer 
            Graphics g = Graphics.FromImage(backBuffer);
            g.Clear(Color.White);
            // Xác dịnh số dòng, cột của một frame trên ảnh sprite 
            curFrameColumn = index % 4;
            curFrameRow = 0;
            // Vẽ lên buffer 
            Rectangle srcRect = new Rectangle(curFrameColumn * 8, curFrameRow * 8, 8, 8);

            // destRect: Vùng vẽ lên màn hình (Phóng to lên 64x64 cho dễ nhìn)
            Rectangle destRect = new Rectangle(120, 120, 64, 64);

            // Vẽ srcRect đè lên destRect
            g.DrawImage(sprite, destRect, srcRect, GraphicsUnit.Pixel);

            // Tăng thứ tự frame để lấy frame tiếp theo 
            index++;
            if (index > 4)
                index = 0;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Render();
            // Vẽ lên màn hình 
            graphics.DrawImageUnscaled(backBuffer, 0, 0);
        }
    }
}
