using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Emulator
{
    public class MemoryBit
    {
        private int _val = 0;
        private Bitmap _bitmap;
        private int _bmW = 20;
        private int _bmH = 30;
        public MemoryBit(int val)
        {
            _val = val;
            _bitmap = BitToImage();
            AddDataToBitImage();
        }
        public Bitmap Image => _bitmap;
        public Bitmap BitToImage()
        {
            Bitmap bm = new Bitmap(_bmW, _bmH);
            for (int i = 0; i<bm.Height; i++)
            {
                for (int j = 0; j<bm.Width; j++)
                {
                    bm.SetPixel(j,i, Color.Pink);
                }
            }
            return bm;
        }
        public void AddDataToBitImage()
        {
            int dx = 5, dy = 5;
            Color color = Color.Blue;
            if (_val == 0)
            {
                dx = 2;
                dy = 12;
                color = Color.DarkGreen;
            }
            for (int r = dy; r < _bmH - dy; r++)
                for (int c = dx; c < _bmW - dx; c++)
                {
                    _bitmap.SetPixel(c, r, color);
                }
        }
    }

    public class MemoryByte
    {
        private byte _val;
        private Bitmap _bitMap;
        private int _bmW = 178;
        private int _bmH = 32;
        public MemoryByte(byte val)
        {
            _val = val;
            CreateByteMap();

        }

        public Bitmap Image => _bitMap;
        private void CreateByteMap()
        {
            _bitMap = new Bitmap(_bmW, _bmH);
            ByteToBitmap();
            CreateBorder();
        }

        private void CreateBorder()
        {
            for (int x = 0; x < _bmW; x++)
            {
                _bitMap.SetPixel(x, 0, Color.Black);
                _bitMap.SetPixel(x, _bmH-1, Color.Black);
            }
            for (int y = 0; y < _bmH; y++)
            {
                int x= 1;
                while (x < _bmW)
                { 
                    _bitMap.SetPixel(x, y, Color.Black);
                    x += 22; 
                }
            }
        }

        public void ByteToBitmap()
        {
            MemoryBit mb;
            string bs = this.ToString();
            for(int i=0; i<bs.Length;i++)
            {
                if (bs[i] == '1')
                {
                    mb = new MemoryBit(1);
                }
                else
                {
                    mb = new MemoryBit(0);
                }
                AddBitImage(i, mb);
            }
        }

        private void AddBitImage(int n, MemoryBit mb)
        {
            int dx = 2 + n * (20 + 2);
            int w = mb.Image.Width; 
            int h = mb.Image.Height;

            for (int y = 0; y<h; y++)
                for (int x=0; x < w; x++)
                _bitMap.SetPixel(dx+x, y, mb.Image.GetPixel(x, y));
        }

        public override string ToString()
        {
            string binstr = Convert.ToString(_val, 2);
            int n =  binstr.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i< 8-n; i++)
                sb.Append("0");
            sb.Append(binstr);
            return sb.ToString();
        }
    }
    public class MemoryImaging
    {
        private int _dataX = 2;
        private int _dataY = 3;
        private Bitmap _bitMap;

        public MemoryImaging(int width, int height)
        {
            _bitMap = new Bitmap(width * 180, height * 35);
            _dataX = width;
            _dataY = height;
            BildTheImage();
        }

        private void BildTheImage()
        {
            for (int y = 0; y < _dataY; y++)
            {
                for (int x = 0; x < _dataX; x++)
                {
                    AddByteImage(y, x, new MemoryByte(5));
                }
            }            
        }

        private void AddByteImage(int i, int j, MemoryByte memoryByte)
        {
            int w = memoryByte.Image.Width;
            int h = memoryByte.Image.Height;
            int dx = 2 + (w +2) * j;
            int dy = 2 + (h +2) * i;

            for (int y = 0; y<h; y++)
                for (int x = 0; x < w; x++)
                    _bitMap.SetPixel(dx + x, dy + y, memoryByte.Image.GetPixel(x, y));
        }

        public Bitmap Image => _bitMap;
        private void Setpixels(int x, int y)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    _bitMap.SetPixel(j+x, i+y, Color.Red);
        }

        public void Update(int r, int c, byte data)
        {
            AddByteImage(r,c, new MemoryByte(data));
        }
    }
}
