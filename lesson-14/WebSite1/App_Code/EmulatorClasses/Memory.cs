using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Text;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for Memory
/// </summary>
public class Memory
{
    private int _height = 16;
    private int _len = 1;
    private short[,] _memory;
    private MemoryImaging _memoryImage;
    public Action<ListItemCollection, Bitmap> _dataViewer;
    public Memory(Action<ListItemCollection, Bitmap> dataViewer, int capacity)
    {
        _height = capacity / _len;
        if (capacity % _len > 0) _height++;
        _memory = new short[_height, _len];
        _dataViewer = dataViewer;

        _memoryImage = new MemoryImaging(_len, _height);
        _dataViewer(CollectData(), new Bitmap(20, 20));//_memoryImage.Image);

    }

    public Bitmap Image => _memoryImage.Image;

    public void Store(int address, short data)
    {
        if (_height * _len < address) return;
        int r = address / _len;
        int c = address % _len;
        _memory[r, c] = data;
        //_memoryImage.Update(r, c, data);
        _dataViewer(CollectData(), _memoryImage.Image);
    }

    public short Load(int address)
    {
        if (_height * _len < address) return 0;
        int r = address / _len;
        int c = address % _len;
        return _memory[r, c];
    }
    public ListItemCollection CollectData()
    {
        var memItems = new ListItemCollection();
        foreach(var item in _memory)
        {
            memItems.Add(item.ToString());
        }
        return memItems;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        short cellVal;
        for (int r = 0; r < _height; r++)
        {
            for (int c = 0; c < _len; c++)
            {
                cellVal = _memory[r, c];
                if (cellVal < 10)
                { sb.Append($"0{cellVal}  "); }
                else
                { sb.Append($"{cellVal}  "); }
            }
            sb.Append("\r\n");
        }
        return sb.ToString();
    }
}