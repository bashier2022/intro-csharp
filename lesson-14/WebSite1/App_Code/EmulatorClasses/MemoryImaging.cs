using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Text;

/// <summary>
/// Summary description for MemoryImaging
/// </summary>
public class MemoryBit
{
    private int _val = 0;
    private Bitmap _bitmap;
    private int _bmW = 20;
    private int _bmH = 30;
    public MemoryBit(int val)
    {
        _val = val;
        BitToImage();
        AddDataToBitImage();
    }
    public Bitmap Image => _bitmap;
    public void BitToImage()
    {
        _bitmap = new Bitmap(_bmW, _bmH);
        for (int i = 0; i < _bmH; i++)
        {
            for (int j = 0; j < _bmW; j++)
            {
                _bitmap.SetPixel(j, i, Color.Pink);
            }
        }
        DrawBorder();
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
    private void DrawBorder()
    {
        for (int y = 0; y < _bmH; y++)
        {
            _bitmap.SetPixel(0, y, Color.Black);
            _bitmap.SetPixel(_bmW - 1, y, Color.Black);
        }
        for (int x = 0; x < _bmW; x++)
        {
            _bitmap.SetPixel(x, _bmH - 1, Color.Black);
            _bitmap.SetPixel(x, 0, Color.Black);
        }
    }
}

public class MemoryTwoByte
{
    private short _val;
    private Bitmap _bitMap;
    private int _bmW = 356;
    private int _bmH = 32;
    public MemoryTwoByte(short val)
    {
        _val = val;
        CreateTwoByteMap();

    }

    public Bitmap Image => _bitMap;
    private void CreateTwoByteMap()
    {
        _bitMap = new Bitmap(_bmW, _bmH);
        TwoByteToBitmap();
        CreateBorder();
    }

    private void CreateBorder()
    {
        //for (int x = 0; x < _bmW; x++)
        //{
        //    _bitMap.SetPixel(x, 0, Color.Black);
        //    _bitMap.SetPixel(x, _bmH-1, Color.Black);
        //}
        //for (int y = 0; y < _bmH; y++)
        //{
        //    int x= 1;
        //    while (x < _bmW)
        //    { 
        //        _bitMap.SetPixel(x, y, Color.Black);
        //        x += 22; 
        //    }
        //}
    }

    public void TwoByteToBitmap()
    {
        MemoryBit mb;
        string bs = Convert.ToString(_val, 2);
        bs = CompleteTo16Bit(bs);
        for (int i = 0; i < bs.Length; i++)
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

    private string CompleteTo16Bit(string bs)
    {
        int n = bs.Length;
        for (int i = 0; i < 16 - n; i++)
        {
            bs = "0" + bs;
        }
        return bs;
    }

    private void AddBitImage(int n, MemoryBit mb)
    {
        int dx = 2 + n * (20 + 2);
        int w = mb.Image.Width;
        int h = mb.Image.Height;

        for (int y = 0; y < h; y++)
            for (int x = 0; x < w; x++)
                _bitMap.SetPixel(dx + x, y, mb.Image.GetPixel(x, y));
    }

    public override string ToString()
    {
        string binstr = Convert.ToString(_val, 2);
        int n = binstr.Length;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 16 - n; i++)
            sb.Append("0");
        sb.Append(binstr);
        return sb.ToString();
    }
}
public class MemoryImaging
{
    private int _dataX = 1;
    private int _dataY = 3;
    private Bitmap _bitMap;

    public MemoryImaging(int width, int height)
    {
        _bitMap = new Bitmap(width * 365, height * 35);
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
                AddTwoByteImage(y, x, new MemoryTwoByte(0));
            }
        }
    }

    private void AddTwoByteImage(int i, int j, MemoryTwoByte memoryTwoByte)
    {
        int w = memoryTwoByte.Image.Width;
        int h = memoryTwoByte.Image.Height;
        int dx = 2 + (w + 2) * j;
        int dy = 2 + (h + 2) * i;

        for (int y = 0; y < h; y++)
            for (int x = 0; x < w; x++)
                _bitMap.SetPixel(dx + x, dy + y, memoryTwoByte.Image.GetPixel(x, y));
    }

    public Bitmap Image => _bitMap;
    private void Setpixels(int x, int y)
    {
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                _bitMap.SetPixel(j + x, i + y, Color.Red);
    }

    public void Update(int r, int c, short data)
    {
        AddTwoByteImage(r, c, new MemoryTwoByte(data));
    }
}