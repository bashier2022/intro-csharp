using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Memory
    {
        private int _height = 16;
        private int _len = 2;
        private byte[,] _memory;
        private MemoryImaging _memoryImage;
        Action<string, Bitmap> _dataViewer;
        public Memory(Action<string, Bitmap> dataViewer, int capacity)
        {
            _height = capacity / _len;
            if (capacity % _len > 0) _height++;
            _memory = new byte[_height, _len];
            _dataViewer = dataViewer;
            
            _memoryImage = new MemoryImaging(_len, _height);
            _dataViewer(this.ToString(), _memoryImage.Image);

        }

        public Bitmap Image => _memoryImage.Image;
        
        public void Store(int address, byte data)
        {
            if (_height * _len < address) return;
            int r = address / _len;
            int c = address % _len;
            _memory[r, c] = data;
            _memoryImage.Update(r, c, data);
            _dataViewer(this.ToString(), _memoryImage.Image);
        }

        public byte Load(int address)
        {
            if (_height * _len < address) return 0;
            int r = address / _len;
            int c = address % _len;
            return _memory[r, c-1];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            byte cellVal;
            for(int r=0; r < _height; r++)
            {
                for(int c=0; c < _len; c++)
                {
                    cellVal = _memory[r, c];
                    if (cellVal<10)
                    { sb.Append($"0{cellVal}  "); }
                    else
                    { sb.Append($"{cellVal}  "); }                    
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
